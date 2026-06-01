using appliPandora;
using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace appStargate
{
    public partial class FormStats : Form
    {
        public FormStats()
        {
            InitializeComponent();
            this.Load += FormStats_Load;
        }

        private void FormStats_Load(object sender, EventArgs e)
        {
            ChargerDonnees();
            ChargerComboMembres();
            ChargerComboMissions();
            RequeteMissionsGrandes();
            RequeteMissionsPlanete();
            RequeteDepensesMax();
        }

        // ─── CHARGEMENT DES DONNÉES ───────────────────────────────────────

        private void ChargerDonnees()
        {
            DataSet ds = MesDatas.DsGlobal;
            string[] tables = { "Membre", "Civil", "Militaire", "Mission",
                                 "Composer", "Depense", "Planete", "Contact",
                                 "Informateur", "Espece", "Ennemi" };

            foreach (string nomTable in tables)
            {
                if (ds.Tables.Contains(nomTable)) continue;
                try
                {
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(
                        $"SELECT * FROM {nomTable}", Connexion.Connec
                    );
                    adapter.Fill(ds, nomTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur chargement {nomTable} : {ex.Message}");
                }
            }
            Connexion.FermerConnexion();
        }

        // ─── REQUÊTE 1 : MEMBRES COMMUNS ──────────────────────────────────

        private void ChargerComboMembres()
        {
            cboMembres.Items.Clear();
            DataTable dtMembres = MesDatas.DsGlobal.Tables["Membre"];

            foreach (DataRow row in dtMembres.Rows)
            {
                string matricule = row["matricule"].ToString();
                string nom = row["nom"].ToString();
                string prenom = row["prenom"].ToString();
                cboMembres.Items.Add($"{prenom} {nom} ({matricule})");
            }

            if (cboMembres.Items.Count > 0)
                cboMembres.SelectedIndex = 0;
        }

        private void cboMembres_SelectedIndexChanged(object sender, EventArgs e)
        {
            RequeteMembresCommuns();
        }

        private void RequeteMembresCommuns()
        {
            if (cboMembres.SelectedIndex < 0) return;

            // Récupère la matricule depuis le texte sélectionné
            string selected = cboMembres.SelectedItem.ToString();
            string matricule = selected.Substring(
                selected.LastIndexOf('(') + 1,
                selected.LastIndexOf(')') - selected.LastIndexOf('(') - 1
            );

            DataSet ds = MesDatas.DsGlobal;
            DataTable dtComposer = ds.Tables["Composer"];
            DataTable dtMembres = ds.Tables["Membre"];
            DataTable dtCivil = ds.Tables["Civil"];
            DataTable dtMilitaire = ds.Tables["Militaire"];

            // Missions du membre sélectionné
            DataRow[] missionsDuMembre = dtComposer.Select($"matriculeMembre = '{matricule}'");

            DataTable dtAffichage = new DataTable();
            dtAffichage.Columns.Add("Nom");
            dtAffichage.Columns.Add("Prénom");
            dtAffichage.Columns.Add("Type");
            dtAffichage.Columns.Add("Mission");

            foreach (DataRow missionRow in missionsDuMembre)
            {
                string nomPlanete = missionRow["nomPlanete"].ToString();
                int numeroMission = Convert.ToInt32(missionRow["numeroMission"]);

                // Autres membres de la même mission
                DataRow[] autresMembres = dtComposer.Select(
                    $"nomPlanete = '{nomPlanete}' AND numeroMission = {numeroMission} AND matriculeMembre != '{matricule}'"
                );

                foreach (DataRow autreMembre in autresMembres)
                {
                    string autreMatricule = autreMembre["matriculeMembre"].ToString();

                    DataRow[] membreRows = dtMembres.Select($"matricule = '{autreMatricule}'");
                    if (membreRows.Length == 0) continue;

                    string nom = membreRows[0]["nom"].ToString();
                    string prenom = membreRows[0]["prenom"].ToString();

                    // Déterminer si Civil ou Militaire
                    string type = "Inconnu";
                    if (dtCivil.Select($"matriculeMembre = '{autreMatricule}'").Length > 0)
                        type = "Civil";
                    else if (dtMilitaire.Select($"matriculeMembre = '{autreMatricule}'").Length > 0)
                        type = "Militaire";

                    string nomMission = $"{nomPlanete}-{numeroMission}";

                    // Évite les doublons
                    bool dejaPresent = false;
                    foreach (DataRow r in dtAffichage.Rows)
                    {
                        if (r["Nom"].ToString() == nom && r["Prénom"].ToString() == prenom)
                        {
                            dejaPresent = true;
                            break;
                        }
                    }

                    if (!dejaPresent)
                        dtAffichage.Rows.Add(nom, prenom, type, nomMission);
                }
            }

            dgvMembresCommuns.DataSource = dtAffichage;
            dgvMembresCommuns.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMembresCommuns.RowHeadersVisible = false;
            dgvMembresCommuns.AllowUserToAddRows = false;
        }

        // ─── REQUÊTE 2 : MISSIONS > 10 PERSONNES ──────────────────────────

        private void RequeteMissionsGrandes()
        {
            DataSet ds = MesDatas.DsGlobal;
            DataTable dtMissions = ds.Tables["Mission"];
            DataTable dtDepenses = ds.Tables["Depense"];
            DataTable dtComposer = ds.Tables["Composer"];

            DataTable dtAffichage = new DataTable();
            dtAffichage.Columns.Add("Mission");
            dtAffichage.Columns.Add("Budget initial (€)");
            dtAffichage.Columns.Add("Total dépenses (€)");
            dtAffichage.Columns.Add("Budget restant (€)");

            foreach (DataRow mission in dtMissions.Rows)
            {
                string nomPlanete = mission["nomPlanete"].ToString();
                int numero = Convert.ToInt32(mission["numero"]);
                int budget = Convert.ToInt32(mission["budget"]);

                // Compte les membres
                DataRow[] membres = dtComposer.Select(
                    $"nomPlanete = '{nomPlanete}' AND numeroMission = {numero}"
                );

                if (membres.Length <= 10) continue;

                // Total des dépenses
                DataRow[] depenses = dtDepenses.Select(
                    $"nomPlanete = '{nomPlanete}' AND numeroMission = {numero}"
                );

                int totalDepenses = 0;
                foreach (DataRow dep in depenses)
                    totalDepenses += Convert.ToInt32(dep["montant"]);

                dtAffichage.Rows.Add(
                    $"{nomPlanete}-{numero}",
                    $"{budget} €",
                    $"{totalDepenses} €",
                    $"{budget - totalDepenses} €"
                );
            }

            dgvMissionsGrandes.DataSource = dtAffichage;
            dgvMissionsGrandes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMissionsGrandes.RowHeadersVisible = false;
            dgvMissionsGrandes.AllowUserToAddRows = false;
        }

        // ─── REQUÊTE 3 : MISSIONS PAR PLANÈTE ─────────────────────────────

        private void RequeteMissionsPlanete()
        {
            DataSet ds = MesDatas.DsGlobal;
            DataTable dtPlanetes = ds.Tables["Planete"];
            DataTable dtMissions = ds.Tables["Mission"];

            DataTable dtAffichage = new DataTable();
            dtAffichage.Columns.Add("Planète");
            dtAffichage.Columns.Add("Nombre de missions");

            foreach (DataRow planete in dtPlanetes.Rows)
            {
                string nom = planete["nom"].ToString();

                DataRow[] missions = dtMissions.Select($"nomPlanete = '{nom}'");

                dtAffichage.Rows.Add(nom, missions.Length);
            }

            dgvMissionsPlanete.DataSource = dtAffichage;
            dgvMissionsPlanete.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMissionsPlanete.RowHeadersVisible = false;
            dgvMissionsPlanete.AllowUserToAddRows = false;
        }

        // ─── REQUÊTE 4 : DÉPENSES MAX PAR MISSION ─────────────────────────

        private void RequeteDepensesMax()
        {
            DataSet ds = MesDatas.DsGlobal;
            DataTable dtMissions = ds.Tables["Mission"];
            DataTable dtDepenses = ds.Tables["Depense"];
            DataTable dtMembres = ds.Tables["Membre"];

            DataTable dtAffichage = new DataTable();
            dtAffichage.Columns.Add("Dépenses les plus importantes");
            dtAffichage.Columns.Add("Mission");
            dtAffichage.Columns.Add("Chef de mission");

            foreach (DataRow mission in dtMissions.Rows)
            {
                string nomPlanete = mission["nomPlanete"].ToString();
                int numero = Convert.ToInt32(mission["numero"]);
                string matricule = mission["matriculeChef"].ToString();

                // Dépenses de la mission
                DataRow[] depenses = dtDepenses.Select(
                    $"nomPlanete = '{nomPlanete}' AND numeroMission = {numero}",
                    "montant DESC"
                );

                if (depenses.Length == 0) continue;

                // On prend la dépense la plus élevée
                DataRow depMax = depenses[0];
                string date = depMax["dateD"].ToString();
                string motif = depMax["motif"].ToString();
                int montant = Convert.ToInt32(depMax["montant"]);

                string depenseStr = $"{date} - {motif} -> {montant} €";

                // Nom du chef
                DataRow[] chefRows = dtMembres.Select($"matricule = '{matricule}'");
                string nomChef = chefRows.Length > 0
                    ? $"{chefRows[0]["prenom"]} {chefRows[0]["nom"]}"
                    : matricule;

                dtAffichage.Rows.Add(depenseStr, $"{nomPlanete}-{numero}", nomChef);
            }

            dgvDepensesMax.DataSource = dtAffichage;
            dgvDepensesMax.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDepensesMax.RowHeadersVisible = false;
            dgvDepensesMax.AllowUserToAddRows = false;
        }

        // ─── REQUÊTE 5 : INFORMATEURS ─────────────────────────────────────

        private void ChargerComboMissions()
        {
            cboMissions.Items.Clear();
            DataTable dtMissions = MesDatas.DsGlobal.Tables["Mission"];

            foreach (DataRow row in dtMissions.Rows)
            {
                string nomPlanete = row["nomPlanete"].ToString();
                int numero = Convert.ToInt32(row["numero"]);
                cboMissions.Items.Add($"{nomPlanete}-{numero}");
            }

            if (cboMissions.Items.Count > 0)
                cboMissions.SelectedIndex = 0;
        }

        private void cboMissions_SelectedIndexChanged(object sender, EventArgs e)
        {
            RequeteInformateurs();
        }

        private void RequeteInformateurs()
        {
            if (cboMissions.SelectedIndex < 0) return;

            string selected = cboMissions.SelectedItem.ToString();
            string nomPlanete = selected.Substring(0, selected.LastIndexOf('-'));
            int numero = Convert.ToInt32(selected.Substring(selected.LastIndexOf('-') + 1));

            DataSet ds = MesDatas.DsGlobal;
            DataTable dtContacts = ds.Tables["Contact"];
            DataTable dtInformateur = ds.Tables["Informateur"];
            DataTable dtEspece = ds.Tables["Espece"];
            DataTable dtEnnemi = ds.Tables["Ennemi"];

            // Contacts de la mission
            DataRow[] contacts = dtContacts.Select(
                $"nomPlanete = '{nomPlanete}' AND numeroMission = {numero}"
            );

            // Calcule la somme totale par informateur
            DataTable dtSommes = new DataTable();
            dtSommes.Columns.Add("nomCode");
            dtSommes.Columns.Add("somme", typeof(int));

            foreach (DataRow contact in contacts)
            {
                string nomCode = contact["nomCodeInformateur"].ToString();
                int somme = Convert.ToInt32(contact["sommeVersee"]);

                DataRow[] existant = dtSommes.Select($"nomCode = '{nomCode}'");
                if (existant.Length > 0)
                    existant[0]["somme"] = Convert.ToInt32(existant[0]["somme"]) + somme;
                else
                    dtSommes.Rows.Add(nomCode, somme);
            }

            if (dtSommes.Rows.Count == 0)
            {
                dgvInformateurs.DataSource = null;
                return;
            }

            // Trouve le minimum
            int minSomme = int.MaxValue;
            foreach (DataRow r in dtSommes.Rows)
            {
                int somme = Convert.ToInt32(r["somme"]);
                if (somme < minSomme) minSomme = somme;
            }

            DataTable dtAffichage = new DataTable();
            dtAffichage.Columns.Add("Nom de code");
            dtAffichage.Columns.Add("Espèce d'origine");
            dtAffichage.Columns.Add("Somme totale reçue (€)");

            foreach (DataRow r in dtSommes.Rows)
            {
                if (Convert.ToInt32(r["somme"]) != minSomme) continue;

                string nomCode = r["nomCode"].ToString();

                // Recherche l'informateur
                DataRow[] infoRows = dtInformateur.Select($"nomCode = '{nomCode}'");
                if (infoRows.Length == 0) continue;

                int idEspece = Convert.ToInt32(infoRows[0]["idEspeceEnnemi"]);

                // Recherche l'espèce
                DataRow[] especeRows = dtEspece.Select($"id = {idEspece}");
                string espece = especeRows.Length > 0 ? especeRows[0]["nom"].ToString() : "Inconnue";

                dtAffichage.Rows.Add(nomCode, espece, $"{minSomme} €");
            }

            dgvInformateurs.DataSource = dtAffichage;
            dgvInformateurs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInformateurs.RowHeadersVisible = false;
            dgvInformateurs.AllowUserToAddRows = false;
        }

        // ─── RETOUR ───────────────────────────────────────────────────────

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
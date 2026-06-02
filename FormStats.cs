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

        // Appelé automatiquement quand le formulaire s'ouvre
        private void FormStats_Load(object sender, EventArgs e)
        {
            ChargerDonnees();        // On remplit le DataSet avec les tables
            ChargerComboMembres();   // On remplit la liste déroulante des membres
            ChargerComboMissions();  // On remplit la liste déroulante des missions
            RequeteMissionsGrandes();// On affiche les missions > 10 personnes
            RequeteMissionsPlanete();// On affiche le nb de missions par planète
            RequeteDepensesMax();    // On affiche la dépense max de chaque mission
        }

        // ─── CHARGEMENT DES DONNÉES ───────────────────────────────────────
        // On charge toutes les tables dont on a besoin dans le DataSet global
        // Le DataSet c'est comme une base de données locale en mémoire
        private void ChargerDonnees()
        {
            DataSet ds = MesDatas.DsGlobal;

            // Liste des tables à charger
            string[] tables = { "Membre", "Civil", "Militaire", "Mission",
                                 "Composer", "Depense", "Planete", "Contact",
                                 "Informateur", "Espece", "Ennemi" };

            foreach (string nomTable in tables)
            {
                // Si la table est déjà chargée on ne la recharge pas
                if (ds.Tables.Contains(nomTable)) continue;

                try
                {
                    // On lit la table depuis la base SQLite et on la met dans le DataSet
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter($"SELECT * FROM {nomTable}", Connexion.Connec);
                    adapter.Fill(ds, nomTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur chargement {nomTable} : {ex.Message}");
                }
            }

            // On ferme la connexion : on travaille maintenant en mode déconnecté
            Connexion.FermerConnexion();
        }

        // ─── REQUÊTE 1 : MEMBRES COMMUNS ──────────────────────────────────
        // Remplit la liste déroulante avec tous les membres
        private void ChargerComboMembres()
        {
            cboMembres.Items.Clear();
            DataTable dtMembres = MesDatas.DsGlobal.Tables["Membre"];

            // Pour chaque membre on ajoute "Prénom Nom (matricule)" dans le ComboBox
            foreach (DataRow row in dtMembres.Rows)
            {
                string matricule = row["matricule"].ToString();
                string nom = row["nom"].ToString();
                string prenom = row["prenom"].ToString();
                cboMembres.Items.Add($"{prenom} {nom} ({matricule})");
            }

            // On sélectionne le premier par défaut
            if (cboMembres.Items.Count > 0)
                cboMembres.SelectedIndex = 0;
        }

        // Appelé quand on change de membre dans la liste déroulante
        private void cboMembres_SelectedIndexChanged(object sender, EventArgs e)
        {
            RequeteMembresCommuns();
        }

        // Affiche tous les membres qui ont fait une mission avec le membre sélectionné
        private void RequeteMembresCommuns()
        {
            if (cboMembres.SelectedIndex < 0) return;

            // On extrait la matricule depuis le texte du ComboBox ex: "Jean Dupont (MAT-001)"
            string selected = cboMembres.SelectedItem.ToString();
            string matricule = selected.Substring(
                selected.LastIndexOf('(') + 1,
                selected.LastIndexOf(')') - selected.LastIndexOf('(') - 1
            );

            // On récupère les tables dont on a besoin
            DataTable dtComposer = MesDatas.DsGlobal.Tables["Composer"];
            DataTable dtMembres = MesDatas.DsGlobal.Tables["Membre"];
            DataTable dtCivil = MesDatas.DsGlobal.Tables["Civil"];
            DataTable dtMilitaire = MesDatas.DsGlobal.Tables["Militaire"];

            // On crée une table vide pour afficher les résultats
            DataTable dtAffichage = new DataTable();
            dtAffichage.Columns.Add("Nom");
            dtAffichage.Columns.Add("Prénom");
            dtAffichage.Columns.Add("Type");    // Civil ou Militaire
            dtAffichage.Columns.Add("Mission"); // Nom de la mission en commun

            // On cherche toutes les missions du membre sélectionné dans Composer
            DataRow[] missionsDuMembre = dtComposer.Select($"matriculeMembre = '{matricule}'");

            foreach (DataRow missionRow in missionsDuMembre)
            {
                string nomPlanete = missionRow["nomPlanete"].ToString();
                int numeroMission = Convert.ToInt32(missionRow["numeroMission"]);

                // Pour chaque mission, on cherche les AUTRES membres qui y ont participé
                DataRow[] autresMembres = dtComposer.Select(
                    $"nomPlanete = '{nomPlanete}' AND numeroMission = {numeroMission} AND matriculeMembre != '{matricule}'"
                );

                foreach (DataRow autreMembre in autresMembres)
                {
                    string autreMatricule = autreMembre["matriculeMembre"].ToString();

                    // On récupère le nom et prénom de ce membre
                    DataRow[] membreRows = dtMembres.Select($"matricule = '{autreMatricule}'");
                    if (membreRows.Length == 0) continue;

                    string nom = membreRows[0]["nom"].ToString();
                    string prenom = membreRows[0]["prenom"].ToString();

                    // On détermine si c'est un Civil ou un Militaire
                    string type = "Inconnu";
                    if (dtCivil.Select($"matriculeMembre = '{autreMatricule}'").Length > 0)
                        type = "Civil";
                    else if (dtMilitaire.Select($"matriculeMembre = '{autreMatricule}'").Length > 0)
                        type = "Militaire";

                    // On vérifie que ce membre n'est pas déjà dans les résultats
                    bool dejaPresent = false;
                    foreach (DataRow r in dtAffichage.Rows)
                    {
                        if (r["Nom"].ToString() == nom && r["Prénom"].ToString() == prenom)
                        {
                            dejaPresent = true;
                            break;
                        }
                    }

                    // Si pas encore présent on l'ajoute
                    if (!dejaPresent)
                        dtAffichage.Rows.Add(nom, prenom, type, $"{nomPlanete}-{numeroMission}");
                }
            }

            // On affiche les résultats dans le DataGridView
            dgvMembresCommuns.DataSource = dtAffichage;
            dgvMembresCommuns.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMembresCommuns.RowHeadersVisible = false;
            dgvMembresCommuns.AllowUserToAddRows = false;
        }

        // ─── REQUÊTE 2 : MISSIONS > 10 PERSONNES ──────────────────────────
        // Affiche les missions avec plus de 10 membres + leurs budgets et dépenses
        private void RequeteMissionsGrandes()
        {
            DataTable dtMissions = MesDatas.DsGlobal.Tables["Mission"];
            DataTable dtDepenses = MesDatas.DsGlobal.Tables["Depense"];
            DataTable dtComposer = MesDatas.DsGlobal.Tables["Composer"];

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

                // On compte le nombre de membres dans cette mission
                DataRow[] membres = dtComposer.Select(
                    $"nomPlanete = '{nomPlanete}' AND numeroMission = {numero}"
                );

                // Si 10 membres ou moins on passe à la mission suivante
                if (membres.Length <= 10) continue;

                // On calcule le total des dépenses de la mission
                DataRow[] depenses = dtDepenses.Select($"nomPlanete = '{nomPlanete}' AND numeroMission = {numero}");
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
        // Pour chaque planète, affiche le nombre de missions effectuées
        // Les planètes sans mission apparaissent quand même avec 0
        private void RequeteMissionsPlanete()
        {
            DataTable dtPlanetes = MesDatas.DsGlobal.Tables["Planete"];
            DataTable dtMissions = MesDatas.DsGlobal.Tables["Mission"];

            DataTable dtAffichage = new DataTable();
            dtAffichage.Columns.Add("Planète");
            dtAffichage.Columns.Add("Nombre de missions");

            foreach (DataRow planete in dtPlanetes.Rows)
            {
                string nom = planete["nom"].ToString();

                // On cherche toutes les missions qui vont sur cette planète
                DataRow[] missions = dtMissions.Select($"nomPlanete = '{nom}'");

                // missions.Length = 0 si aucune mission sur cette planète
                dtAffichage.Rows.Add(nom, missions.Length);
            }

            dgvMissionsPlanete.DataSource = dtAffichage;
            dgvMissionsPlanete.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMissionsPlanete.RowHeadersVisible = false;
            dgvMissionsPlanete.AllowUserToAddRows = false;
        }

        // ─── REQUÊTE 4 : DÉPENSES MAX PAR MISSION ─────────────────────────
        // Pour chaque mission, affiche la dépense la plus élevée + le chef
        private void RequeteDepensesMax()
        {
            DataTable dtMissions = MesDatas.DsGlobal.Tables["Mission"];
            DataTable dtDepenses = MesDatas.DsGlobal.Tables["Depense"];
            DataTable dtMembres = MesDatas.DsGlobal.Tables["Membre"];

            DataTable dtAffichage = new DataTable();
            dtAffichage.Columns.Add("Dépenses les plus importantes");
            dtAffichage.Columns.Add("Mission");
            dtAffichage.Columns.Add("Chef de mission");

            foreach (DataRow mission in dtMissions.Rows)
            {
                string nomPlanete = mission["nomPlanete"].ToString();
                int numero = Convert.ToInt32(mission["numero"]);
                string matricule = mission["matriculeChef"].ToString();

                // On récupère les dépenses triées du plus grand au plus petit
                DataRow[] depenses = dtDepenses.Select(
                    $"nomPlanete = '{nomPlanete}' AND numeroMission = {numero}",
                    "montant DESC" // tri décroissant → la première = la plus grande
                );

                // Si pas de dépenses on passe à la mission suivante
                if (depenses.Length == 0) continue;

                // On prend la première ligne = la dépense la plus élevée
                DataRow depMax = depenses[0];
                string date = depMax["dateD"].ToString();
                string motif = depMax["motif"].ToString();
                int montant = Convert.ToInt32(depMax["montant"]);

                // On cherche le nom complet du chef de mission
                DataRow[] chefRows = dtMembres.Select($"matricule = '{matricule}'");
                string nomChef = chefRows.Length > 0
                    ? $"{chefRows[0]["prenom"]} {chefRows[0]["nom"]}"
                    : matricule;

                dtAffichage.Rows.Add(
                    $"{date} - {motif} -> {montant} €",
                    $"{nomPlanete}-{numero}",
                    nomChef
                );
            }

            dgvDepensesMax.DataSource = dtAffichage;
            dgvDepensesMax.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDepensesMax.RowHeadersVisible = false;
            dgvDepensesMax.AllowUserToAddRows = false;
        }

        // ─── REQUÊTE 5 : INFORMATEURS ─────────────────────────────────────
        // Remplit la liste déroulante avec toutes les missions
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

        // Appelé quand on change de mission dans la liste déroulante
        private void cboMissions_SelectedIndexChanged(object sender, EventArgs e)
        {
            RequeteInformateurs();
        }

        // Affiche les informateurs qui ont reçu le moins d'argent pour la mission choisie
        private void RequeteInformateurs()
        {
            if (cboMissions.SelectedIndex < 0) return;

            // On extrait le nom de la planète et le numéro depuis "Kobaia-1"
            string selected = cboMissions.SelectedItem.ToString();
            string nomPlanete = selected.Substring(0, selected.LastIndexOf('-'));
            int numero = Convert.ToInt32(selected.Substring(selected.LastIndexOf('-') + 1));

            DataTable dtContacts = MesDatas.DsGlobal.Tables["Contact"];
            DataTable dtInformateur = MesDatas.DsGlobal.Tables["Informateur"];
            DataTable dtEspece = MesDatas.DsGlobal.Tables["Espece"];

            // On récupère tous les contacts de cette mission
            DataRow[] contacts = dtContacts.Select(
                $"nomPlanete = '{nomPlanete}' AND numeroMission = {numero}"
            );

            // On crée une table pour calculer la somme totale par informateur
            DataTable dtSommes = new DataTable();
            dtSommes.Columns.Add("nomCode");
            dtSommes.Columns.Add("somme", typeof(int));

            foreach (DataRow contact in contacts)
            {
                string nomCode = contact["nomCodeInformateur"].ToString();
                int somme = Convert.ToInt32(contact["sommeVersee"]);

                // Si l'informateur est déjà dans la table on ajoute à sa somme
                DataRow[] existant = dtSommes.Select($"nomCode = '{nomCode}'");
                if (existant.Length > 0)
                    existant[0]["somme"] = Convert.ToInt32(existant[0]["somme"]) + somme;
                else
                    dtSommes.Rows.Add(nomCode, somme); // Sinon on l'ajoute
            }

            // Si aucun contact trouvé on vide le tableau
            if (dtSommes.Rows.Count == 0)
            {
                dgvInformateurs.DataSource = null;
                return;
            }

            // On cherche la somme minimale parmi tous les informateurs
            int minSomme = int.MaxValue; // On part d'un très grand nombre
            foreach (DataRow r in dtSommes.Rows)
            {
                int somme = Convert.ToInt32(r["somme"]);
                if (somme < minSomme)
                    minSomme = somme; // On garde le plus petit
            }

            // On affiche uniquement les informateurs qui ont reçu cette somme minimum
            DataTable dtAffichage = new DataTable();
            dtAffichage.Columns.Add("Nom de code");
            dtAffichage.Columns.Add("Espèce d'origine");
            dtAffichage.Columns.Add("Somme totale reçue (€)");

            foreach (DataRow r in dtSommes.Rows)
            {
                // On ignore les informateurs qui ont reçu plus que le minimum
                if (Convert.ToInt32(r["somme"]) != minSomme) continue;

                string nomCode = r["nomCode"].ToString();

                // On cherche l'espèce de l'informateur
                DataRow[] infoRows = dtInformateur.Select($"nomCode = '{nomCode}'");
                if (infoRows.Length == 0) continue;

                int idEspece = Convert.ToInt32(infoRows[0]["idEspeceEnnemi"]);
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
            this.Close(); // Ferme le formulaire et retourne au menu principal
        }
    }
}
using appliPandora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        // ─── MÉTHODE UTILITAIRE ───────────────────────────────────────────
        // Écrit une ligne dans un RichTextBox avec une couleur spécifique
        private void EcrireLigne(RichTextBox rtb, string texte, Color couleur)
        {
            rtb.SelectionStart = rtb.TextLength;
            rtb.SelectionLength = 0;
            rtb.SelectionColor = couleur;
            rtb.AppendText(texte + "\n");
            rtb.SelectionColor = rtb.ForeColor;
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

            rtbMembresCommuns.Clear();

            // Récupère la matricule depuis le texte du ComboBox
            string selected = cboMembres.SelectedItem.ToString();
            string matricule = selected.Substring(
                selected.LastIndexOf('(') + 1,
                selected.LastIndexOf(')') - selected.LastIndexOf('(') - 1
            );

            DataTable dtComposer = MesDatas.DsGlobal.Tables["Composer"];
            DataTable dtMembres = MesDatas.DsGlobal.Tables["Membre"];
            DataTable dtCivil = MesDatas.DsGlobal.Tables["Civil"];
            DataTable dtMilitaire = MesDatas.DsGlobal.Tables["Militaire"];

            // Missions du membre sélectionné
            DataRow[] missionsDuMembre = dtComposer.Select($"matriculeMembre = '{matricule}'");

            // Titre
            EcrireLigne(rtbMembresCommuns, "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", Color.Gray);
            EcrireLigne(rtbMembresCommuns, $"  Membres ayant participé aux mêmes missions", Color.Yellow);
            EcrireLigne(rtbMembresCommuns, "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", Color.Gray);
            EcrireLigne(rtbMembresCommuns, "", Color.White);

            // Liste pour éviter les doublons
            DataTable dtDejaAffiche = new DataTable();
            dtDejaAffiche.Columns.Add("nom");
            dtDejaAffiche.Columns.Add("prenom");

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

                    // Vérifie les doublons
                    if (dtDejaAffiche.Select($"nom = '{nom}' AND prenom = '{prenom}'").Length > 0)
                        continue;

                    dtDejaAffiche.Rows.Add(nom, prenom);

                    // Type civil ou militaire
                    string type = "Inconnu";
                    if (dtCivil.Select($"matriculeMembre = '{autreMatricule}'").Length > 0)
                        type = "Civil";
                    else if (dtMilitaire.Select($"matriculeMembre = '{autreMatricule}'").Length > 0)
                        type = "Militaire";

                    // Couleur selon le type
                    Color couleurType = type == "Militaire" ? Color.LightBlue : Color.LightGreen;

                    EcrireLigne(rtbMembresCommuns, $"  {prenom} {nom}", Color.White);
                    EcrireLigne(rtbMembresCommuns, $"  Type    : {type}", couleurType);
                    EcrireLigne(rtbMembresCommuns, $"  Mission : {nomPlanete}-{numeroMission}", Color.Orange);
                    EcrireLigne(rtbMembresCommuns, "", Color.White);
                }
            }

            if (rtbMembresCommuns.Text.Trim() == "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━\n  Membres ayant participé aux mêmes missions\n━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━")
                EcrireLigne(rtbMembresCommuns, "  Aucun membre trouvé.", Color.Gray);
        }

        // ─── REQUÊTE 2 : MISSIONS > 10 PERSONNES ──────────────────────────
        private void RequeteMissionsGrandes()
        {
            rtbMissionsGrandes.Clear();

            DataTable dtMissions = MesDatas.DsGlobal.Tables["Mission"];
            DataTable dtDepenses = MesDatas.DsGlobal.Tables["Depense"];
            DataTable dtComposer = MesDatas.DsGlobal.Tables["Composer"];

            // Titre
            EcrireLigne(rtbMissionsGrandes, "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", Color.Gray);
            EcrireLigne(rtbMissionsGrandes, "  Missions avec plus de 10 membres", Color.Yellow);
            EcrireLigne(rtbMissionsGrandes, "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", Color.Gray);
            EcrireLigne(rtbMissionsGrandes, "", Color.White);

            bool auMoinsUne = false;

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

                auMoinsUne = true;

                // Calcule les dépenses
                DataRow[] depenses = dtDepenses.Select($"nomPlanete = '{nomPlanete}' AND numeroMission = {numero}");
                int totalDepenses = 0;
                foreach (DataRow dep in depenses)
                    totalDepenses += Convert.ToInt32(dep["montant"]);

                int restant = budget - totalDepenses;

                // Couleur du restant : vert si positif, rouge si négatif
                Color couleurRestant = restant >= 0 ? Color.LightGreen : Color.Red;

                EcrireLigne(rtbMissionsGrandes, $"  Mission {nomPlanete}-{numero}", Color.White);
                EcrireLigne(rtbMissionsGrandes, $"  Membres        : {membres.Length}", Color.LightBlue);
                EcrireLigne(rtbMissionsGrandes, $"  Budget initial : {budget} €", Color.White);
                EcrireLigne(rtbMissionsGrandes, $"  Total dépenses : {totalDepenses} €", Color.Orange);
                EcrireLigne(rtbMissionsGrandes, $"  Budget restant : {restant} €", couleurRestant);
                EcrireLigne(rtbMissionsGrandes, "", Color.White);
            }

            if (!auMoinsUne)
                EcrireLigne(rtbMissionsGrandes, "  Aucune mission avec plus de 10 membres.", Color.Gray);
        }

        // ─── REQUÊTE 3 : MISSIONS PAR PLANÈTE ─────────────────────────────
        private void RequeteMissionsPlanete()
        {
            rtbMissionsPlanete.Clear();

            DataTable dtPlanetes = MesDatas.DsGlobal.Tables["Planete"];
            DataTable dtMissions = MesDatas.DsGlobal.Tables["Mission"];

            // Titre
            EcrireLigne(rtbMissionsPlanete, "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", Color.Gray);
            EcrireLigne(rtbMissionsPlanete, "  Nombre de missions par planète", Color.Yellow);
            EcrireLigne(rtbMissionsPlanete, "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", Color.Gray);
            EcrireLigne(rtbMissionsPlanete, "", Color.White);

            foreach (DataRow planete in dtPlanetes.Rows)
            {
                string nom = planete["nom"].ToString();

                DataRow[] missions = dtMissions.Select($"nomPlanete = '{nom}'");

                // Couleur selon qu'il y a des missions ou non
                Color couleur = missions.Length > 0 ? Color.LightGreen : Color.Gray;

                EcrireLigne(rtbMissionsPlanete,
                    $"  {nom,-20} → {missions.Length} mission(s)",
                    couleur
                );
            }
        }

        // ─── REQUÊTE 4 : DÉPENSES MAX PAR MISSION ─────────────────────────
        private void RequeteDepensesMax()
        {
            rtbDepensesMax.Clear();

            DataTable dtMissions = MesDatas.DsGlobal.Tables["Mission"];
            DataTable dtDepenses = MesDatas.DsGlobal.Tables["Depense"];
            DataTable dtMembres = MesDatas.DsGlobal.Tables["Membre"];

            // Titre
            EcrireLigne(rtbDepensesMax, "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", Color.Gray);
            EcrireLigne(rtbDepensesMax, "  Dépense la plus élevée par mission", Color.Yellow);
            EcrireLigne(rtbDepensesMax, "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", Color.Gray);
            EcrireLigne(rtbDepensesMax, "", Color.White);

            foreach (DataRow mission in dtMissions.Rows)
            {
                string nomPlanete = mission["nomPlanete"].ToString();
                int numero = Convert.ToInt32(mission["numero"]);
                string matricule = mission["matriculeChef"].ToString();

                // Dépenses triées du plus grand au plus petit
                DataRow[] depenses = dtDepenses.Select(
                    $"nomPlanete = '{nomPlanete}' AND numeroMission = {numero}",
                    "montant DESC"
                );

                if (depenses.Length == 0) continue;

                // La première ligne = la plus grande dépense
                DataRow depMax = depenses[0];
                string date = depMax["dateD"].ToString();
                string motif = depMax["motif"].ToString();
                int montant = Convert.ToInt32(depMax["montant"]);

                // Nom du chef
                DataRow[] chefRows = dtMembres.Select($"matricule = '{matricule}'");
                string nomChef = chefRows.Length > 0
                    ? $"{chefRows[0]["prenom"]} {chefRows[0]["nom"]}"
                    : matricule;

                EcrireLigne(rtbDepensesMax, $"  Mission {nomPlanete}-{numero}", Color.White);
                EcrireLigne(rtbDepensesMax, $"  Chef    : {nomChef}", Color.LightBlue);
                EcrireLigne(rtbDepensesMax, $"  Date    : {date}", Color.Gray);
                EcrireLigne(rtbDepensesMax, $"  Motif   : {motif}", Color.White);
                EcrireLigne(rtbDepensesMax, $"  Montant : {montant} €", Color.Orange);
                EcrireLigne(rtbDepensesMax, "", Color.White);
            }
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

            rtbInformateurs.Clear();

            string selected = cboMissions.SelectedItem.ToString();
            string nomPlanete = selected.Substring(0, selected.LastIndexOf('-'));
            int numero = Convert.ToInt32(selected.Substring(selected.LastIndexOf('-') + 1));

            DataTable dtContacts = MesDatas.DsGlobal.Tables["Contact"];
            DataTable dtInformateur = MesDatas.DsGlobal.Tables["Informateur"];
            DataTable dtEspece = MesDatas.DsGlobal.Tables["Espece"];

            DataRow[] contacts = dtContacts.Select(
                $"nomPlanete = '{nomPlanete}' AND numeroMission = {numero}"
            );

            // Titre
            EcrireLigne(rtbInformateurs, "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", Color.Gray);
            EcrireLigne(rtbInformateurs, $"  Informateurs les moins payés — Mission {nomPlanete}-{numero}", Color.Yellow);
            EcrireLigne(rtbInformateurs, "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", Color.Gray);
            EcrireLigne(rtbInformateurs, "", Color.White);

            if (contacts.Length == 0)
            {
                EcrireLigne(rtbInformateurs, "  Aucun contact pour cette mission.", Color.Gray);
                return;
            }

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

            // Trouve le minimum
            int minSomme = int.MaxValue;
            foreach (DataRow r in dtSommes.Rows)
            {
                int somme = Convert.ToInt32(r["somme"]);
                if (somme < minSomme) minSomme = somme;
            }

            // Affiche les informateurs avec la somme minimum
            foreach (DataRow r in dtSommes.Rows)
            {
                if (Convert.ToInt32(r["somme"]) != minSomme) continue;

                string nomCode = r["nomCode"].ToString();

                DataRow[] infoRows = dtInformateur.Select($"nomCode = '{nomCode}'");
                if (infoRows.Length == 0) continue;

                int idEspece = Convert.ToInt32(infoRows[0]["idEspeceEnnemi"]);
                DataRow[] especeRows = dtEspece.Select($"id = {idEspece}");
                string espece = especeRows.Length > 0 ? especeRows[0]["nom"].ToString() : "Inconnue";

                EcrireLigne(rtbInformateurs, $"  Nom de code : {nomCode}", Color.White);
                EcrireLigne(rtbInformateurs, $"  Espèce      : {espece}", Color.LightBlue);
                EcrireLigne(rtbInformateurs, $"  Somme reçue : {minSomme} €", Color.Orange);
                EcrireLigne(rtbInformateurs, "", Color.White);
            }
        }

        // ─── RETOUR ───────────────────────────────────────────────────────
        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

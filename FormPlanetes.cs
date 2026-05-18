using System;
using appliPandora;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appStargate
{
    public partial class FormPlanetes : Form
    {
        public FormPlanetes()
        {
            InitializeComponent();
            this.Load += FormPlanetes_Load;
            // Force l'ordre de dock : pnlDetail doit être avant flpPlanetes
            flpPlanetes.SendToBack();
        }


        private void flpPlanetes_Paint(object sender, PaintEventArgs e)
        {

        }
        private void FormPlanetes_Load(object sender, EventArgs e)
        {
            ChargerDonnees();
            AfficherCartesPlanetes();

        }

        /// <summary>
        /// Charge les tables nécessaires dans le DataSet global (mode déconnecté)
        /// </summary>
        private void ChargerDonnees()
        {
            DataSet ds = MesDatas.DsGlobal;
            string[] tables = { "Planete", "Espece", "Allie", "Ennemi", "Habiter", "Mission", "Membre" };

            foreach (string nomTable in tables)
            {
                // On ne recharge pas si déjà présente
                if (ds.Tables.Contains(nomTable)) continue;

                try
                {
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter($"SELECT * FROM {nomTable}", Connexion.Connec);
                    adapter.Fill(ds, nomTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur chargement {nomTable} : {ex.Message}");
                }
            }

            // Mode déconnecté : on ferme la connexion
            Connexion.FermerConnexion();
        }

        /// <summary>
        /// Crée et affiche un UC par planète dans le FlowLayoutPanel
        /// </summary>
        private void AfficherCartesPlanetes()
        {
            flpPlanetes.Controls.Clear();

            DataTable dtPlanetes = MesDatas.DsGlobal.Tables["Planete"];
            if (dtPlanetes == null)
            {
                MessageBox.Show("La table Planete n'a pas été chargée !");
                return;
            }

            foreach (DataRow row in dtPlanetes.Rows)
            {

                this.Refresh();
                string nom = row["nom"].ToString();
                int temperature = row["temperature"] == DBNull.Value ? 0 : Convert.ToInt32(row["temperature"]);
                double gravite = row["gravite"] == DBNull.Value ? 0.0 : Convert.ToDouble(row["gravite"]);
                bool databazON = row["dataBazON"] != DBNull.Value && Convert.ToInt32(row["dataBazON"]) == 1;

                // Chemin vers l'image dans le dossier img
                string cheminImage = Path.Combine(
                    Application.StartupPath, "images", nom + ".jpg"
                );

                // Création du User Control
                UCPlanete uc = new UCPlanete(nom, temperature, gravite, databazON, cheminImage);

                // On branche le délégué
                uc.afficheurDetail = AfficherDetail;

                // Taille et style de la carte
                uc.Width = 160;
                uc.Height = 240;
                uc.Margin = new Padding(10);
                uc.BorderStyle = BorderStyle.FixedSingle;

                flpPlanetes.Controls.Add(uc);
            }
        }

        /// <summary>
        /// Méthode déléguée : appelée quand on clique sur un UC planète
        /// </summary>
        private void AfficherDetail(object sender, EventArgs e)
        {

            UCPlanete uc = sender as UCPlanete;
            if (uc == null)
            {
                MessageBox.Show("uc est null !");
                return;
            }

            string nomPlanete = uc.NomPlanete;

            lblTitrePlanete.Text = nomPlanete;
            AfficherRacesPlanete(nomPlanete);
            AfficherMissionsPlanete(nomPlanete);
        }

        /// <summary>
        /// Affiche les races présentes sur la planète dans le DataGridView
        /// Tout depuis le DataSet — aucun accès base de données
        /// </summary>
        private void AfficherRacesPlanete(string nomPlanete)
        {
            DataSet ds = MesDatas.DsGlobal;
            DataTable dtHabiter = ds.Tables["Habiter"];
            DataTable dtEspece = ds.Tables["Espece"];
            DataTable dtAllie = ds.Tables["Allie"];
            DataTable dtEnnemi = ds.Tables["Ennemi"];

            // Table temporaire pour l'affichage
            DataTable dtAffichage = new DataTable();
            dtAffichage.Columns.Add("Espèce");
            dtAffichage.Columns.Add("Couleur");
            dtAffichage.Columns.Add("Type");
            dtAffichage.Columns.Add("Présence (%)");

            DataRow[] habitantsRows = dtHabiter.Select($"nomPlanete = '{nomPlanete}'");

            foreach (DataRow habRow in habitantsRows)
            {
                int idEspece = Convert.ToInt32(habRow["idEspece"]);
                int pourcentage = Convert.ToInt32(habRow["pourcentage"]);

                DataRow[] especeRows = dtEspece.Select($"id = {idEspece}");
                if (especeRows.Length == 0) continue;

                string nomEspece = especeRows[0]["nom"].ToString();
                string couleur = especeRows[0]["couleur"].ToString();

                string type = "Inconnu";
                if (dtAllie.Select($"idEspece = {idEspece}").Length > 0)
                    type = "Allié";
                else if (dtEnnemi.Select($"idEspece = {idEspece}").Length > 0)
                    type = "Ennemi";

                dtAffichage.Rows.Add(nomEspece, couleur, type, $"{pourcentage} %");
            }

            dgvRaces.DataSource = dtAffichage;
            dgvRaces.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRaces.RowHeadersVisible = false;
            dgvRaces.AllowUserToAddRows = false;
        }

        /// <summary>
        /// Affiche les missions effectuées sur la planète dans la ListBox
        /// Tout depuis le DataSet — aucun accès base de données
        /// </summary>
        private void AfficherMissionsPlanete(string nomPlanete)
        {
            lbMissions.Items.Clear();

            DataTable dtMissions = MesDatas.DsGlobal.Tables["Mission"];
            DataTable dtMembres = MesDatas.DsGlobal.Tables["Membre"];

            DataRow[] missionRows = dtMissions.Select($"nomPlanete = '{nomPlanete}'");

            if (missionRows.Length == 0)
            {
                lbMissions.Items.Add("Aucune mission sur cette planète.");
                return;
            }

            foreach (DataRow mission in missionRows)
            {
                int numero = Convert.ToInt32(mission["numero"]);
                string depart = mission["dateDepart"].ToString();
                string retour = mission["dateRetour"].ToString();
                string matricule = mission["matriculeChef"].ToString();
                int budget = Convert.ToInt32(mission["budget"]);

                // Recherche du nom du chef
                DataRow[] chefRows = dtMembres.Select($"matricule = '{matricule}'");
                string nomChef = chefRows.Length > 0
                    ? $"{chefRows[0]["prenom"]} {chefRows[0]["nom"]}"
                    : matricule;

                lbMissions.Items.Add(
                    $"Mission {nomPlanete}-{numero} | {depart} → {retour} | Chef : {nomChef} | Budget : {budget}€"
                );
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

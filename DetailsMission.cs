using appliPandora;
using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace appStargate
{
    public partial class DetailsMission : Form
    {
        private DataRow maMission;

        public DetailsMission(DataRow ligneRecue, string nomChefComplet)
        {
            InitializeComponent();
            maMission = ligneRecue;

            // REMPLISSAGE INFOS
            Text = "Détails : " + maMission["nomPlanete"] + " " + maMission["numero"];
            lblTitreMission.Text = "Mission | " + maMission["nomPlanete"] + " " + maMission["numero"];
            lblChefMission.Text = "Chef : " + nomChefComplet;
            lblObjDatabaz.Text = "Objectif de Databaz : " + maMission["objectifDatabaz"];
            lblFeuilleDeRoute.Text = maMission["feuilleDeRoute"].ToString();

            // DATES
            DateTime dateDepart = Convert.ToDateTime(maMission["dateDepart"]);
            lblDateDebutMission.Text = "Départ : " + dateDepart.ToString("d", new CultureInfo("fr-FR"));

            DateTime dateRetour = Convert.ToDateTime(maMission["dateRetour"]);
            lblDateFinMission.Text = "Retour : " + dateRetour.ToString("d", new CultureInfo("fr-FR"));

            // CALCUL DU SOLDE (MODE DÉCONNECTÉ)
            double budget = Convert.ToDouble(maMission["budget"]);
            double totalDepenses = 0;

            string planete = maMission["nomPlanete"].ToString();
            string num = maMission["numero"].ToString();

            // Requête SQL simple
            string sql = "SELECT montant FROM depense WHERE nomPlanete = '" + planete + "' AND numeroMission = " + num;

            // Table mémoire
            DataTable tableDepenses = new DataTable();

            // DataAdapter (mode déconnecté)
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, Connexion.Connec);

            // Remplit le DataTable
            adapter.Fill(tableDepenses);

            // Calcul des dépenses en mémoire
            foreach (DataRow ligne in tableDepenses.Rows)
            {
                totalDepenses += Convert.ToDouble(ligne["montant"]);
            }

            // Calcul du solde
            double solde = budget - totalDepenses;
            double ratio = (solde / budget) * 100;

            // AFFICHAGE BUDGET
            lblBudget.Text = "Budget : " + budget + " €";
            lblSolde.Text = "Solde restant : " + solde + " € (" + Math.Round(ratio, 2) + "%)";

            // COULEURS
            if (ratio > 75)
            {
                lblSolde.ForeColor = Color.LimeGreen;
            }
            else if (ratio > 45)
            {
                lblSolde.ForeColor = Color.Orange;
            }
            else
            {
                lblSolde.ForeColor = Color.Red;
            }
        }

        private void btnVoirMembresOuFeuille_Click(object sender, EventArgs e)
        {
            if (btnVoirMembresOuFeuille.Text == "Voir Membres")
            {
                btnVoirMembresOuFeuille.Text = "Voir Feuille";
                lblFeuilleDeRoute.Visible = false;
                diverseInfosPanel.Visible = false;
            }
            else
            {
                btnVoirMembresOuFeuille.Text = "Voir Membres";
                lblFeuilleDeRoute.Visible = true;
                diverseInfosPanel.Visible = true;
            }
        }

        private void DetailsMission_Load(object sender, EventArgs e)
        {
        }

        private void lblTitreMission_Click(object sender, EventArgs e)
        {
        }

        private void lblObjDatabaz_Click(object sender, EventArgs e)
        {
        }

        private void lblSolde_Click(object sender, EventArgs e)
        {
        }
    }
}
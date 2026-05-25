using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appStargate
{
    public partial class DetailsMission : Form
    {
        private DataRow maMission; 
        public DetailsMission(DataRow ligneRecue)
        {
            InitializeComponent();

            this.maMission = ligneRecue;

            this.Text = "Détails de la mission : " + maMission["nomPlanete"].ToString() +" "+ maMission["numero"];

            lblTitreMission.Text = "Mission | " +maMission["nomPlanete"].ToString() + " " + maMission["numero"];
            lblBudget.Text = "Budget : " + maMission["budget"];
            lblChefMission.Text = "Chef : ";
            DateTime dateDepart = Convert.ToDateTime(maMission["dateDepart"]);
            lblDateDebutMission.Text = $"Départ : {dateDepart.ToString("d", new CultureInfo("fr-FR"))}";
            DateTime dateRetour = Convert.ToDateTime(maMission["dateRetour"]);
            lblDateFinMission.Text = $"Retour : {dateRetour.ToString("d", new CultureInfo("fr-FR"))}";
        }

        private void DetailsMission_Load(object sender, EventArgs e)
        {

        }

        private void lblTitreMission_Click(object sender, EventArgs e)
        {

        }
    }
}

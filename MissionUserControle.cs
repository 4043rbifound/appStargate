using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appStargate
{
    public partial class MissionUserControle : UserControl
    {
        public MissionUserControle()
        {
            InitializeComponent();
        }

        public void ChargerDonnees(DataRow ligne, string nomChefComplet)
        {
            lblTitreMission.Text = "Mission | " + ligne["nomPlanete"].ToString() +" "+ ligne["numero"];
            lblDateDebutMission.Text = "Départ : " + ligne["dateDepart"].ToString();
            lblDateFinMission.Text = "Retour : " + ligne["dateRetour"].ToString();
            lblBudget.Text = "Budget : " + ligne["budget"].ToString() + " €";

            lblChefMission.Text = "Chef : " + nomChefComplet;
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ImageMission_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblDateDebutMission_Click(object sender, EventArgs e)
        {

        }

        private void lblTitreMission_Click(object sender, EventArgs e)
        {

        }

        private void ImageLoupe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Message");
        }
    }
}

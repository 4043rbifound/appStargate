using appliPandora;
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
    public partial class MissionUserControle : UserControl
    {
        public MissionUserControle()
        {
            InitializeComponent();
        }

        public void ChargerDonnees(DataRow ligne, string nomChefComplet)
        {
            lblTitreMission.Text = "Mission | " + ligne["nomPlanete"].ToString() + " " + ligne["numero"];
            lblBudget.Text = "Budget : " + ligne["budget"].ToString() + " €";

            lblChefMission.Text = "Chef : " + nomChefComplet;

            pictureBox4.Tag = ligne;
            DateTime dateDepart = Convert.ToDateTime(ligne["dateDepart"]);
            lblDateDebutMission.Text = $"Départ : {dateDepart.ToString("d", new CultureInfo("fr-FR"))}";
            DateTime dateRetour = Convert.ToDateTime(ligne["dateRetour"]);
            lblDateFinMission.Text = $"Départ : {dateRetour.ToString("d", new CultureInfo("fr-FR"))}";
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DataRow ligneSelectionnee = (DataRow)pictureBox4.Tag; //le cast sert à faire comprendre que le tag est une ligne de la db

            DetailsMission detMis = new DetailsMission(ligneSelectionnee);
            detMis.ShowDialog();
        }
    }
}
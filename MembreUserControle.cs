using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace appStargate
{
    public partial class MembreUserControle : UserControl
    {
        public MembreUserControle()
        {
            InitializeComponent();
        }

        public void ChargerDonnees(string matricule, string nom, string prenom)
        {
            lblNomPrenom.Text = nom.ToUpper();
            lblPrenom.Text = prenom;

            string sqlMilitaire = "SELECT matriculeMembre FROM Militaire WHERE matriculeMembre = '" + matricule + "'";
            SQLiteCommand cmdMil = new SQLiteCommand(sqlMilitaire, appliPandora.Connexion.Connec);
            object result = cmdMil.ExecuteScalar();

            if (result != null)
            {
                this.BackColor = Color.FromArgb(34, 68, 34);
                pictureBox1.Visible = false;
                pictureBoxMembre.Visible = true;
            }
            else
            {
                this.BackColor = Color.FromArgb(131, 219, 242);
                pictureBox1.Visible = true;
                pictureBoxMembre.Visible = false;
            }
        }

        private void MembreUserControle_Load(object sender, EventArgs e)
        {

        }
    }
}
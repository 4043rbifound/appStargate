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
        private DataTable tableMembres = new DataTable();
        private Point _pointDepart;
        public DetailsMission(DataRow ligneRecue, string nomChefComplet)
        {
            InitializeComponent();
            maMission = ligneRecue;
            btnVoirMembresOuFeuille.Tag = "ROUGE";
            btnVoirFeuille.Tag = "GRIS";

            Text = "Détails : " + maMission["nomPlanete"] + " " + maMission["numero"];
            lblTitreMission.Text = "Mission | " + maMission["nomPlanete"] + " " + maMission["numero"];
            lblChefMission.Text = "Chef : " + nomChefComplet;
            lblObjDatabaz.Text = "Objectif de Databaz : " + maMission["objectifDatabaz"] + "kg";
            lblFeuilleDeRoute.Text = maMission["feuilleDeRoute"].ToString();
            grpImagePlanete.Text = "La Planète " + maMission["nomPlanete"];

            DateTime dateDepart = Convert.ToDateTime(maMission["dateDepart"]);
            lblDateDebutMission.Text = "Départ : " + dateDepart.ToString("d", new CultureInfo("fr-FR"));

            DateTime dateRetour = Convert.ToDateTime(maMission["dateRetour"]);
            lblDateFinMission.Text = "Retour : " + dateRetour.ToString("d", new CultureInfo("fr-FR"));

            double budget = Convert.ToDouble(maMission["budget"]);
            double totalDepenses = 0;

            string planete = maMission["nomPlanete"].ToString();
            string num = maMission["numero"].ToString();

            string sql = "SELECT montant FROM depense WHERE nomPlanete = '" + planete + "' AND numeroMission = " + num;

            DataTable tableDepenses = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, Connexion.Connec);
            adapter.Fill(tableDepenses);

            foreach (DataRow ligne in tableDepenses.Rows)
            {
                totalDepenses += Convert.ToDouble(ligne["montant"]);
            }

            double solde = budget - totalDepenses;
            double ratio = (solde / budget) * 100;

            lblBudget.Text = "Budget : " + budget + " €";
            lblSolde.Text = "Solde restant : " + solde + " € (" + Math.Round(ratio, 2) + "%)";

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

            string sqlCapture = "SELECT Espece.nom, ObjectifCapture.objectif FROM ObjectifCapture INNER JOIN Espece ON ObjectifCapture.idEspeceEnnemi = Espece.id WHERE ObjectifCapture.nomPlanete = '" + planete + "' AND ObjectifCapture.numeroMission = " + num;
            DataTable tableCaptures = new DataTable();
            SQLiteDataAdapter adapterCap = new SQLiteDataAdapter(sqlCapture, Connexion.Connec);
            adapterCap.Fill(tableCaptures);

            string texteObjectifs = "";
            if (tableCaptures.Rows.Count > 0)
            {
                foreach (DataRow ligne in tableCaptures.Rows)
                {
                    texteObjectifs += "- " + ligne["nom"].ToString() + " : " + ligne["objectif"].ToString() + "\n";
                }
            }
            else
            {
                texteObjectifs = "Aucun objectif de capture";
            }
            lblListeObjectifs.Text = texteObjectifs;

            // Remplir tableMembres
            string sqlMembres = "SELECT Membre.matricule, Membre.nom, Membre.prenom FROM Membre " +
                                 "INNER JOIN Composer ON Membre.matricule = Composer.matriculeMembre " +
                                 "WHERE Composer.nomPlanete = '" + planete + "' AND Composer.numeroMission = " + num;

            SQLiteDataAdapter adapterMembres = new SQLiteDataAdapter(sqlMembres, Connexion.Connec);
            adapterMembres.Fill(tableMembres);

            // Etat initial : feuille visible, membres cachés
            diverseInfosPanel.Visible = true;
            panelMembres.Visible = false;
        }

        private void btnVoirMembresOuFeuille_Click(object sender, EventArgs e)
        {
            if (btnVoirMembresOuFeuille.Tag?.ToString() == "ROUGE")
            {
                btnVoirMembresOuFeuille.BackgroundImage = Properties.Resources.btnimggris;
                btnVoirMembresOuFeuille.ForeColor = Color.FromArgb(128, 128, 129);
                btnVoirMembresOuFeuille.Tag = "GRIS";

                btnVoirFeuille.BackgroundImage = Properties.Resources.btnimg;
                btnVoirFeuille.ForeColor = Color.FromArgb(229, 0, 43);
                btnVoirFeuille.Tag = "ROUGE";

                diverseInfosPanel.Visible = false;

                flowMembres.Controls.Clear();
                panelMembres.Visible = true;
                flowMembres.Visible = true;

                foreach (DataRow ligne in tableMembres.Rows)
                {
                    MembreUserControle uc = new MembreUserControle();
                    uc.ChargerDonnees(
                        ligne["matricule"].ToString(),
                        ligne["nom"].ToString(),
                        ligne["prenom"].ToString()
                    );
                    flowMembres.Controls.Add(uc);
                }
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

        private void grpObjectifCapture_Enter(object sender, EventArgs e)
        {
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVoirFeuille_Click(object sender, EventArgs e)
        {
            if (btnVoirFeuille.Tag?.ToString() == "ROUGE")
            {
                btnVoirFeuille.BackgroundImage = Properties.Resources.btnimggris;
                btnVoirFeuille.ForeColor = Color.FromArgb(128, 128, 129);
                btnVoirFeuille.Tag = "GRIS";

                btnVoirMembresOuFeuille.BackgroundImage = Properties.Resources.btnimg;
                btnVoirMembresOuFeuille.ForeColor = Color.FromArgb(229, 0, 43);
                btnVoirMembresOuFeuille.Tag = "ROUGE";

                flowMembres.Controls.Clear();
                panelMembres.Visible = false;
                diverseInfosPanel.Visible = true;
            }
        }

        private void pctJournal_Click(object sender, EventArgs e)
        {
            string planete = maMission["nomPlanete"].ToString();
            int numero = Convert.ToInt32(maMission["numero"]);

            journal frmJournal = new journal(planete, numero);
            frmJournal.ShowDialog();
        }

        private void pctJournal_MouseEnter(object sender, EventArgs e)
        {
            pctJournal.BackColor = Color.White;
            pctJournal.BackgroundImage = Properties.Resources.journoir;
        }

        private void pctJournal_MouseLeave(object sender, EventArgs e)
        {
            pctJournal.BackColor = Color.Transparent;
            pctJournal.BackgroundImage = Properties.Resources.journal;
        }

        private void pctEditerMission_MouseEnter(object sender, EventArgs e)
        {
            pctEditerMission.BackColor = Color.White;
            pctEditerMission.BackgroundImage = Properties.Resources.EditerMissionNoir;
        }

        private void pctEditerMission_MouseLeave(object sender, EventArgs e)
        {
            pctEditerMission.BackColor = Color.Transparent;
            pctEditerMission.BackgroundImage = Properties.Resources.EditerMission;
        }

        private void pictureBox8_MouseDown(object sender, MouseEventArgs e)
        {
            _pointDepart = e.Location;
        }

        private void pictureBox8_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - _pointDepart.X;
                this.Top += e.Y - _pointDepart.Y;
            }
        }

        private void pictureBox9_MouseDown(object sender, MouseEventArgs e)
        {
            _pointDepart = e.Location;
        }

        private void pictureBox9_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - _pointDepart.X;
                this.Top += e.Y - _pointDepart.Y;
            }
        }

        private void pctQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
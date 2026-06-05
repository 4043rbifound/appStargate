using appliPandora;
using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace appStargate
{
    public partial class journal : Form
    {
        private BindingSource _bsJournal = new BindingSource();
        private Point _pointDepart;
        public journal(string nomPlanete, int numeroMission)
        {
            InitializeComponent();

            this.Text = "Journal de bord : " + nomPlanete + " " + numeroMission;

            DataSet ds = new DataSet();

            new SQLiteDataAdapter(
                "SELECT dateJ, commentaires FROM JournalDeBord WHERE nomPlanete = '" + nomPlanete + "' AND numero = " + numeroMission +
                " ORDER BY CASE WHEN dateJ LIKE '__/__/____' " +
                " THEN substr(dateJ,7,4)||substr(dateJ,4,2)||substr(dateJ,1,2) " +
                " ELSE replace(dateJ,'-','') END ASC",
                Connexion.Connec).Fill(ds, "Journal");

            new SQLiteDataAdapter(
                "SELECT c.dateC AS Date, c.sommeVersee AS Somme, c.appreciation AS Appreciation, i.nom AS Informateur FROM Contact c INNER JOIN Informateur i ON c.nomCodeInformateur = i.nomCode WHERE c.nomPlanete = '" + nomPlanete + "' AND c.numeroMission = " + numeroMission + " ORDER BY c.dateC ASC",
                Connexion.Connec).Fill(ds, "Contacts");

            new SQLiteDataAdapter(
                "SELECT d.id AS [N°], d.dateD AS Date, d.motif AS Motif, d.montant AS [Montant], t.libelle AS [Type de dépense] FROM Depense d LEFT JOIN TypeDepense t ON d.idTypeDepense = t.id WHERE d.nomPlanete = '" + nomPlanete + "' AND d.numeroMission = " + numeroMission + " ORDER BY d.id ASC",
                Connexion.Connec).Fill(ds, "Depenses");

            _bsJournal.DataSource = ds.Tables["Journal"];
            lblDateJournal.DataBindings.Add("Text", _bsJournal, "dateJ", true, DataSourceUpdateMode.Never, null, "dd/MM/yyyy");
            lblCommentaireJournal.DataBindings.Add("Text", _bsJournal, "commentaires");

            _bsJournal.PositionChanged += _bsJournal_PositionChanged;

            string nomTableLocale = "BilanCapture" + nomPlanete + "-" + numeroMission;
            DataTable dtBilan = new DataTable(nomTableLocale);
            dtBilan.Columns.Add("Nom de l'espèce");
            dtBilan.Columns.Add("Objectif initial", typeof(int));
            dtBilan.Columns.Add("Nombre de captures réalisées", typeof(int));
            dtBilan.Columns.Add("Taux de réussite (en %)");

            string sqlBilan = @"
                SELECT E.nom AS [Nom de l'espèce], 
                       O.objectif AS [Objectif initial], 
                       IFNULL(C.nombre, 0) AS [Nombre de captures réalisées]
                FROM ObjectifCapture O
                INNER JOIN Espece E ON O.idEspeceEnnemi = E.id
                LEFT JOIN Capturer C ON O.nomPlanete = C.nomPlanete 
                                     AND O.numeroMission = C.numeroMission 
                                     AND O.idEspeceEnnemi = C.idEspeceEnnemi
                WHERE O.nomPlanete = '" + nomPlanete + "' AND O.numeroMission = " + numeroMission;

            new SQLiteDataAdapter(sqlBilan, Connexion.Connec).Fill(dtBilan);

            int totalObjectifs = 0;
            int totalRealise = 0;

            foreach (DataRow row in dtBilan.Rows)
            {
                double obj = Convert.ToDouble(row["Objectif initial"]);
                double real = Convert.ToDouble(row["Nombre de captures réalisées"]);

                totalObjectifs += Convert.ToInt32(obj);
                totalRealise += Convert.ToInt32(real);

                if (obj > 0)
                {
                    row["Taux de réussite (en %)"] = Math.Round((real / obj) * 100, 2) + " %";
                }
                else
                {
                    row["Taux de réussite (en %)"] = "0 %";
                }
            }

            if (totalObjectifs > 0)
            {
                lblCapture.Text = "Taux de capture total : " + Math.Round(((double)totalRealise / totalObjectifs) * 100, 2) + "%";
            }
            else
            {
                lblCapture.Text = "Taux de capture total : 0%";
            }

            ds.Tables.Add(dtBilan);
            dgvBilanCaptures.DataSource = dtBilan;

            dgvContacts.DataSource = ds.Tables["Contacts"];
            dgvDepenses.DataSource = ds.Tables["Depenses"];

            dgvContacts.ReadOnly = true;
            dgvDepenses.ReadOnly = true;

            CalculerTotaux(ds);
            MettreAJourCompteur();

        }

        private void _bsJournal_PositionChanged(object sender, EventArgs e)
        {
            MettreAJourCompteur();
            // Re-formate la date en français après chaque changement de position
            lblDateJournal.Text = DateTime.Parse(lblDateJournal.Text).ToString("dd/MM/yyyy");
        }

        private void CalculerTotaux(DataSet ds)
        {
            double totalSommes = 0;
            foreach (DataRow row in ds.Tables["Contacts"].Rows)
            {
                totalSommes += Convert.ToDouble(row["Somme"]);
            }
            lblTotalSommes.Text = "Total des sommes versées : " + totalSommes + "€";

            double totalDepenses = 0;
            foreach (DataRow row in ds.Tables["Depenses"].Rows)
            {
                totalDepenses += Convert.ToDouble(row["Montant"]);
            }
            lblTotalDepenses.Text = "Total des dépenses : " + totalDepenses + "€";
        }

        private void MettreAJourCompteur()
        {
            if (_bsJournal.Count == 0)
            {
                lblCompteur.Text = "0/0";
            }
            else
            {
                lblCompteur.Text = (_bsJournal.Position + 1) + "/" + _bsJournal.Count;
            }
        }

        private void btnPremier_Click(object sender, EventArgs e)
        {
            _bsJournal.MoveFirst();
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            _bsJournal.MovePrevious();
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            _bsJournal.MoveNext();
        }

        private void btnDernier_Click(object sender, EventArgs e)
        {
            _bsJournal.MoveLast();
        }

        private void btnEditerPdf_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Génération PDF incluant le bilan des captures.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void journal_Load(object sender, EventArgs e)
        {
            lblDateJournal.Text = DateTime.Parse(lblDateJournal.Text).ToString("dd/MM/yyyy");
        }

        private void pctQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
    }
}
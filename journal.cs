using appliPandora;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace appStargate
{
    public partial class journal : Form
    {
        private BindingSource _bsJournal = new BindingSource();

        public journal(string nomPlanete, int numeroMission)
        {
            InitializeComponent();

            this.Text = "Journal de bord : " + nomPlanete + " " + numeroMission;

            DataSet ds = new DataSet();

            new SQLiteDataAdapter(
                "SELECT dateJ, commentaires FROM JournalDeBord WHERE nomPlanete = '" + nomPlanete + "' AND numero = " + numeroMission + " ORDER BY dateJ ASC",
                Connexion.Connec).Fill(ds, "Journal");

            new SQLiteDataAdapter(
                "SELECT c.dateC AS Date, c.sommeVersee AS Somme, c.appreciation AS Appreciation, i.nom AS Informateur FROM Contact c INNER JOIN Informateur i ON c.nomCodeInformateur = i.nomCode WHERE c.nomPlanete = '" + nomPlanete + "' AND c.numeroMission = " + numeroMission + " ORDER BY c.dateC ASC",
                Connexion.Connec).Fill(ds, "Contacts");

            new SQLiteDataAdapter(
                "SELECT d.id AS [N°], d.dateD AS Date, d.motif AS Motif, d.montant AS [Montant], t.libelle AS [Type de dépense] FROM Depense d LEFT JOIN TypeDepense t ON d.idTypeDepense = t.id WHERE d.nomPlanete = '" + nomPlanete + "' AND d.numeroMission = " + numeroMission + " ORDER BY d.id ASC",
                Connexion.Connec).Fill(ds, "Depenses");

            _bsJournal.DataSource = ds.Tables["Journal"];
            lblDateJournal.DataBindings.Add("Text", _bsJournal, "dateJ");
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
                lblCapture.Text = "Taux de capture total : "+Math.Round(((double)totalRealise / totalObjectifs) * 100, 2) + "%";
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
            // Boîte de dialogue pour choisir où sauvegarder le PDF
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF files (*.pdf)|*.pdf";
            sfd.FileName = $"Rapport_Mission_{this.Text}.pdf";

            if (sfd.ShowDialog() != DialogResult.OK) return;

            try
            {
                // Création du document PDF
                iTextSharp.text.Document doc = new iTextSharp.text.Document(
                    iTextSharp.text.PageSize.A4, 40, 40, 40, 40
                );
                iTextSharp.text.pdf.PdfWriter.GetInstance(doc, new System.IO.FileStream(sfd.FileName, System.IO.FileMode.Create));
                doc.Open();

                // ─── POLICES ──────────────────────────────────────────────────
                iTextSharp.text.Font fontTitre = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font fontSousTitre = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font fontNormal = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.NORMAL);
                iTextSharp.text.Font fontGras = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font fontItalique = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.ITALIC);

                // ─── TITRE ────────────────────────────────────────────────────
                iTextSharp.text.Paragraph titre = new iTextSharp.text.Paragraph("Rapport de mission\n\n", fontTitre);
                titre.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                doc.Add(titre);

                // ─── RÉCUPÉRATION DES DONNÉES DEPUIS LES CONTRÔLES ────────────
                // On récupère les données déjà chargées dans le formulaire
                DataTable dtJournal = (_bsJournal.DataSource as DataTable);
                DataTable dtContacts = dgvContacts.DataSource as DataTable;
                DataTable dtDepenses = dgvDepenses.DataSource as DataTable;
                DataTable dtBilan = dgvBilanCaptures.DataSource as DataTable;

                // ─── INFOS MISSION ────────────────────────────────────────────
                string nomMission = this.Text.Replace("Journal de bord : ", "");
                doc.Add(new iTextSharp.text.Paragraph($"Mission : {nomMission}", fontGras));
                doc.Add(new iTextSharp.text.Paragraph($"Date de départ : {lblDateJournal.Text}", fontNormal));
                doc.Add(new iTextSharp.text.Paragraph($"Budget initial : {lblTotalDepenses.Text}", fontNormal));
                doc.Add(new iTextSharp.text.Paragraph($"Taux de capture : {lblCapture.Text}", fontNormal));
                doc.Add(new iTextSharp.text.Paragraph("\n"));

                // Ligne de séparation
                doc.Add(new iTextSharp.text.Paragraph("─────────────────────────────────────────────────────", fontNormal));
                doc.Add(new iTextSharp.text.Paragraph("\n"));

                // ─── JOURNAL DE BORD ──────────────────────────────────────────
                doc.Add(new iTextSharp.text.Paragraph("Journal de bord :", fontSousTitre));
                doc.Add(new iTextSharp.text.Paragraph("\n"));

                if (dtJournal != null)
                {
                    foreach (DataRow row in dtJournal.Rows)
                    {
                        string date = row["dateJ"].ToString();
                        string commentaire = row["commentaires"].ToString();
                        doc.Add(new iTextSharp.text.Paragraph($"Le {date} --> {commentaire}", fontNormal));
                    }
                }

                doc.Add(new iTextSharp.text.Paragraph("\n"));

                // ─── DÉPENSES ─────────────────────────────────────────────────
                doc.Add(new iTextSharp.text.Paragraph("Dépenses effectuées :", fontSousTitre));
                doc.Add(new iTextSharp.text.Paragraph("\n"));

                if (dtDepenses != null)
                {
                    int i = 1;
                    foreach (DataRow row in dtDepenses.Rows)
                    {
                        string date = row["Date"].ToString();
                        string motif = row["Motif"].ToString();
                        string montant = row["Montant"].ToString();
                        string type = row["Type de dépense"].ToString();
                        doc.Add(new iTextSharp.text.Paragraph(
                            $"{i}) le {date} : {motif} -> {montant} € ({type})", fontNormal
                        ));
                        i++;
                    }
                    doc.Add(new iTextSharp.text.Paragraph($"\n{lblTotalDepenses.Text}", fontGras));
                }

                doc.Add(new iTextSharp.text.Paragraph("\n"));

                // ─── CONTACTS INFORMATEURS ────────────────────────────────────
                doc.Add(new iTextSharp.text.Paragraph("Contacts avec des informateurs :", fontSousTitre));
                doc.Add(new iTextSharp.text.Paragraph("\n"));

                if (dtContacts != null)
                {
                    foreach (DataRow row in dtContacts.Rows)
                    {
                        string date = row["Date"].ToString();
                        string informateur = row["Informateur"].ToString();
                        string somme = row["Somme"].ToString();
                        string appreciation = row["Appreciation"].ToString();
                        doc.Add(new iTextSharp.text.Paragraph(
                            $"Le {date} : rencontre avec {informateur} -> {somme} € ({appreciation})", fontNormal
                        ));
                    }
                    doc.Add(new iTextSharp.text.Paragraph($"\n{lblTotalSommes.Text}", fontGras));
                }

                doc.Add(new iTextSharp.text.Paragraph("\n"));

                // ─── BILAN DES CAPTURES ───────────────────────────────────────
                doc.Add(new iTextSharp.text.Paragraph("Bilan des captures :", fontSousTitre));
                doc.Add(new iTextSharp.text.Paragraph("\n"));

                if (dtBilan != null && dtBilan.Rows.Count > 0)
                {
                    // Tableau pour le bilan
                    iTextSharp.text.pdf.PdfPTable tableau = new iTextSharp.text.pdf.PdfPTable(4);
                    tableau.WidthPercentage = 100;

                    // En-têtes du tableau
                    tableau.AddCell(new iTextSharp.text.pdf.PdfPCell(
                        new iTextSharp.text.Phrase("Nom de l'espèce", fontGras)));
                    tableau.AddCell(new iTextSharp.text.pdf.PdfPCell(
                        new iTextSharp.text.Phrase("Objectif initial", fontGras)));
                    tableau.AddCell(new iTextSharp.text.pdf.PdfPCell(
                        new iTextSharp.text.Phrase("Captures réalisées", fontGras)));
                    tableau.AddCell(new iTextSharp.text.pdf.PdfPCell(
                        new iTextSharp.text.Phrase("Taux de réussite", fontGras)));

                    // Lignes du tableau
                    foreach (DataRow row in dtBilan.Rows)
                    {
                        tableau.AddCell(new iTextSharp.text.pdf.PdfPCell(
                            new iTextSharp.text.Phrase(row["Nom de l'espèce"].ToString(), fontNormal)));
                        tableau.AddCell(new iTextSharp.text.pdf.PdfPCell(
                            new iTextSharp.text.Phrase(row["Objectif initial"].ToString(), fontNormal)));
                        tableau.AddCell(new iTextSharp.text.pdf.PdfPCell(
                            new iTextSharp.text.Phrase(row["Nombre de captures réalisées"].ToString(), fontNormal)));
                        tableau.AddCell(new iTextSharp.text.pdf.PdfPCell(
                            new iTextSharp.text.Phrase(row["Taux de réussite (en %)"].ToString(), fontNormal)));
                    }

                    doc.Add(tableau);
                    doc.Add(new iTextSharp.text.Paragraph($"\n{lblCapture.Text}", fontGras));
                }
                else
                {
                    doc.Add(new iTextSharp.text.Paragraph("Aucune capture pour cette mission.", fontItalique));
                }

                doc.Close();
                MessageBox.Show($"PDF généré avec succès !\n{sfd.FileName}", "Succès");

                // Ouvre le PDF automatiquement
                System.Diagnostics.Process.Start(sfd.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la génération du PDF : {ex.Message}", "Erreur");
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void journal_Load(object sender, EventArgs e)
        {

        }
    }
}
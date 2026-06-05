using appliPandora;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace appStargate
{
    public partial class journal : Form
    {
        // ─── VARIABLES DE LA CLASSE ───────────────────────────────────────
        private BindingSource _bsJournal = new BindingSource();
        private DataSet _ds = new DataSet();
        private string _nomPlanete;
        private int _numeroMission;
        private string _nomChef;
        private string _feuilleDeRoute;
        private string _dateDepart;
        private string _dateRetour;
        private int _budget;
        private List<Panel> _notifs = new List<Panel>();

        public journal(string nomPlanete, int numeroMission)
        {
            InitializeComponent();

            // On stocke les paramètres reçus
            _nomPlanete = nomPlanete;
            _numeroMission = numeroMission;
            this.Text = $"Journal de bord : {nomPlanete}-{numeroMission}";

            // ─── CHARGEMENT DES DONNÉES DEPUIS LA BASE (Sécurisé par paramètres) ───

            // Journal de bord
            using (SQLiteCommand cmd = new SQLiteCommand("SELECT dateJ, commentaires FROM JournalDeBord WHERE nomPlanete = @nom AND numero = @num ORDER BY dateJ ASC", Connexion.Connec))
            {
                cmd.Parameters.AddWithValue("@nom", nomPlanete);
                cmd.Parameters.AddWithValue("@num", numeroMission);
                new SQLiteDataAdapter(cmd).Fill(_ds, "Journal");
            }

            // Contacts avec les informateurs
            using (SQLiteCommand cmd = new SQLiteCommand(
                "SELECT c.dateC AS Date, c.sommeVersee AS Somme, c.appreciation AS Appreciation, i.nom AS Informateur " +
                "FROM Contact c INNER JOIN Informateur i ON c.nomCodeInformateur = i.nomCode " +
                "WHERE c.nomPlanete = @nom AND c.numeroMission = @num ORDER BY c.dateC ASC", Connexion.Connec))
            {
                cmd.Parameters.AddWithValue("@nom", nomPlanete);
                cmd.Parameters.AddWithValue("@num", numeroMission);
                new SQLiteDataAdapter(cmd).Fill(_ds, "Contacts");
            }

            // Dépenses
            using (SQLiteCommand cmd = new SQLiteCommand(
                "SELECT d.id AS [N°], d.dateD AS Date, d.motif AS Motif, d.montant AS [Montant], t.libelle AS [Type de dépense] " +
                "FROM Depense d LEFT JOIN TypeDepense t ON d.idTypeDepense = t.id " +
                "WHERE d.nomPlanete = @nom AND d.numeroMission = @num ORDER BY d.id ASC", Connexion.Connec))
            {
                cmd.Parameters.AddWithValue("@nom", nomPlanete);
                cmd.Parameters.AddWithValue("@num", numeroMission);
                new SQLiteDataAdapter(cmd).Fill(_ds, "Depenses");
            }

            // Infos de la mission + nom du chef
            using (SQLiteCommand cmd = new SQLiteCommand(
                "SELECT m.dateDepart, m.dateRetour, m.feuilleDeRoute, m.budget, mb.nom AS nomChef, mb.prenom AS prenomChef " +
                "FROM Mission m INNER JOIN Membre mb ON m.matriculeChef = mb.matricule " +
                "WHERE m.nomPlanete = @nom AND m.numero = @num", Connexion.Connec))
            {
                cmd.Parameters.AddWithValue("@nom", nomPlanete);
                cmd.Parameters.AddWithValue("@num", numeroMission);
                new SQLiteDataAdapter(cmd).Fill(_ds, "InfosMission");
            }

            // Membres de la mission
            using (SQLiteCommand cmd = new SQLiteCommand(
                "SELECT mb.nom, mb.prenom, CASE WHEN ci.matriculeMembre IS NOT NULL THEN 'Civil' ELSE 'Militaire' END AS type " +
                "FROM Composer c INNER JOIN Membre mb ON c.matriculeMembre = mb.matricule " +
                "LEFT JOIN Civil ci ON mb.matricule = ci.matriculeMembre " +
                "WHERE c.nomPlanete = @nom AND c.numeroMission = @num", Connexion.Connec))
            {
                cmd.Parameters.AddWithValue("@nom", nomPlanete);
                cmd.Parameters.AddWithValue("@num", numeroMission);
                new SQLiteDataAdapter(cmd).Fill(_ds, "Membres");
            }

            // On stocke les infos de la mission dans les variables
            if (_ds.Tables["InfosMission"].Rows.Count > 0)
            {
                DataRow infos = _ds.Tables["InfosMission"].Rows[0];
                _dateDepart = infos["dateDepart"].ToString();
                _dateRetour = infos["dateRetour"].ToString();
                _feuilleDeRoute = infos["feuilleDeRoute"].ToString();
                _budget = Convert.ToInt32(infos["budget"]);
                _nomChef = $"{infos["prenomChef"]} {infos["nomChef"]}";
            }

            // ─── BILAN DES CAPTURES ───────────────────────────────────────
            DataTable dtBilan = new DataTable($"BilanCapture{nomPlanete}-{numeroMission}");
            dtBilan.Columns.Add("Nom de l'espèce");
            dtBilan.Columns.Add("Objectif initial", typeof(int));
            dtBilan.Columns.Add("Nombre de captures réalisées", typeof(int));
            dtBilan.Columns.Add("Taux de réussite (en %)");

            using (SQLiteCommand cmd = new SQLiteCommand(
                "SELECT E.nom AS [Nom de l'espèce], O.objectif AS [Objectif initial], IFNULL(C.nombre, 0) AS [Nombre de captures réalisées] " +
                "FROM ObjectifCapture O INNER JOIN Espece E ON O.idEspeceEnnemi = E.id " +
                "LEFT JOIN Capturer C ON O.nomPlanete = C.nomPlanete AND O.numeroMission = C.numeroMission AND O.idEspeceEnnemi = C.idEspeceEnnemi " +
                "WHERE O.nomPlanete = @nom AND O.numeroMission = @num", Connexion.Connec))
            {
                cmd.Parameters.AddWithValue("@nom", nomPlanete);
                cmd.Parameters.AddWithValue("@num", numeroMission);
                new SQLiteDataAdapter(cmd).Fill(dtBilan);
            }

            // Calcul du taux de réussite pour chaque espèce
            int totalObjectifs = 0;
            int totalRealise = 0;

            foreach (DataRow row in dtBilan.Rows)
            {
                int obj = Convert.ToInt32(row["Objectif initial"]);
                int real = Convert.ToInt32(row["Nombre de captures réalisées"]);

                totalObjectifs += obj;
                totalRealise += real;

                row["Taux de réussite (en %)"] = obj > 0
                    ? Math.Round((double)real / obj * 100, 2) + " %"
                    : "0 %";
            }

            // Taux global
            lblCapture.Text = totalObjectifs > 0
                ? $"Taux de capture total : {Math.Round((double)totalRealise / totalObjectifs * 100, 2)}%"
                : "Taux de capture total : 0%";

            // ─── LIAISON DES DONNÉES AUX CONTRÔLES ───────────────────────
            _ds.Tables.Add(dtBilan);

            // Journal de bord → liaison de données pour les boutons navigation
            _bsJournal.DataSource = _ds.Tables["Journal"];
            lblDateJournal.DataBindings.Add("Text", _bsJournal, "dateJ");
            lblCommentaireJournal.DataBindings.Add("Text", _bsJournal, "commentaires");
            _bsJournal.PositionChanged += (s, ev) => MettreAJourCompteur();

            // Contacts et dépenses → directement dans les DataGridView
            dgvContacts.DataSource = _ds.Tables["Contacts"];
            dgvDepenses.DataSource = _ds.Tables["Depenses"];
            dgvBilanCaptures.DataSource = dtBilan;

            dgvContacts.ReadOnly = true;
            dgvDepenses.ReadOnly = true;

            // Calcul des totaux
            CalculerTotaux();
            MettreAJourCompteur();
        }

        // ─── SYSTEME DE NOTIFICATIONS ─────────────────────────────
        private void AfficherNotif(string message)
        {
            Panel notif = new Panel();
            notif.Size = new Size(350, 60);
            notif.BackColor = Color.FromArgb(39, 174, 96); // Vert (corrigé pour succès)

            Label lbl = new Label();
            lbl.Text = message;
            lbl.Dock = DockStyle.Fill;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.ForeColor = Color.White;
            lbl.Font = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
            notif.Controls.Add(lbl);

            int posY = 20 + (_notifs.Count * 70);
            notif.Location = new Point(-notif.Width, posY);

            this.Controls.Add(notif);
            notif.BringToFront();
            _notifs.Add(notif);

            AnimerEntree(notif, 20, posY);
        }

        private void AnimerEntree(Panel notif, int cibleX, int posY)
        {
            Timer timerEntree = new Timer();
            timerEntree.Interval = 5;
            timerEntree.Tick += (s, ev) =>
            {
                if (notif.Left < cibleX)
                {
                    int pas = Math.Max(2, (cibleX - notif.Left) / 4);
                    notif.Left += pas;
                }
                else
                {
                    notif.Left = cibleX;
                    timerEntree.Stop();
                    timerEntree.Dispose();

                    Timer timerAttente = new Timer();
                    timerAttente.Interval = 2500;
                    timerAttente.Tick += (s2, ev2) =>
                    {
                        timerAttente.Stop();
                        timerAttente.Dispose();
                        AnimerSortie(notif);
                    };
                    timerAttente.Start();
                }
            };
            timerEntree.Start();
        }

        private void AnimerSortie(Panel notif)
        {
            Timer timerSortie = new Timer();
            timerSortie.Interval = 5;
            timerSortie.Tick += (s, ev) =>
            {
                if (notif.Left > -notif.Width)
                {
                    int pas = Math.Max(2, (notif.Left + notif.Width) / 4);
                    notif.Left -= pas;
                }
                else
                {
                    timerSortie.Stop();
                    timerSortie.Dispose();
                    _notifs.Remove(notif);
                    this.Controls.Remove(notif);
                    notif.Dispose();
                    ReorganiserNotifs();
                }
            };
            timerSortie.Start();
        }

        private void ReorganiserNotifs()
        {
            for (int i = 0; i < _notifs.Count; i++)
            {
                int cibleY = 20 + (i * 70);
                Panel notif = _notifs[i];

                Timer timerReorg = new Timer();
                timerReorg.Interval = 5;
                timerReorg.Tick += (s, ev) =>
                {
                    if (notif.Top != cibleY)
                    {
                        int pas = Math.Max(1, Math.Abs(notif.Top - cibleY) / 4);
                        if (notif.Top > cibleY) notif.Top -= pas;
                        else notif.Top += pas;
                    }
                    else
                    {
                        timerReorg.Stop();
                        timerReorg.Dispose();
                    }
                };
                timerReorg.Start();
            }
        }

        // ─── CALCUL DES TOTAUX ────────────────────────────────────────────
        private void CalculerTotaux()
        {
            double totalSommes = 0;
            foreach (DataRow row in _ds.Tables["Contacts"].Rows)
                totalSommes += Convert.ToDouble(row["Somme"]);
            lblTotalSommes.Text = $"Total des sommes versées : {totalSommes}€";

            double totalDepenses = 0;
            foreach (DataRow row in _ds.Tables["Depenses"].Rows)
                totalDepenses += Convert.ToDouble(row["Montant"]);
            lblTotalDepenses.Text = $"Total des dépenses : {totalDepenses}€";
        }

        // ─── COMPTEUR DE NAVIGATION ───────────────────────────────────────
        private void MettreAJourCompteur()
        {
            lblCompteur.Text = _bsJournal.Count == 0
                ? "0/0"
                : $"{_bsJournal.Position + 1}/{_bsJournal.Count}";
        }

        // ─── BOUTONS DE NAVIGATION DU JOURNAL ────────────────────────────
        private void btnPremier_Click(object sender, EventArgs e) { _bsJournal.MoveFirst(); }
        private void btnPrecedent_Click(object sender, EventArgs e) { _bsJournal.MovePrevious(); }
        private void btnSuivant_Click(object sender, EventArgs e) { _bsJournal.MoveNext(); }
        private void btnDernier_Click(object sender, EventArgs e) { _bsJournal.MoveLast(); }

        // ─── FERMETURE ────────────────────────────────────────────────────
        private void pictureBox10_Click(object sender, EventArgs e) { this.Close(); }
        private void journal_Load(object sender, EventArgs e) { }

        // ─── GÉNÉRATION DU PDF ────────────────────────────────────────────
        private void btnEditerPdf_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF files (*.pdf)|*.pdf";
            sfd.FileName = $"Rapport_{_nomPlanete}-{_numeroMission}.pdf";

            if (sfd.ShowDialog() != DialogResult.OK) return;

            try
            {
                // ─── CRÉATION DU DOCUMENT ─────────────────────────────────
                Document doc = new Document(PageSize.A4, 50, 50, 50, 50);
                PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                doc.Open();

                // ─── POLICES ──────────────────────────────────────────────
                iTextSharp.text.Font fontTitre = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font fontSousTitre = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 13, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font fontGras = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font fontBlancGras = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD, BaseColor.WHITE);
                iTextSharp.text.Font fontNormal = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.NORMAL);
                iTextSharp.text.Font fontItalique = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.ITALIC);
                iTextSharp.text.Font fontGris = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.NORMAL, BaseColor.GRAY);

                // ─── TITRE ────────────────────────────────────────────────
                Paragraph titre = new Paragraph("Rapport de mission", fontTitre);
                titre.Alignment = Element.ALIGN_CENTER;
                titre.SpacingAfter = 5;
                doc.Add(titre);

                Paragraph sousTitre = new Paragraph($"Mission {_nomPlanete}-{_numeroMission}", fontSousTitre);
                sousTitre.Alignment = Element.ALIGN_CENTER;
                sousTitre.SpacingAfter = 15;
                doc.Add(sousTitre);

                doc.Add(new Paragraph(new string('-', 90), fontGris));
                doc.Add(new Paragraph("\n"));

                // ─── INFOS GÉNÉRALES ──────────────────────────────────────
                doc.Add(new Paragraph($"Départ le {_dateDepart}", fontGras));
                doc.Add(new Paragraph($"Retour le {_dateRetour}", fontGras));
                doc.Add(new Paragraph(new string('-', 90), fontGris));
                doc.Add(new Paragraph("\n"));
                doc.Add(new Paragraph($"Sous la responsabilité de  {_nomChef}", fontGras));
                doc.Add(new Paragraph($"Budget initial :  {_budget}€", fontGras));
                doc.Add(new Paragraph("\n"));

                // ─── FEUILLE DE ROUTE ─────────────────────────────────────
                doc.Add(new Paragraph("Feuille de route :", fontGras));
                doc.Add(new Paragraph(_feuilleDeRoute, fontNormal));
                doc.Add(new Paragraph("\n"));

                // ─── MEMBRES ──────────────────────────────────────────────
                doc.Add(new Paragraph(new string('-', 90), fontGris));
                doc.Add(new Paragraph("\n"));
                doc.Add(new Paragraph("Liste des membres", fontSousTitre));
                doc.Add(new Paragraph("\n"));

                foreach (DataRow row in _ds.Tables["Membres"].Rows)
                    doc.Add(new Paragraph($"--> {row["prenom"]} {row["nom"]} ({row["type"]})", fontNormal));

                doc.Add(new Paragraph("\n"));
                doc.Add(new Paragraph(new string('-', 90), fontGris));
                doc.Add(new Paragraph("\n"));

                // ─── JOURNAL DE BORD ──────────────────────────────────────
                doc.Add(new Paragraph("Journal de bord :", fontSousTitre));
                doc.Add(new Paragraph("\n"));

                DataTable dtJournal = _bsJournal.DataSource as DataTable;
                if (dtJournal != null && dtJournal.Rows.Count > 0)
                {
                    foreach (DataRow row in dtJournal.Rows)
                        doc.Add(new Paragraph($"Le {row["dateJ"]} --> {row["commentaires"]}", fontNormal));
                }
                else
                    doc.Add(new Paragraph("Aucun événement enregistré.", fontItalique));

                doc.Add(new Paragraph("\n"));

                // ─── DÉPENSES ─────────────────────────────────────────────
                doc.Add(new Paragraph("Dépenses effectuées :", fontSousTitre));
                doc.Add(new Paragraph("\n"));

                if (_ds.Tables["Depenses"].Rows.Count > 0)
                {
                    int i = 1;
                    foreach (DataRow row in _ds.Tables["Depenses"].Rows)
                    {
                        doc.Add(new Paragraph($"{i}) le {row["Date"]} : {row["Motif"]} -> {row["Montant"]} € ({row["Type de dépense"]})", fontNormal));
                        i++;
                    }
                    doc.Add(new Paragraph("\n"));
                    doc.Add(new Paragraph(lblTotalDepenses.Text, fontGras));
                }
                else
                    doc.Add(new Paragraph("Aucune dépense enregistrée.", fontItalique));

                doc.Add(new Paragraph("\n"));

                // ─── CONTACTS INFORMATEURS ────────────────────────────────
                doc.Add(new Paragraph("Contacts avec des informateurs :", fontSousTitre));
                doc.Add(new Paragraph("\n"));

                if (_ds.Tables["Contacts"].Rows.Count > 0)
                {
                    foreach (DataRow row in _ds.Tables["Contacts"].Rows)
                        doc.Add(new Paragraph($"Le {row["Date"]} : rencontre avec {row["Informateur"]} -> {row["Somme"]} € ({row["Appreciation"]})", fontNormal));
                    doc.Add(new Paragraph("\n"));
                    doc.Add(new Paragraph(lblTotalSommes.Text, fontGras));
                }
                else
                    doc.Add(new Paragraph("Aucun contact enregistré.", fontItalique));

                doc.Add(new Paragraph("\n"));

                // ─── BILAN DES CAPTURES ───────────────────────────────────
                doc.Add(new Paragraph("Bilan des captures :", fontSousTitre));
                doc.Add(new Paragraph("\n"));

                // CORRECTION ICI : Récupération sécurisée depuis le DataSet global
                string nomTableBilan = $"BilanCapture{_nomPlanete}-{_numeroMission}";
                DataTable dtBilan = _ds.Tables.Contains(nomTableBilan) ? _ds.Tables[nomTableBilan] : null;

                if (dtBilan != null && dtBilan.Rows.Count > 0)
                {
                    PdfPTable tableau = new PdfPTable(4);
                    tableau.WidthPercentage = 100;
                    tableau.SpacingBefore = 5;

                    BaseColor couleurEntete = new BaseColor(44, 62, 80);
                    string[] entetes = { "Nom de l'espèce", "Objectif initial", "Captures réalisées", "Taux de réussite" };

                    foreach (string entete in entetes)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(entete, fontBlancGras));
                        cell.BackgroundColor = couleurEntete;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.Padding = 5;
                        tableau.AddCell(cell);
                    }

                    bool ligneAlternee = false;
                    foreach (DataRow row in dtBilan.Rows)
                    {
                        BaseColor couleur = ligneAlternee ? new BaseColor(240, 240, 240) : BaseColor.WHITE;
                        string[] valeurs = {
                    row["Nom de l'espèce"].ToString(),
                    row["Objectif initial"].ToString(),
                    row["Nombre de captures réalisées"].ToString(),
                    row["Taux de réussite (en %)"].ToString()
                };

                        foreach (string valeur in valeurs)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(valeur, fontNormal));
                            cell.BackgroundColor = couleur;
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            cell.Padding = 5;
                            tableau.AddCell(cell);
                        }
                        ligneAlternee = !ligneAlternee;
                    }

                    doc.Add(tableau);
                    doc.Add(new Paragraph("\n"));
                    doc.Add(new Paragraph(lblCapture.Text, fontGras));
                }
                else
                {
                    doc.Add(new Paragraph("Aucune capture pour cette mission.", fontItalique));
                }

                // ─── FERMETURE ET OUVERTURE DU PDF ────────────────────────
                doc.Close();
                AfficherNotif("PDF généré avec succès !");
                System.Diagnostics.Process.Start(sfd.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}", "Erreur");
            }
        }
    }
}
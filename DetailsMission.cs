using appliPandora;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace appStargate
{
    public partial class DetailsMission : Form
    {
        private DataRow maMission;
        private DataTable tableMembres = new DataTable();

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

            // Appel de la méthode de calcul du solde en mode déconnecté
            RafraichirSolde();

            // Objectifs de capture (Depuis le DataSet déconnecté si présent, sinon fallback sécurisé)
            string planete = maMission["nomPlanete"].ToString();
            string num = maMission["numero"].ToString();
            string texteObjectifs = "";

            if (MesDatas.DsGlobal.Tables.Contains("ObjectifCapture") && MesDatas.DsGlobal.Tables.Contains("Espece"))
            {
                DataTable dtCapture = MesDatas.DsGlobal.Tables["ObjectifCapture"];
                DataTable dtEspece = MesDatas.DsGlobal.Tables["Espece"];

                // Filtrage local déconnecté des objectifs de cette mission
                DataRow[] lignesObj = dtCapture.Select($"nomPlanete = '{planete.Replace("'", "''")}' AND numeroMission = {num}");

                if (lignesObj.Length > 0)
                {
                    foreach (DataRow rowObj in lignesObj)
                    {
                        string nomEspece = "Espèce inconnue";
                        DataRow[] rowEspece = dtEspece.Select($"id = {rowObj["idEspeceEnnemi"]}");
                        if (rowEspece.Length > 0) nomEspece = rowEspece[0]["nom"].ToString();

                        texteObjectifs += "- " + nomEspece + " : " + rowObj["objectif"].ToString() + "\n";
                    }
                }
                else
                {
                    texteObjectifs = "Aucun objectif de capture";
                }
            }
            else
            {
                texteObjectifs = "Données d'objectifs indisponibles (MCD Déconnecté)";
            }
            lblListeObjectifs.Text = texteObjectifs;

            // Remplir tableMembres depuis le DataSet déconnecté
            if (MesDatas.DsGlobal.Tables.Contains("Membre") && MesDatas.DsGlobal.Tables.Contains("Composer"))
            {
                DataTable dtMembre = MesDatas.DsGlobal.Tables["Membre"];
                DataTable dtComposer = MesDatas.DsGlobal.Tables["Composer"];

                tableMembres = dtMembre.Clone(); // Copie la structure

                DataRow[] composition = dtComposer.Select($"nomPlanete = '{planete.Replace("'", "''")}' AND numeroMission = {num}");
                foreach (DataRow compRow in composition)
                {
                    DataRow[] membresTrouves = dtMembre.Select($"matricule = '{compRow["matriculeMembre"]}'");
                    foreach (DataRow m in membresTrouves)
                    {
                        tableMembres.ImportRow(m);
                    }
                }
            }

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
        private void RafraichirAffichage()
        {
            string planete = maMission["nomPlanete"].ToString();
            string num = maMission["numero"].ToString();

            // Recalcule le solde
            double budget = Convert.ToDouble(maMission["budget"]);
            double totalDepenses = 0;

            DataTable tableDepenses = new DataTable();
            new SQLiteDataAdapter(
                $"SELECT montant FROM depense WHERE nomPlanete = '{planete}' AND numeroMission = {num}",
                Connexion.Connec).Fill(tableDepenses);

            foreach (DataRow ligne in tableDepenses.Rows)
                totalDepenses += Convert.ToDouble(ligne["montant"]);

            double solde = budget - totalDepenses;
            double ratio = (solde / budget) * 100;

            lblSolde.Text = $"Solde restant : {solde} € ({Math.Round(ratio, 2)}%)";

            if (ratio > 75)
                lblSolde.ForeColor = Color.LimeGreen;
            else if (ratio > 45)
                lblSolde.ForeColor = Color.Orange;
            else
                lblSolde.ForeColor = Color.Red;
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

        private void pctEditerMission_Click(object sender, EventArgs e)
        {
            DateTime dateRetour = Convert.ToDateTime(maMission["dateRetour"]);

            if (dateRetour < DateTime.Today)
            {
                MessageBox.Show("Cette mission est terminée, elle ne peut plus être modifiée.",
                    "Mission terminée", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            formEditMission frm = new formEditMission(maMission, this);
            frm.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e) { this.Close(); }
        private void DetailsMission_Load(object sender, EventArgs e) { }
        private void lblTitreMission_Click(object sender, EventArgs e) { }
        private void lblObjDatabaz_Click(object sender, EventArgs e) { }
        private void lblSolde_Click(object sender, EventArgs e) { }
        private void grpObjectifCapture_Enter(object sender, EventArgs e) { }
        private void pctJournal_MouseEnter(object sender, EventArgs e) { pctJournal.BackColor = Color.White; pctJournal.BackgroundImage = Properties.Resources.journoir; }
        private void pctJournal_MouseLeave(object sender, EventArgs e) { pctJournal.BackColor = Color.Transparent; pctJournal.BackgroundImage = Properties.Resources.journal; }
        private void pctEditerMission_MouseEnter(object sender, EventArgs e) { pctEditerMission.BackColor = Color.White; pctEditerMission.BackgroundImage = Properties.Resources.EditerMissionNoir; }
        private void pctEditerMission_MouseLeave(object sender, EventArgs e) { pctEditerMission.BackColor = Color.Transparent; pctEditerMission.BackgroundImage = Properties.Resources.EditerMission; }

        public void RafraichirSolde()
        {
            string planete = maMission["nomPlanete"].ToString();
            string num = maMission["numero"].ToString();
            double budget = Convert.ToDouble(maMission["budget"]);
            double total = 0;

            // Protection si la table n'existe pas encore localement
            if (MesDatas.DsGlobal.Tables.Contains("Depense"))
            {
                DataTable dtDepenses = MesDatas.DsGlobal.Tables["Depense"];

                // Filtrer localement les lignes en mémoire correspondant à la mission courante
                DataRow[] lignesFiltrees = dtDepenses.Select($"nomPlanete = '{planete.Replace("'", "''")}' AND numeroMission = {num}");

                foreach (DataRow r in lignesFiltrees)
                {
                    // Éviter de compter les lignes supprimées en mémoire
                    if (r.RowState != DataRowState.Deleted)
                    {
                        total += Convert.ToDouble(r["montant"]);
                    }
                }
            }

            double solde = budget - total;
            double ratio = budget > 0 ? (solde / budget) * 100 : 0;

            lblBudget.Text = "Budget : " + budget + " €";
            lblSolde.Text = "Solde restant : " + solde + " € (" + Math.Round(ratio, 2) + "%)";
            lblSolde.ForeColor = ratio > 75 ? Color.LimeGreen
                               : ratio > 45 ? Color.Orange
                                            : Color.Red;
        }
        private void pctEditerMission_Click(object sender, EventArgs e)
        {
            // On affiche le panel d'édition
            pnlEdition.Visible = true;
            pnlEdition.BringToFront();

            // Au départ tous les sous-panels sont cachés
            pnlContact.Visible = false;
            pnlDepense.Visible = false;
            pnlEvenement.Visible = false;

            // On charge les informateurs et types de dépense
            ChargerInformateurs();
            ChargerTypesDepense();
        }
        
        

        

        // ─── CHARGEMENT DES LISTES DÉROULANTES ───────────────────────────────

        private void ChargerInformateurs()
        {
            cboInformateur.Items.Clear();

            string planete = maMission["nomPlanete"].ToString();
            string num = maMission["numero"].ToString();

            // On charge les informateurs contactés lors de cette mission
            DataTable dt = new DataTable();
            new SQLiteDataAdapter(
                $"SELECT DISTINCT nomCodeInformateur FROM Contact WHERE nomPlanete = '{planete}' AND numeroMission = {num}",
                Connexion.Connec).Fill(dt);

            foreach (DataRow row in dt.Rows)
                cboInformateur.Items.Add(row["nomCodeInformateur"].ToString());

            if (cboInformateur.Items.Count > 0)
                cboInformateur.SelectedIndex = 0;
        }

        private void ChargerTypesDepense()
        {
            cboTypeDepense.Items.Clear();

            DataTable dt = new DataTable();
            new SQLiteDataAdapter("SELECT id, libelle FROM TypeDepense", Connexion.Connec).Fill(dt);

            foreach (DataRow row in dt.Rows)
                cboTypeDepense.Items.Add(row["libelle"].ToString());

            if (cboTypeDepense.Items.Count > 0)
                cboTypeDepense.SelectedIndex = 0;
        }

        // ─── BOUTONS DE SÉLECTION DU TYPE ─────────────────────────────────────

        private void btnNouveauContact_Click(object sender, EventArgs e)
        {
            // Cache les autres panels et affiche celui du contact
            pnlContact.Visible = true;
            pnlDepense.Visible = false;
            pnlEvenement.Visible = false;

            // Date du jour par défaut
            dtpContact.Value = DateTime.Now;
        }

        private void btnNouvelleDepense_Click(object sender, EventArgs e)
        {
            pnlContact.Visible = false;
            pnlDepense.Visible = true;
            pnlEvenement.Visible = false;

            dtpDepense.Value = DateTime.Now;
        }

        private void btnNouvelEvenement_Click(object sender, EventArgs e)
        {
            pnlContact.Visible = false;
            pnlDepense.Visible = false;
            pnlEvenement.Visible = true;

            dtpEvenement.Value = DateTime.Now;
        }

        // ─── BOUTON VALIDER ───────────────────────────────────────────────────

        private void btnValider_Click(object sender, EventArgs e)
        {
            string planete = maMission["nomPlanete"].ToString();
            int num = Convert.ToInt32(maMission["numero"]);

            // On détermine quel panel est visible et on enregistre
            if (pnlContact.Visible)
                ValiderContact(planete, num);
            else if (pnlDepense.Visible)
                ValiderDepense(planete, num);
            else if (pnlEvenement.Visible)
                ValiderEvenement(planete, num);
            else
                MessageBox.Show("Sélectionnez un type d'ajout.", "Erreur");
        }

        private void ValiderContact(string planete, int num)
        {
            // Validation
            if (cboInformateur.SelectedItem == null)
            {
                MessageBox.Show("Sélectionnez un informateur.", "Erreur");
                return;
            }
            if (string.IsNullOrEmpty(txtSomme.Text) || !double.TryParse(txtSomme.Text, out double somme))
            {
                MessageBox.Show("Entrez un montant valide.", "Erreur");
                return;
            }

            try
            {
                string sql = $"INSERT INTO Contact (nomPlanete, numeroMission, dateC, sommeVersee, appreciation, nomCodeInformateur) " +
                             $"VALUES ('{planete}', {num}, '{dtpContact.Value:yyyy-MM-dd}', {somme}, '{txtAppreciation.Text}', '{cboInformateur.SelectedItem}')";

                SQLiteCommand cmd = new SQLiteCommand(sql, Connexion.Connec);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Contact enregistré !", "Succès");
                RafraichirAffichage();
                pnlEdition.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}", "Erreur");
            }
        }

        private void ValiderDepense(string planete, int num)
        {
            // Validation
            if (string.IsNullOrEmpty(txtMontant.Text) || !double.TryParse(txtMontant.Text, out double montant))
            {
                MessageBox.Show("Entrez un montant valide.", "Erreur");
                return;
            }
            if (string.IsNullOrEmpty(txtMotif.Text))
            {
                MessageBox.Show("Entrez un motif.", "Erreur");
                return;
            }
            if (cboTypeDepense.SelectedItem == null)
            {
                MessageBox.Show("Sélectionnez un type de dépense.", "Erreur");
                return;
            }

            try
            {
                // On récupère l'id du type de dépense
                DataTable dt = new DataTable();
                new SQLiteDataAdapter(
                    $"SELECT id FROM TypeDepense WHERE libelle = '{cboTypeDepense.SelectedItem}'",
                    Connexion.Connec).Fill(dt);

                int idType = Convert.ToInt32(dt.Rows[0]["id"]);

                string sql = $"INSERT INTO Depense (nomPlanete, numeroMission, dateD, montant, motif, idTypeDepense) " +
                             $"VALUES ('{planete}', {num}, '{dtpDepense.Value:yyyy-MM-dd}', {montant}, '{txtMotif.Text}', {idType})";

                SQLiteCommand cmd = new SQLiteCommand(sql, Connexion.Connec);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Dépense enregistrée !", "Succès");
                RafraichirAffichage();
                pnlEdition.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}", "Erreur");
            }
        }

        private void ValiderEvenement(string planete, int num)
        {
            // Validation
            if (string.IsNullOrEmpty(txtCommentaire.Text))
            {
                MessageBox.Show("Entrez un commentaire.", "Erreur");
                return;
            }

            try
            {
                string sql = $"INSERT INTO JournalDeBord (nomPlanete, numero, dateJ, commentaires) " +
                             $"VALUES ('{planete}', {num}, '{dtpEvenement.Value:yyyy-MM-dd}', '{txtCommentaire.Text}')";

                SQLiteCommand cmd = new SQLiteCommand(sql, Connexion.Connec);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Événement enregistré !", "Succès");
                RafraichirAffichage();
                pnlEdition.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}", "Erreur");
            }
        }

        // ─── BOUTON ANNULER ───────────────────────────────────────────────────

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            pnlEdition.Visible = false;
        }
    }
}
using appliPandora;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace appStargate
{
    public partial class formEditMission : Form
    {
        private DataRow maMission;
        private string nomPlanete;
        private int numeroMission;
        private DetailsMission formParent;

        public formEditMission(DataRow mission, DetailsMission parent)
        {
            InitializeComponent();
            maMission = mission;
            nomPlanete = maMission["nomPlanete"].ToString();
            numeroMission = Convert.ToInt32(maMission["numero"]);
            formParent = parent;
        }

        private void formEditMission_Load(object sender, EventArgs e)
        {
            // 1. Force la sélection exclusive dans les ComboBox (impossible d'écrire dedans)
            cboInformateur.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTypeDepense.DropDownStyle = ComboBoxStyle.DropDownList;

            // 2. Sécurise les champs d'argent (uniquement des nombres)
            txtSomme.KeyPress += BloquerLettresEtDecimaux_KeyPress;
            txtMontant.KeyPress += BloquerLettresEtDecimaux_KeyPress;

            panelContact.BringToFront();

            dtpDateContact.Value = DateTime.Today;
            dtpDateDepense.Value = DateTime.Today;
            dtpDateEvenement.Value = DateTime.Today;

            // 3. Remplissage déconnecté depuis le DataSet global
            ChargerInformateursDepuisDS();
            ChargerTypesDepenseDepuisDS();

            panelContact.Visible = true;
            panelDepense.Visible = false;
            panelEvenement.Visible = false;
        }

        private void ChargerInformateursDepuisDS()
        {
            try
            {
                if (MesDatas.DsGlobal.Tables.Contains("Informateur"))
                {
                    DataTable dt = MesDatas.DsGlobal.Tables["Informateur"];
                    cboInformateur.DataSource = dt;
                    cboInformateur.DisplayMember = "nomCode";
                    cboInformateur.ValueMember = "nomCode";
                }
                cboInformateur.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                AfficherNotif("Erreur informateurs : " + ex.Message);
            }
        }

        private void ChargerTypesDepenseDepuisDS()
        {
            try
            {
                if (MesDatas.DsGlobal.Tables.Contains("TypeDepense"))
                {
                    DataTable dt = MesDatas.DsGlobal.Tables["TypeDepense"];
                    cboTypeDepense.DataSource = dt;
                    cboTypeDepense.DisplayMember = "libelle";
                    cboTypeDepense.ValueMember = "id";
                }
                cboTypeDepense.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                AfficherNotif("Erreur types dépenses : " + ex.Message);
            }
        }

        // Bloque tout le clavier sauf les chiffres, le Backspace, et un SEUL point/virgule
        private void BloquerLettresEtDecimaux_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt == null) return;

            // Autoriser les chiffres et les touches système (effacer)
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                return;
            }

            // Autoriser le point ou la virgule, mais un seul au total
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                if (!txt.Text.Contains(".") && !txt.Text.Contains(","))
                {
                    return; // Autorisé
                }
            }

            // Bloque le reste (lettres, espaces, symboles bizarres)
            e.Handled = true;
        }

        // ── Navigation entre les sous-écrans graphiques ────────────────────

        private void picContact_Click_1(object sender, EventArgs e) { ActiverPanel(panelContact); }
        private void picDepense_Click_1(object sender, EventArgs e) { ActiverPanel(panelDepense); }
        private void picEvenement_Click_1(object sender, EventArgs e) { ActiverPanel(panelEvenement); }

        private void ActiverPanel(Panel panelCible)
        {
            panelContact.Visible = (panelCible == panelContact);
            panelDepense.Visible = (panelCible == panelDepense);
            panelEvenement.Visible = (panelCible == panelEvenement);
            panelCible.BringToFront();
        }

        private void btnValider_Click_1(object sender, EventArgs e)
        {
            if (panelContact.Visible) ValiderContactDéconnecté();
            else if (panelDepense.Visible) ValiderDepenseDéconnecté();
            else if (panelEvenement.Visible) ValiderEvenementDéconnecté();
        }

        private void btnAnnuler_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        // ── Validation et insertion en mode 100% DÉCONNECTÉ ────────────────

        private void ValiderContactDéconnecté()
        {
            if (cboInformateur.SelectedValue == null)
            {
                AfficherNotif("Sélectionnez un informateur.");
                return;
            }

            string allocationText = txtSomme.Text.Replace(",", ".");
            if (string.IsNullOrWhiteSpace(allocationText) || !double.TryParse(allocationText, NumberStyles.Any, CultureInfo.InvariantCulture, out double somme) || somme < 0)
            {
                AfficherNotif("Saisissez une somme valide.");
                return;
            }

            try
            {
                DataTable tableContact = MesDatas.DsGlobal.Tables["Contact"];

                // Création d'une nouvelle ligne calquée sur la structure locale
                DataRow nouvelleLigne = tableContact.NewRow();
                nouvelleLigne["nomPlanete"] = nomPlanete;
                nouvelleLigne["numeroMission"] = numeroMission;
                nouvelleLigne["dateC"] = dtpDateContact.Value.ToString("yyyy-MM-dd");
                nouvelleLigne["sommeVersee"] = somme;
                nouvelleLigne["appreciation"] = txtAppreciation.Text.Trim();
                nouvelleLigne["nomCodeInformateur"] = cboInformateur.SelectedValue.ToString();

                // Ajout local direct
                tableContact.Rows.Add(nouvelleLigne);

                AfficherNotif("Contact ajouté localement !", true);

                txtSomme.Clear();
                txtAppreciation.Clear();
                cboInformateur.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                AfficherNotif("Erreur DataSet local : " + ex.Message);
            }
        }

        private void ValiderDepenseDéconnecté()
        {
            string montantText = txtMontant.Text.Replace(",", ".");
            if (string.IsNullOrWhiteSpace(montantText) || !double.TryParse(montantText, NumberStyles.Any, CultureInfo.InvariantCulture, out double montant) || montant <= 0)
            {
                AfficherNotif("Saisissez un montant valide.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMotif.Text))
            {
                AfficherNotif("Le motif est obligatoire.");
                return;
            }

            if (cboTypeDepense.SelectedValue == null)
            {
                AfficherNotif("Sélectionnez un type de dépense.");
                return;
            }

            try
            {
                DataTable tableDepense = MesDatas.DsGlobal.Tables["Depense"];

                // Création de la ligne en mémoire
                DataRow nouvelleLigne = tableDepense.NewRow();
                nouvelleLigne["nomPlanete"] = nomPlanete;
                nouvelleLigne["numeroMission"] = numeroMission;
                nouvelleLigne["dateD"] = dtpDateDepense.Value.ToString("yyyy-MM-dd");
                nouvelleLigne["montant"] = montant;
                nouvelleLigne["motif"] = txtMotif.Text.Trim();
                nouvelleLigne["idTypeDepense"] = Convert.ToInt32(cboTypeDepense.SelectedValue);

                // Ajout local
                tableDepense.Rows.Add(nouvelleLigne);

                // RAFRAÎCHIT DIRECTEMENT LE PARENT (Le calcul se fait sur le DataSet mis à jour !)
                formParent.RafraichirSolde();

                AfficherNotif("Dépense enregistrée localement !", true);

                txtMontant.Clear();
                txtMotif.Clear();
                cboTypeDepense.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                AfficherNotif("Erreur DataSet local : " + ex.Message);
            }
        }

        private void ValiderEvenementDéconnecté()
        {
            if (string.IsNullOrWhiteSpace(txtCommentaires.Text))
            {
                AfficherNotif("Le commentaire ne peut pas être vide.");
                return;
            }

            try
            {
                DataTable tableJournal = MesDatas.DsGlobal.Tables["JournalDeBord"];

                DataRow nouvelleLigne = tableJournal.NewRow();
                nouvelleLigne["nomPlanete"] = nomPlanete;
                nouvelleLigne["numeroMission"] = numeroMission;
                nouvelleLigne["dateJ"] = dtpDateEvenement.Value.ToString("yyyy-MM-dd");
                nouvelleLigne["commentaires"] = txtCommentaires.Text.Trim();

                tableJournal.Rows.Add(nouvelleLigne);

                AfficherNotif("Journal mis à jour localement !", true);
                txtCommentaires.Clear();
            }
            catch (Exception ex)
            {
                AfficherNotif("Erreur DataSet local : " + ex.Message);
            }
        }

        // ── Redirection des anciens événements pour éviter les erreurs de compilation (CS1061) ──
        private void btnValiderObjectifs_Click_1(object sender, EventArgs e) { btnValider_Click_1(sender, e); }
        private void btnValiderMembres_Click_1(object sender, EventArgs e) { btnValider_Click_1(sender, e); }
        private void btnValiderMembres_Click_2(object sender, EventArgs e) { btnValider_Click_1(sender, e); }
        private void btnAjouterAlien_Click_1(object sender, EventArgs e) { }
        private void btnAjouterAlien_Click_2(object sender, EventArgs e) { }
        private void btnAjouterMembre_Click_1(object sender, EventArgs e) { }
        private void picContact_Click(object sender, EventArgs e) { picContact_Click_1(sender, e); }
        private void picDepense_Click(object sender, EventArgs e) { picDepense_Click_1(sender, e); }
        private void picEvenement_Click(object sender, EventArgs e) { picEvenement_Click_1(sender, e); }
        private void btnValider_Click(object sender, EventArgs e) { btnValider_Click_1(sender, e); }
        private void btnAnnuler_Click(object sender, EventArgs e) { btnAnnuler_Click_1(sender, e); }

        // ─── SYSTÈME DE NOTIFICATIONS ANIMÉES DE LA PORTE DES ÉTOILES ──────

        private List<Panel> _notifs = new List<Panel>();

        private void AfficherNotif(string message, bool isSuccess = false)
        {
            Panel notif = new Panel();
            notif.Size = new Size(380, 60);
            notif.BackColor = isSuccess ? Color.FromArgb(39, 174, 96) : Color.FromArgb(192, 57, 43);

            Label lbl = new Label();
            lbl.Text = message;
            lbl.Dock = DockStyle.Fill;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.ForeColor = Color.White;
            lbl.Font = new Font("Arial", 9.5F, FontStyle.Bold);
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
                    timerAttente.Interval = 2200;
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
    }
}
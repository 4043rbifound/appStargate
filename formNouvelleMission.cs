using appliPandora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appStargate
{
    public partial class formNouvelleMission : Form
    {
        public formNouvelleMission()
        {
            InitializeComponent();
        }
        private Point _pointDepart;
        private void formNouvelleMission_Load(object sender, EventArgs e)
        {
            dtpDepart.Value = DateTime.Today;
            dtpRetour.Value = DateTime.Today;
            try
            {
                string requete = "SELECT nom FROM Planete ORDER BY nom ASC";
                SQLiteCommand cmd = new SQLiteCommand(requete, Connexion.Connec);

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    cboPlanete.Items.Clear();
                    while (reader.Read())
                    {
                        cboPlanete.Items.Add(reader["nom"].ToString());
                    }
                }
                ChargerChefsMilitaires();
            }
            catch (Exception ex)
            {
                AfficherNotif("Erreur au chargement des planètes : " + ex.Message);
            }

            txtBudget.KeyPress += BloquerLettres_KeyPress;
            txtNbMembre.KeyPress += BloquerLettres_KeyPress;
            txtObjectifDataBaz.KeyPress += BloquerLettres_KeyPress;
        }

        private void ChargerChefsMilitaires()
        {
            try
            {
                string dateAujourdhui = DateTime.Today.ToString("yyyy-MM-dd");

                string requete = "SELECT M.matricule, M.nom, M.prenom, MI.grade " +
                                 "FROM Membre M " +
                                 "INNER JOIN Militaire MI ON M.matricule = MI.matriculeMembre " +
                                 "WHERE M.matricule NOT IN (" +
                                 "    SELECT matriculeChef FROM Mission " +
                                 "    WHERE dateDepart <= @aujourdhui AND dateRetour >= @aujourdhui" +
                                 ") " +
                                 "ORDER BY M.nom, M.prenom";

                SQLiteCommand cmd = new SQLiteCommand(requete, Connexion.Connec);
                cmd.Parameters.AddWithValue("@aujourdhui", dateAujourdhui);

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    cboChefMission.Items.Clear();
                    while (reader.Read())
                    {
                        // On inclut directement le matricule à la fin pour l'extraire facilement sans refaire de requête SQL
                        string affichage = $"{reader["nom"]} {reader["prenom"]} - {reader["grade"]} - {reader["matricule"]}";
                        cboChefMission.Items.Add(affichage);
                    }
                }
            }
            catch (Exception ex)
            {
                AfficherNotif("Erreur filtrage chefs : " + ex.Message);
            }
        }

        private void BloquerLettres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnValiderPlanete_Click(object sender, EventArgs e)
        {
            if (cboPlanete.SelectedIndex == -1)
            {
                AfficherNotif("Veuillez d'abord choisir une planète.");
                return;
            }

            string planeteChoisie = cboPlanete.SelectedItem.ToString();

            try
            {
                string requete = "SELECT COUNT(*) FROM Mission WHERE nomPlanete = @planete";
                SQLiteCommand cmd = new SQLiteCommand(requete, Connexion.Connec);
                cmd.Parameters.AddWithValue("@planete", planeteChoisie);

                int nbMissionsPrecedentes = Convert.ToInt32(cmd.ExecuteScalar());
                int numNouvelleMission = nbMissionsPrecedentes + 1;

                lblNomDeMission.Text = planeteChoisie;
                lblNumMission.Text = numNouvelleMission.ToString();

                cboPlanete.Enabled = false;
                btnValiderPlanete.Enabled = false;
                btnValiderPlanete.BackColor = Color.DarkGray;
            }
            catch (Exception ex)
            {
                AfficherNotif("Erreur SQL : " + ex.Message);
            }
        }

        private void btnValiderMission_Click(object sender, EventArgs e)
        {
            // Vérifications des champs
            if (cboPlanete.SelectedIndex == -1 || string.IsNullOrEmpty(lblNomDeMission.Text)) { AfficherNotif("Sélectionnez et validez d'abord une planète."); return; }
            if (cboChefMission.SelectedIndex == -1) { AfficherNotif("Sélectionnez un chef de mission."); return; }
            if (string.IsNullOrWhiteSpace(richtxtFeuilleRoute.Text)) { AfficherNotif("La feuille de route ne peut pas être vide."); return; }
            if (string.IsNullOrWhiteSpace(txtBudget.Text)) { AfficherNotif("Veuillez indiquer un budget."); return; }
            if (string.IsNullOrWhiteSpace(txtNbMembre.Text)) { AfficherNotif("Veuillez indiquer le nombre de membres."); return; }
            if (string.IsNullOrWhiteSpace(txtObjectifDataBaz.Text)) { AfficherNotif("Veuillez indiquer l'objectif DataBaz."); return; }

            try
            {
                string texteSelectionne = cboChefMission.SelectedItem.ToString();

                // On récupère directement le matricule qui est le tout dernier élément après le dernier tiret '-'
                string matriculeChef = texteSelectionne.Split('-').Last().Trim();

                string requeteInsertion = "INSERT INTO Mission (numero, nomPlanete, dateDepart, dateRetour, feuilleDeRoute, budget, nbMembreRequis, objectifDataBaz, matriculeChef) " +
                                          "VALUES (@num, @planete, @depart, @retour, @route, @budget, @membres, @databaz, @matriculeChef)";

                SQLiteCommand cmd = new SQLiteCommand(requeteInsertion, Connexion.Connec);
                cmd.Parameters.AddWithValue("@planete", lblNomDeMission.Text);
                cmd.Parameters.AddWithValue("@depart", dtpDepart.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@retour", dtpRetour.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@route", richtxtFeuilleRoute.Text);
                cmd.Parameters.AddWithValue("@budget", Convert.ToInt32(txtBudget.Text));
                cmd.Parameters.AddWithValue("@membres", Convert.ToInt32(txtNbMembre.Text));
                cmd.Parameters.AddWithValue("@databaz", Convert.ToInt32(txtObjectifDataBaz.Text));
                cmd.Parameters.AddWithValue("@matriculeChef", matriculeChef);
                cmd.Parameters.AddWithValue("@num", Convert.ToInt32(lblNumMission.Text));

                cmd.ExecuteNonQuery();

                // 1. On affiche la notification verte de succès !
                AfficherNotif("Insertion en cours ... ", true);

                // 2. On bloque temporairement le bouton pour éviter les double-clics
                btnValiderMission.Enabled = false;

                // 3. On initialise un Timer pour attendre 1,5 seconde (1500 ms) avant de changer d'écran
                Timer timerTransition = new Timer();
                timerTransition.Interval = 1500;
                timerTransition.Tick += (sTransition, evTransition) =>
                {
                    // Arrêt et libération du timer
                    timerTransition.Stop();
                    timerTransition.Dispose();

                    // Récupération des données pour le formulaire suivant
                    int numMission = Convert.ToInt32(lblNumMission.Text);
                    string planete = lblNomDeMission.Text;
                    int nbMembresRequis = Convert.ToInt32(txtNbMembre.Text);

                    // 4. On masque ce formulaire et on ouvre le gestionnaire d'équipage
                    this.Hide();
                    frmEquipageMission frmEquip = new frmEquipageMission(numMission, planete, nbMembresRequis);
                    frmEquip.ShowDialog();

                    this.Close();
                };

                timerTransition.Start();
            }
            catch (Exception ex)
            {
                AfficherNotif("Erreur lors de l'enregistrement : " + ex.Message);
            }
        }

        private List<Panel> _notifs = new List<Panel>();

        // Méthode de notification 
        private void AfficherNotif(string message, bool isSuccess = false)
        {
            Panel notif = new Panel();
            notif.Size = new Size(350, 60);

            // Choix dynamique de la couleur de fond
            if (isSuccess)
            {
                notif.BackColor = Color.FromArgb(39, 174, 96); // Vert Stargate élégant
            }
            else
            {
                notif.BackColor = Color.FromArgb(192, 57, 43); // Rouge alerte
            }

            Label lbl = new Label();
            lbl.Text = message;
            lbl.Dock = DockStyle.Fill;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.ForeColor = Color.White;
            lbl.Font = new Font("Arial", 10, FontStyle.Bold);
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

        private void lblNom_Click(object sender, EventArgs e) { }
        private void cboPlanete_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txtNbMembre_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void grpNouvelleMission_Enter(object sender, EventArgs e) { }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pctQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _pointDepart = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - _pointDepart.X;
                this.Top += e.Y - _pointDepart.Y;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows .Forms;

namespace appliPandora
{
    public partial class formAuthentification : Form
    {
        public formAuthentification()
        {
            InitializeComponent();
        }

        private void formAuthentification_Load(object sender, EventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLogin.Text) || string.IsNullOrEmpty(txtMdp.Text))
            {
                AfficherNotif("Veuillez remplir tous les champs.");
                return;
            }

            try
            {
                string requete = "SELECT mdp FROM Admin WHERE login = @login";
                SQLiteCommand cd = new SQLiteCommand(requete, Connexion.Connec);
                cd.Parameters.AddWithValue("@login", txtLogin.Text);

                object resultat = cd.ExecuteScalar();

                if (resultat != null && resultat != DBNull.Value)
                {
                    string mdpStocke = resultat.ToString();

                    if (BCrypt.Net.BCrypt.Verify(txtMdp.Text, mdpStocke))
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        AfficherNotif("Mot de passe incorrect.");
                    }
                }
                else
                {
                    AfficherNotif("Utilisateur inconnu.");
                }
            }
            catch (Exception ex)
            {
                AfficherNotif("Erreur technique : " + ex.Message);
            }
        }

        private void grpAuth_Enter(object sender, EventArgs e)
        {
        }

        // ─── SYSTÈME DE NOTIFICATIONS ─────────────────────────────────────

        private List<Panel> _notifs = new List<Panel>();

        private void AfficherNotif(string message)
        {
            Panel notif = new Panel();
            notif.Size = new Size(350, 60);
            notif.BackColor = Color.FromArgb(192, 57, 43);

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


        
    }
}           
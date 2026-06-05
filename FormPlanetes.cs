using appliPandora;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace appStargate
{
    public partial class FormPlanetes : Form
    {
        public FormPlanetes()
        {
            InitializeComponent();
            this.Load += FormPlanetes_Load;
            // Force l'ordre de dock : pnlDetail doit être avant flpPlanetes
            flpPlanetes.SendToBack();
        }


        private void flpPlanetes_Paint(object sender, PaintEventArgs e)
        {

        }
        private void FormPlanetes_Load(object sender, EventArgs e)
        {
            ChargerDonnees();
            AfficherCartesPlanetes();

            // Cache le panel de détail au départ
            splitContainer1.Panel2Collapsed = true;
            // Création du bouton retour par code
            Button btnRetour = new Button();
            btnRetour.Text = "← Retour";
            btnRetour.Size = new Size(120, 35);
            btnRetour.BackColor = Color.FromArgb(44, 62, 80);
            btnRetour.ForeColor = Color.White;
            btnRetour.FlatStyle = FlatStyle.Flat;
            btnRetour.Font = new Font("Arial", 10, FontStyle.Bold);
            btnRetour.Cursor = Cursors.Hand;

            // Position : en bas à gauche du Panel1
            btnRetour.Location = new Point(
                10,
                splitContainer1.Panel1.Height - btnRetour.Height - 10
            );

            btnRetour.Click += (s, ev) => this.Close();

            splitContainer1.Panel1.Controls.Add(btnRetour);
            btnRetour.BringToFront();

        }

        
        private void ChargerDonnees()
        {
            DataSet ds = MesDatas.DsGlobal;
            string[] tables = { "Planete", "Espece", "Allie", "Ennemi", "Habiter", "Mission", "Membre" };

            foreach (string nomTable in tables)
            {
                // On ne recharge pas si déjà présente
                if (ds.Tables.Contains(nomTable)) continue;

                try
                {
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter($"SELECT * FROM {nomTable}", Connexion.Connec);
                    adapter.Fill(ds, nomTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur chargement {nomTable} : {ex.Message}");
                }
            }

            // Mode déconnecté : on ferme la connexion
            Connexion.FermerConnexion();
        }

        /// <summary>
        /// Crée et affiche un UC par planète dans le FlowLayoutPanel
        /// </summary>
        private void AfficherCartesPlanetes()
        {
            flpPlanetes.Controls.Clear();

            DataTable dtPlanetes = MesDatas.DsGlobal.Tables["Planete"];
            if (dtPlanetes == null)
            {
                MessageBox.Show("La table Planete n'a pas été chargée !");
                return;
            }

            foreach (DataRow row in dtPlanetes.Rows)
            {

                this.Refresh();
                string nom = row["nom"].ToString();
                int temperature = row["temperature"] == DBNull.Value ? 0 : Convert.ToInt32(row["temperature"]);
                double gravite = row["gravite"] == DBNull.Value ? 0.0 : Convert.ToDouble(row["gravite"]);
                bool databazON = row["dataBazON"] != DBNull.Value && Convert.ToInt32(row["dataBazON"]) == 1;

                // Chemin vers l'image dans le dossier img
                string cheminImage = File.Exists(
                Path.Combine(Application.StartupPath, "images", nom + ".png"))
                    ? Path.Combine(Application.StartupPath, "images", nom + ".png")
                    : Path.Combine(Application.StartupPath, "images", nom + ".jpg");
                // Création du User Control
                UCPlanete uc = new UCPlanete(nom, temperature, gravite, databazON, cheminImage);

                // On branche le délégué
                uc.afficheurDetail = AfficherDetail;

                // Taille et style de la carte
                uc.Width = 160;
                uc.Height = 240;
                uc.Margin = new Padding(10);
                uc.BorderStyle = BorderStyle.FixedSingle;

                flpPlanetes.Controls.Add(uc);
            }
        }

        
        private void AfficherDetail(object sender, EventArgs e)
        {
            UCPlanete uc = sender as UCPlanete;
            if (uc == null) return;

            string nomPlanete = uc.NomPlanete;

            // Vérifie s'il y a des races ou des missions
            DataRow[] races = MesDatas.DsGlobal.Tables["Habiter"].Select($"nomPlanete = '{nomPlanete}'");
            DataRow[] missions = MesDatas.DsGlobal.Tables["Mission"].Select($"nomPlanete = '{nomPlanete}'");

            if (races.Length == 0 && missions.Length == 0)
            {
                // Aucune info : on cache le panel et on affiche un message
                splitContainer1.Panel2Collapsed = true;
                AfficherNotif($"Aucune information disponible sur {nomPlanete}.");
                return;
            }

            // Il y a des infos : on affiche le panel
            lblTitrePlanete.Text = nomPlanete;
            AfficherRacesPlanete(nomPlanete);
            AfficherMissionsPlanete(nomPlanete);
            AfficherGraphiqueRaces(nomPlanete);
            splitContainer1.Panel2Collapsed = false;
        }

        /// <summary>
        /// Affiche les races présentes sur la planète dans le DataGridView
        /// Tout depuis le DataSet — aucun accès base de données
        /// </summary>
        private void AfficherRacesPlanete(string nomPlanete)
        {
            DataSet ds = MesDatas.DsGlobal;
            DataTable dtHabiter = ds.Tables["Habiter"];
            DataTable dtEspece = ds.Tables["Espece"];
            DataTable dtAllie = ds.Tables["Allie"];
            DataTable dtEnnemi = ds.Tables["Ennemi"];

            // Table temporaire pour l'affichage
            DataTable dtAffichage = new DataTable();
            dtAffichage.Columns.Add("Espèce");
            dtAffichage.Columns.Add("Couleur");
            dtAffichage.Columns.Add("Type");
            dtAffichage.Columns.Add("Présence (%)");

            DataRow[] habitantsRows = dtHabiter.Select($"nomPlanete = '{nomPlanete}'");

            foreach (DataRow habRow in habitantsRows)
            {
                int idEspece = Convert.ToInt32(habRow["idEspece"]);
                int pourcentage = Convert.ToInt32(habRow["pourcentage"]);

                DataRow[] especeRows = dtEspece.Select($"id = {idEspece}");
                if (especeRows.Length == 0) continue;

                string nomEspece = especeRows[0]["nom"].ToString();
                string couleur = especeRows[0]["couleur"].ToString();

                string type = "Inconnu";
                if (dtAllie.Select($"idEspece = {idEspece}").Length > 0)
                    type = "Allié";
                else if (dtEnnemi.Select($"idEspece = {idEspece}").Length > 0)
                    type = "Ennemi";

                dtAffichage.Rows.Add(nomEspece, couleur, type, $"{pourcentage} %");
            }

            dgvRaces.DataSource = dtAffichage;
            dgvRaces.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRaces.RowHeadersVisible = false;
            dgvRaces.AllowUserToAddRows = false;
        }

        private void AfficherGraphiqueRaces(string nomPlanete)
        {
            chartRaces.Series.Clear();
            chartRaces.Titles.Clear();

            DataTable dtHabiter = MesDatas.DsGlobal.Tables["Habiter"];
            DataTable dtEspece = MesDatas.DsGlobal.Tables["Espece"];

            Series serie = new Series("Races");
            serie.ChartType = SeriesChartType.Pie;

            DataRow[] habitants = dtHabiter.Select($"nomPlanete = '{nomPlanete}'");

            foreach (DataRow hab in habitants)
            {
                int idEspece = Convert.ToInt32(hab["idEspece"]);
                int pourcentage = Convert.ToInt32(hab["pourcentage"]);

                DataRow[] espece = dtEspece.Select($"id = {idEspece}");

                if (espece.Length > 0)
                {
                    string nomEspece = espece[0]["nom"].ToString();

                    DataPoint point = new DataPoint();
                    point.AxisLabel = nomEspece;
                    point.YValues = new double[] { pourcentage };
                    point.LegendText = nomEspece;
                    point.Label = pourcentage + "%";

                    serie.Points.Add(point);
                }
            }

            chartRaces.Series.Add(serie);

            chartRaces.Titles.Add(
                $"Répartition des races sur {nomPlanete}"
            );

            chartRaces.Legends[0].Docking = Docking.Right;
        }
        private void AfficherMissionsPlanete(string nomPlanete)
        {
            lbMissions.Items.Clear();

            DataTable dtMissions = MesDatas.DsGlobal.Tables["Mission"];
            DataTable dtMembres = MesDatas.DsGlobal.Tables["Membre"];

            DataRow[] missionRows = dtMissions.Select($"nomPlanete = '{nomPlanete}'");

            if (missionRows.Length == 0)
            {
                lbMissions.Items.Add("Aucune mission sur cette planète.");
                return;
            }

            foreach (DataRow mission in missionRows)
            {
                int numero = Convert.ToInt32(mission["numero"]);
                string depart = mission["dateDepart"].ToString();
                string retour = mission["dateRetour"].ToString();
                string matricule = mission["matriculeChef"].ToString();
                int budget = Convert.ToInt32(mission["budget"]);

                // Recherche du nom du chef
                DataRow[] chefRows = dtMembres.Select($"matricule = '{matricule}'");
                string nomChef = chefRows.Length > 0
                    ? $"{chefRows[0]["prenom"]} {chefRows[0]["nom"]}"
                    : matricule;

                lbMissions.Items.Add(
                    $"Mission {nomPlanete}-{numero} | {depart} → {retour} | Chef : {nomChef} | Budget : {budget}€"
                );
            }
        }

        // ─── SYSTÈME DE NOTIFICATIONS ─────────────────────────────────────────────

        private List<Panel> _notifs = new List<Panel>();

        private void AfficherNotif(string message)
        {
            // Création d'un nouveau panel de notif
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

            // Position de départ selon le nombre de notifs déjà affichées
            int posY = 20 + (_notifs.Count * 70); // 70 = hauteur + marge
            notif.Location = new Point(-notif.Width, posY);

            this.Controls.Add(notif);
            notif.BringToFront();
            _notifs.Add(notif);

            // Animation entrée
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

                    // Attend puis fait sortir
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
                    // Supprime la notif et réorganise les autres
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
            // Replace les notifs restantes à la bonne hauteur
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
        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvRaces_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pctQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private Point _pointDepart;
        private void splitContainer1_Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            _pointDepart = e.Location;
        }

        private void splitContainer1_Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - _pointDepart.X;
                this.Top += e.Y - _pointDepart.Y;
            }
        }

        private void flpPlanetes_MouseDown(object sender, MouseEventArgs e)
        {
            _pointDepart = e.Location;
        }

        private void flpPlanetes_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - _pointDepart.X;
                this.Top += e.Y - _pointDepart.Y;
            }
        }
    }
}

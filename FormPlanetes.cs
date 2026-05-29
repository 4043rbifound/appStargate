using appliPandora;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace appStargate
{
    public partial class FormPlanetes : Form
    {
        public FormPlanetes()
        {
            InitializeComponent();
            this.Load += FormPlanetes_Load;
            flpPlanetes.SendToBack();
        }

        private void flpPlanetes_Paint(object sender, PaintEventArgs e) { }

        private void FormPlanetes_Load(object sender, EventArgs e)
        {
            // Force pnlBas à être visible
            splitContainer1.SendToBack();
            ChargerDonnees();
            AfficherCartesPlanetes();
            splitContainer1.Panel2Collapsed = true;

        }

        private void ChargerDonnees()
        {
            DataSet ds = MesDatas.DsGlobal;
            string[] tables = { "Planete", "Espece", "Allie", "Ennemi", "Habiter", "Mission", "Membre" };

            foreach (string nomTable in tables)
            {
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
            Connexion.FermerConnexion();
        }

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
                string nom = row["nom"].ToString();
                int temperature = row["temperature"] == DBNull.Value ? 0 : Convert.ToInt32(row["temperature"]);
                double gravite = row["gravite"] == DBNull.Value ? 0.0 : Convert.ToDouble(row["gravite"]);
                bool databazON = row["dataBazON"] != DBNull.Value && Convert.ToInt32(row["dataBazON"]) == 1;

                string cheminImage = Path.Combine(Application.StartupPath, "images", nom + ".jpg");

                UCPlanete uc = new UCPlanete(nom, temperature, gravite, databazON, cheminImage);
                uc.afficheurDetail = AfficherDetail;
                uc.Width = 390;
                uc.Height = 70;
                uc.Margin = new Padding(5, 3, 5, 3);
                uc.BorderStyle = BorderStyle.FixedSingle;

                flpPlanetes.Controls.Add(uc);
            }
        }

        private void AfficherDetail(object sender, EventArgs e)
        {
            UCPlanete uc = sender as UCPlanete;
            if (uc == null) return;

            string nomPlanete = uc.NomPlanete;

            DataRow[] races = MesDatas.DsGlobal.Tables["Habiter"].Select($"nomPlanete = '{nomPlanete}'");
            DataRow[] missions = MesDatas.DsGlobal.Tables["Mission"].Select($"nomPlanete = '{nomPlanete}'");

            if (races.Length == 0 && missions.Length == 0)
            {
                splitContainer1.Panel2Collapsed = true;
                AfficherNotif($"Aucune information disponible sur {nomPlanete}.");
                return;
            }

            lblTitrePlanete.Text = nomPlanete;
            AfficherRacesPlanete(nomPlanete);
            AfficherMissionsPlanete(nomPlanete);
            splitContainer1.Panel2Collapsed = false;
        }

        private void AfficherRacesPlanete(string nomPlanete)
        {
            DataSet ds = MesDatas.DsGlobal;
            DataTable dtHabiter = ds.Tables["Habiter"];
            DataTable dtEspece = ds.Tables["Espece"];
            DataTable dtAllie = ds.Tables["Allie"];
            DataTable dtEnnemi = ds.Tables["Ennemi"];

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

        private void AfficherMissionsPlanete(string nomPlanete)
        {
            lbMissions.Text = "";

            DataTable dtMissions = MesDatas.DsGlobal.Tables["Mission"];
            DataTable dtMembres = MesDatas.DsGlobal.Tables["Membre"];

            DataRow[] missionRows = dtMissions.Select($"nomPlanete = '{nomPlanete}'");

            if (missionRows.Length == 0)
            {
                lbMissions.Text = "Aucune mission sur cette planète.";
                return;
            }

            string texte = "";

            foreach (DataRow mission in missionRows)
            {
                int numero = Convert.ToInt32(mission["numero"]);
                string depart = mission["dateDepart"].ToString();
                string retour = mission["dateRetour"].ToString();
                string matricule = mission["matriculeChef"].ToString();
                int budget = Convert.ToInt32(mission["budget"]);

                DataRow[] chefRows = dtMembres.Select($"matricule = '{matricule}'");
                string nomChef = chefRows.Length > 0
                    ? $"{chefRows[0]["prenom"]} {chefRows[0]["nom"]}"
                    : matricule;

                texte += $"• Mission {nomPlanete}-{numero}\n";
                texte += $"  Départ : {depart}  →  Retour : {retour}\n";
                texte += $"  Chef : {nomChef}  |  Budget : {budget}€\n\n";
            }

            lbMissions.Text = texte.TrimEnd();
        }

        // ─── SYSTÈME DE NOTIFICATIONS ─────────────────────────────────────────────

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

        private void btnRetour_Click(object sender, EventArgs e) { this.Close(); }
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e) { }
        private void dgvRaces_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
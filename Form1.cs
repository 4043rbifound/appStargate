using appStargate;
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

namespace appliPandora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConfigurerFlowLayoutPanel();
        }
        private Point _pointDepart;

        SQLiteConnection maConnec = Connexion.Connec;

        private void ConfigurerFlowLayoutPanel()
        {
            flowLayoutPanelMissions.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelMissions.WrapContents = false;
            flowLayoutPanelMissions.AutoScroll = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                if (maConnec.State != ConnectionState.Open) maConnec.Open();

                if (MesDatas.DsGlobal.Tables.Contains("Mission"))
                { MesDatas.DsGlobal.Tables["Mission"].Clear(); }
                if (MesDatas.DsGlobal.Tables.Contains("Membre"))
                { MesDatas.DsGlobal.Tables["Membre"].Clear(); }

                SQLiteCommand cmdMission = new SQLiteCommand("SELECT * FROM Mission", maConnec);
                SQLiteDataAdapter daMission = new SQLiteDataAdapter(cmdMission);
                daMission.Fill(MesDatas.DsGlobal, "Mission");

                SQLiteCommand cmdMembre = new SQLiteCommand("SELECT * FROM Membre", maConnec);
                SQLiteDataAdapter daMembre = new SQLiteDataAdapter(cmdMembre);
                daMembre.Fill(MesDatas.DsGlobal, "Membre");

                flowLayoutPanelMissions.Controls.Clear();

                foreach (DataRow ligneMission in MesDatas.DsGlobal.Tables["Mission"].Rows)
                {
                    MissionUserControle uc = new MissionUserControle();

                    string matriculeChef = ligneMission["matriculeChef"].ToString();
                    string nomCompletChef = "Inconnu";

                    foreach (DataRow ligneMembre in MesDatas.DsGlobal.Tables["Membre"].Rows)
                    {
                        if (ligneMembre["matricule"].ToString() == matriculeChef)
                        {
                            nomCompletChef = ligneMembre["prenom"].ToString() + " " + ligneMembre["nom"].ToString();
                            break;
                        }
                    }

                    uc.ChargerDonnees(ligneMission, nomCompletChef);
                    flowLayoutPanelMissions.Controls.Add(uc);
                }

                int total = MesDatas.DsGlobal.Tables["Mission"].Rows.Count;
                lblTotalMission.Text = total.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formAuthentification formAuth = new formAuthentification();
            if (formAuth.ShowDialog() == DialogResult.OK)
            {
                formNouvelleMission formCrea = new formNouvelleMission();
                formCrea.ShowDialog();
                // Quand formNouvelleMission se ferme, on recharge la liste des missions
                Form1_Load(null, null);
            }
        }

        private void btn_NVplnt_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is FormPlanetes)
                {
                    f.BringToFront();
                    return;
                }
            }

            FormPlanetes frmPlanetes = new FormPlanetes();
            frmPlanetes.Show();
        }

        private void btnRaces_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is FormRaces)
                {
                    f.BringToFront();
                    return;
                }
            }

            FormRaces frmRaces = new FormRaces();
            frmRaces.Show();
        }

        private void lblTotalMission_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is FormStats)
                {
                    f.BringToFront();
                    return;
                }
            }

            FormStats frmStats = new FormStats();
            frmStats.Show();
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

        private void pctQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            _pointDepart = e.Location;
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - _pointDepart.X;
                this.Top += e.Y - _pointDepart.Y;
            }
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
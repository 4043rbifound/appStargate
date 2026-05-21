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
        }

        SQLiteConnection maConnec = Connexion.Connec;

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

                maConnec.Close();

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
                lblTotalMission.Text = "Missions : " + total.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formAuthentification formAuth = new formAuthentification();
            if(formAuth.ShowDialog() == DialogResult.OK)
            {
                formNouvelleMission formCrea = new formNouvelleMission();
                formCrea.ShowDialog();
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
    }
}
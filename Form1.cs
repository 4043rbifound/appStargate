using appStargate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            formAuthentification formAuth = new formAuthentification();
            formAuth.Show();
        }

        private void btnInfosMissions_Click(object sender, EventArgs e)
        {
            try
            {
                if (maConnec.State != ConnectionState.Open) maConnec.Open();

                DataTable dtSchema = maConnec.GetSchema("Tables");

                for (int i = 0; i < dtSchema.Rows.Count; i++)
                {
                    string nomTable = dtSchema.Rows[i]["TABLE_NAME"].ToString();
                    if (nomTable.StartsWith("sqlite_")) continue;

                    if (MesDatas.DsGlobal.Tables.Contains(nomTable))
                        MesDatas.DsGlobal.Tables[nomTable].Clear();

                    string requete = "SELECT * FROM [" + nomTable + "]";
                    SQLiteCommand cd = new SQLiteCommand(requete, maConnec);
                    SQLiteDataAdapter da = new SQLiteDataAdapter(cd);
                    da.Fill(MesDatas.DsGlobal, nomTable);
                }
                maConnec.Close();

                flowLayoutPanelMissions.Controls.Clear();

                DataTable dtMissions = MesDatas.DsGlobal.Tables["Mission"];
                DataTable dtMembres = MesDatas.DsGlobal.Tables["Membre"];

                foreach (DataRow ligneMission in dtMissions.Rows)
                {
                    MissionUserControle uc = new MissionUserControle();

                    string matricule = ligneMission["matriculeChef"].ToString();
                    DataRow[] membresTrouves = dtMembres.Select("matricule = '" + matricule + "'");

                    string nomComplet = "Inconnu";
                    if (membresTrouves.Length > 0)
                    {
                        nomComplet = membresTrouves[0]["prenom"].ToString() + " " + membresTrouves[0]["nom"].ToString();
                    }

                    uc.ChargerDonnees(ligneMission, nomComplet);
                    flowLayoutPanelMissions.Controls.Add(uc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}

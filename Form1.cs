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

        }

        private void btnInfosMissions_Click(object sender, EventArgs e)
        {

            DataTable dtSchema = maConnec.GetSchema("Tables");
            for (int i = 1; i < dtSchema.Rows.Count; i++)
            {
                string nomTable = dtSchema.Rows[i]["TABLE_NAME"].ToString();
                string requete = "select * from " + nomTable;
                SQLiteCommand cd = new SQLiteCommand(requete, maConnec);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cd);
                da.SelectCommand = cd;
                da.Fill(MesDatas.DsGlobal, nomTable);
            }

            maConnec.Close();

            FormulaireInfoMissions fenetreInfosMissions = new FormulaireInfoMissions();
            fenetreInfosMissions.ShowDialog();
        }
    }
}

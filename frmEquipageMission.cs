using appliPandora;
using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace appStargate
{
    public partial class frmEquipageMission : Form
    {
        private int _numMission;
        private string _nomPlanete;
        private int nbMembre;

        public frmEquipageMission(int numero, string planete,int nbMembre)
        {
            InitializeComponent();

            this._numMission = numero;
            this._nomPlanete = planete;
            this.nbMembre = nbMembre;
        }

        private void frmEquipageMission_Load(object sender, EventArgs e)
        {
            try
            {
                // récuperer nom chef
                string reqChef = "SELECT matriculeChef FROM Mission WHERE numero = @num AND nomPlanete = @planete";
                SQLiteCommand cmdChef = new SQLiteCommand(reqChef, Connexion.Connec);
                cmdChef.Parameters.AddWithValue("@num", _numMission);
                cmdChef.Parameters.AddWithValue("@planete", _nomPlanete);

                string resChef = cmdChef.ExecuteScalar().ToString();
                string matriculeChef = resChef != null ? resChef.ToString() : "";

                // charger membre sans le chef de la mission
                string reqMembres = "SELECT matricule, nom, prenom FROM Membre WHERE matricule != @matChef ORDER BY nom ASC";
                SQLiteCommand cmdM = new SQLiteCommand(reqMembres, Connexion.Connec);
                cmdM.Parameters.AddWithValue("@matChef", resChef);

                SQLiteDataReader r = cmdM.ExecuteReader();
                {
                    cboMembre.Items.Clear();
                    while (r.Read())
                    {
                        cboMembre.Items.Add($"{r["nom"]} {r["prenom"]} - {r["matricule"]}");
                    }
                }

                // charger alien 
                string reqAliens = "SELECT nom FROM Extraterrestre ORDER BY nom ASC";
                SQLiteCommand cmdA = new SQLiteCommand(reqAliens, Connexion.Connec);

                using (SQLiteDataReader reader = cmdA.ExecuteReader())
                {
                    cboAlien.Items.Clear();
                    while (reader.Read())
                    {
                        cboAlien.Items.Add(reader["nom"].ToString());
                    }
                }
                lblNbMembreaffecter.Text = nbMembre.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur au chargement des données : " + ex.Message);
            }
        }

        private void btnValiderMembre_Click(object sender, EventArgs e)
        {

        }
    }
}
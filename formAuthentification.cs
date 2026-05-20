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
            try
            {
                string requete = "SELECT mdp FROM Admin WHERE login = @login";

                SQLiteCommand  cd = new SQLiteCommand(requete, Connexion.Connec);
                cd.Parameters.AddWithValue("@login", txtLogin.Text); // Sécurité supplementaire pour éviter les injection SQL 

                object resultat = cd.ExecuteScalar();

                if (resultat != null && resultat != DBNull.Value)
                {
                    string mdpStocke = resultat.ToString();

                    if (BCrypt.Net.BCrypt.Verify(txtMdp.Text, mdpStocke))
                    {
                        MessageBox.Show("Accès autorisé", "Authentification");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Accès refusé : mauvais mot de passe", "Authentification");
                    }
                }
                else
                {
                    MessageBox.Show("Utilisateur inconnu", "Authentification");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }
    }
}           
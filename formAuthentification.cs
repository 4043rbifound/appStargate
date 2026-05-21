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
            // On vide le message d'erreur à chaque clic
            lblErreur.Text = "";

            if (string.IsNullOrEmpty(txtLogin.Text) || string.IsNullOrEmpty(txtMdp.Text))
            {
                lblErreur.Text = "Veuillez remplir tous les champs.";
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
                        lblErreur.Text = "Mot de passe incorrect.";
                    }
                }
                else
                {
                    lblErreur.Text = "Utilisateur inconnu.";
                }
            }
            catch (Exception ex)
            {
                lblErreur.Text = "Erreur technique : " + ex.Message;
            }
        }

        private void grpAuth_Enter(object sender, EventArgs e)
        {

        }
    }
}           
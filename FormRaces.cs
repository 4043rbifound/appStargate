using appliPandora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appStargate
{
    public partial class FormRaces : Form
    {
        // Filtre actuel : "Tous", "Allié", "Ennemi"
        private string _filtreType = "Tous";
        private string _filtreNom = "";
        private string _filtreCouleur = "";

        public FormRaces()
        {
            InitializeComponent();
            this.Load += FormRaces_Load;
        }

        private void FormRaces_Load(object sender, EventArgs e)
        {
            ChargerDonnees();
            AfficherAliensFiltre();
            StylerBoutons(btnTous);

            // Ajoute le UCFiltres dans le panel de filtres
            UCFiltres ucFiltres = new UCFiltres(this);
            ucFiltres.Location = new System.Drawing.Point(10, 170);
            pnlFiltres.Controls.Add(ucFiltres);

            // Bouton retour en bas du pnlFiltres
            Button btnRetour = new Button();
            btnRetour.Text = "← Retour";
            btnRetour.Size = new Size(160, 35);
            btnRetour.BackColor = Color.FromArgb(44, 62, 80);
            btnRetour.ForeColor = Color.White;
            btnRetour.FlatStyle = FlatStyle.Flat;
            btnRetour.Font = new Font("Arial", 10, FontStyle.Bold);
            btnRetour.Cursor = Cursors.Hand;
            btnRetour.Location = new Point(10, pnlFiltres.Height - 50);
            btnRetour.Click += (s, ev) => this.Close();

            pnlFiltres.Controls.Add(btnRetour);
        }

        // ─── CHARGEMENT DES DONNÉES ────────────────────────────────────────

        private void ChargerDonnees()
        {
            DataSet ds = MesDatas.DsGlobal;
            string[] tables = { "Espece", "Allie", "Ennemi" };

            foreach (string nomTable in tables)
            {
                if (ds.Tables.Contains(nomTable)) continue;
                try
                {
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(
                        $"SELECT * FROM {nomTable}", Connexion.Connec
                    );
                    adapter.Fill(ds, nomTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur chargement {nomTable} : {ex.Message}");
                }
            }
            Connexion.FermerConnexion();
        }

        // ─── AFFICHAGE DES ALIENS ──────────────────────────────────────────

        private void AfficherAliensFiltre()
        {
            flpAliens.Controls.Clear();

            DataTable dtEspece = MesDatas.DsGlobal.Tables["Espece"];
            DataTable dtAllie = MesDatas.DsGlobal.Tables["Allie"];
            DataTable dtEnnemi = MesDatas.DsGlobal.Tables["Ennemi"];

            foreach (DataRow row in dtEspece.Rows)
            {
                int id = Convert.ToInt32(row["id"]);
                string nom = row["nom"].ToString();
                string couleur = row["couleur"].ToString();

                // Déterminer le type
                string type = "Inconnu";
                if (dtAllie.Select($"idEspece = {id}").Length > 0)
                    type = "Allié";
                else if (dtEnnemi.Select($"idEspece = {id}").Length > 0)
                    type = "Ennemi";

                // Filtre type
                if (_filtreType != "Tous" && type != _filtreType)
                    continue;

                // Filtre nom — contient les caractères saisis
                if (_filtreNom != "" && nom.IndexOf(_filtreNom, StringComparison.OrdinalIgnoreCase) < 0)
                    continue;

                // Filtre couleur
                if (_filtreCouleur != "" && !couleur.Equals(_filtreCouleur, StringComparison.OrdinalIgnoreCase))
                    continue;

                // Chemin image
                string cheminImage = File.Exists(
                Path.Combine(Application.StartupPath, "images", nom + ".png"))
                    ? Path.Combine(Application.StartupPath, "images", nom + ".png")
                    : Path.Combine(Application.StartupPath, "images", nom + ".jpg");

                // Création du UC
                UCAlien uc = new UCAlien(nom, couleur, type, cheminImage);
                uc.Width = 150;
                uc.Height = 200;
                uc.Margin = new System.Windows.Forms.Padding(10);
                uc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

                flpAliens.Controls.Add(uc);
            }

            // Aucun résultat
            if (flpAliens.Controls.Count == 0)
            {
                Label lblVide = new Label();
                lblVide.Text = "Aucun alien trouvé.";
                lblVide.Font = new Font("Arial", 12, FontStyle.Bold);
                lblVide.ForeColor = Color.Gray;
                lblVide.AutoSize = true;
                lblVide.Margin = new System.Windows.Forms.Padding(20);
                flpAliens.Controls.Add(lblVide);
            }
        }

        // ─── BOUTONS FILTRES TYPE ──────────────────────────────────────────

        private void btnTous_Click(object sender, EventArgs e)
        {
            _filtreType = "Tous";
            StylerBoutons(btnTous);
            AfficherAliensFiltre();
        }

        private void btnAllies_Click(object sender, EventArgs e)
        {
            _filtreType = "Allié";
            StylerBoutons(btnAllies);
            AfficherAliensFiltre();
        }

        private void btnEnnemis_Click(object sender, EventArgs e)
        {
            _filtreType = "Ennemi";
            StylerBoutons(btnEnnemis);
            AfficherAliensFiltre();
        }

        
        private void StylerBoutons(Button btnActif)
        {
            Button[] boutons = { btnTous, btnAllies, btnEnnemis };
            foreach (Button btn in boutons)
            {
                btn.BackColor = Color.FromArgb(44, 62, 80);
                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
            }
            // Bouton actif en surbrillance
            btnActif.BackColor = Color.FromArgb(52, 152, 219);
        }

        // ─── MÉTHODE APPELÉE PAR UCFiltres ────────────────────────────────

        public void AppliquerFiltres(string nom, string couleur)
        {
            _filtreNom = nom;
            _filtreCouleur = couleur;
            AfficherAliensFiltre();
        }

        // ─── RETOUR ───────────────────────────────────────────────────────

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

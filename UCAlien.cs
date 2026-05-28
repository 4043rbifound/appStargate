using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appStargate
{
    public partial class UCAlien : UserControl
    {
        // Délégué pour le clic
        public delegate void AfficherDetailAlien(object sender, EventArgs e);
        public AfficherDetailAlien afficheurDetail;

        // Propriétés publiques
        public string NomAlien { get { return lblNom.Text; } }
        public string TypeAlien { get { return lblType.Text; } }
        public string CouleurAlien { get { return lblCouleur.Text; } }

        // Constructeur par défaut pour le designer
        public UCAlien()
        {
            InitializeComponent();
        }

        // Constructeur surchargé
        public UCAlien(string nom, string couleur, string type, string cheminImage)
        {
            InitializeComponent();

            lblNom.Text = nom;
            lblCouleur.Text = couleur;
            lblType.Text = type;

            // Couleur selon le type
            if (type == "Allié")
                lblType.ForeColor = Color.Green;
            else if (type == "Ennemi")
                lblType.ForeColor = Color.Red;
            else
                lblType.ForeColor = Color.Gray;

            // Chargement image
            try
            {
                pbAlien.Image = Image.FromFile(cheminImage);
            }
            catch
            {
                // Pas d'image, on laisse vide
            }

            this.Cursor = Cursors.Hand;
            BrancherClics();
        }

        private void BrancherClics()
        {
            this.Click += UCAlien_Click;
            pbAlien.Click += UCAlien_Click;
            lblNom.Click += UCAlien_Click;
            lblCouleur.Click += UCAlien_Click;
            lblType.Click += UCAlien_Click;
        }

        private void UCAlien_Click(object sender, EventArgs e)
        {
            if (afficheurDetail != null)
                afficheurDetail(this, e);
        }
    }
}

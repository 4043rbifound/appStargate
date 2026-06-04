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
    public partial class UCPlanete : UserControl
    {
        // Constructeur par défaut — nécessaire pour le designer Visual Studio
        public UCPlanete()
        {
            InitializeComponent();
        }

        // Délégué : on délègue le clic au formulaire parent
        public delegate void AfficherDetailPlanete(object sender, EventArgs e);
        public AfficherDetailPlanete afficheurDetail;

        // Propriété pour récupérer le nom de la planète depuis le formulaire parent
        public string NomPlanete { get { return lblNom.Text; } }

        
        public UCPlanete(string nom, int temperature, double gravite, bool databazON, string cheminImage)
        {
            InitializeComponent();
            // Remplissage des labels
            lblNom.Text = nom;
            lblTemp.Text = $"Température : {temperature}°";
            lblGravite.Text = $"Gravité : {gravite}";

            if (databazON)
            {
                lblDatabaz.Text = "Présence de Databaz";
                lblDatabaz.ForeColor = Color.Green;
            }
            else
            {
                lblDatabaz.Text = "Pas de Databaz";
                lblDatabaz.ForeColor = Color.Red;
            }

            // Chargement de l'image
            try
            {
                pbPlanete.Image = Image.FromFile(cheminImage);
            }
            catch
            {
                // Pas d'image disponible, on laisse vide sans planter
            }

            // Curseur main pour montrer que c'est cliquable
            this.Cursor = Cursors.Hand;

            // On branche le clic sur tous les sous-contrôles
            BrancherClics();
        }

        
        private void BrancherClics()
        {
            this.Click += UCPlanete_Click;
            pbPlanete.Click += UCPlanete_Click;
            lblNom.Click += UCPlanete_Click;
            lblTemp.Click += UCPlanete_Click;
            lblGravite.Click += UCPlanete_Click;
            lblDatabaz.Click += UCPlanete_Click;            
        }

        
        private void UCPlanete_Click(object sender, EventArgs e)
        {
            if (afficheurDetail != null)
                afficheurDetail(this, e);
        }
        

        private void UCPlanete_Load(object sender, EventArgs e)
        {
        }

    }
}

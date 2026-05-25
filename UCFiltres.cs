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
    public partial class UCFiltres : UserControl
    {
        // Référence vers le FormRaces pour appeler AppliquerFiltres
        private FormRaces _formRaces;

        // Constructeur par défaut pour le designer
        public UCFiltres()
        {
            InitializeComponent();
        }

        // Constructeur surchargé avec référence au formulaire parent
        public UCFiltres(FormRaces formRaces)
        {
            InitializeComponent();
            _formRaces = formRaces;
        }

        /// <summary>
        /// Quand on clique sur la loupe, on envoie les filtres au FormRaces
        /// </summary>
        private void btnFiltrer_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text.Trim();
            string couleur = txtCouleur.Text.Trim();

            _formRaces.AppliquerFiltres(nom, couleur);
        }
    }
}

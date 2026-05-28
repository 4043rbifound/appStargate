using appliPandora;
using System;
using System.Data;
using System.Windows.Forms;

namespace appStargate
{
    public partial class UCFiltres : UserControl
    {
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

            ChargerCouleurs();

            // Filtre en temps réel
            txtNom.TextChanged += (s, e) => AppliquerFiltres();
            CboCouleur.SelectedIndexChanged += (s, e) => AppliquerFiltres();
        }

        /// <summary>
        /// Charge les couleurs distinctes depuis le DataSet dans le ComboBox
        /// </summary>
        private void ChargerCouleurs()
        {
            CboCouleur.Items.Clear();
            CboCouleur.Items.Add("Toutes");
            CboCouleur.SelectedIndex = 0;

            DataTable dtEspece = MesDatas.DsGlobal.Tables["Espece"];
            if (dtEspece == null) return;

            foreach (DataRow row in dtEspece.Rows)
            {
                string couleur = row["couleur"].ToString();
                if (!CboCouleur.Items.Contains(couleur))
                    CboCouleur.Items.Add(couleur);
            }
        }

        private void AppliquerFiltres()
        {
            if (_formRaces == null) return;

            string nom = txtNom.Text.Trim();
            string couleur = CboCouleur.SelectedIndex <= 0 ? "" : CboCouleur.SelectedItem.ToString();

            _formRaces.AppliquerFiltres(nom, couleur);
        }
    }
}
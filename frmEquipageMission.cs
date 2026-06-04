using appliPandora;
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

namespace appStargate
{
    public partial class frmEquipageMission : Form
    {
        // Données reçues du formulaire précédent
        private int _numeroMission;
        private string _nomPlanete;
        private int _nbMembresRequis;
        private int _placesRestantes;

        private bool _membresValides = false;
        private bool _objectifsValides = false;

        // Constructeur qui reçoit les paramètres de formNouvelleMission
        public frmEquipageMission(int numero, string planete, int nbMembre)
        {
            InitializeComponent();
            this._numeroMission = numero;
            this._nomPlanete = planete;
            this._nbMembresRequis = nbMembre;
            this._placesRestantes = nbMembre;
        }

        private void frmEquipageMission_Load(object sender, EventArgs e)
        {
            // Initialisation du compteur visuel
            lblNbMembreaffecter.Text = _placesRestantes.ToString();

            // Paramétrage du champ quantité
            txtQuantiteAlien.KeyPress += BloquerLettres_KeyPress;
            txtQuantiteAlien.Text = "1";

            // Nettoyage des zones de texte
            richtxtMembres.Clear();
            richtxtAliens.Clear();

            // Chargement des listes déroulantes
            ChargerMembresDisponibles();
            ChargerEspecesAliens();
        }

        private void ChargerMembresDisponibles()
        {
            try
            {
                string dateAujourdhui = DateTime.Today.ToString("yyyy-MM-dd");
                string requete = "SELECT M.matricule, M.nom, M.prenom, " +
                                 "CASE WHEN MI.grade IS NOT NULL THEN MI.grade ELSE 'Civil : ' || C.Specialite END as Statut " +
                                 "FROM Membre M " +
                                 "LEFT JOIN Militaire MI ON M.matricule = MI.matriculeMembre " +
                                 "LEFT JOIN Civil C ON M.matricule = C.matriculeMembre " +
                                 "WHERE M.matricule NOT IN (" +
                                 "    SELECT matriculeChef FROM Mission WHERE dateDepart <= @auj AND dateRetour >= @auj " +
                                 "    UNION " +
                                 "    SELECT matriculeMembre FROM Composer WHERE nomPlanete IN (SELECT nomPlanete FROM Mission WHERE dateDepart <= @auj AND dateRetour >= @auj) " +
                                 "    AND numeroMission IN (SELECT numero FROM Mission WHERE dateDepart <= @auj AND dateRetour >= @auj)" +
                                 ") ORDER BY M.nom, M.prenom";

                SQLiteCommand cmd = new SQLiteCommand(requete, Connexion.Connec);
                cmd.Parameters.AddWithValue("@auj", dateAujourdhui);

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    cboMembres.Items.Clear();
                    while (reader.Read())
                    {
                        string affichage = $"{reader["nom"]} {reader["prenom"]} - {reader["Statut"]} - {reader["matricule"]}";
                        cboMembres.Items.Add(affichage);
                    }
                }
            }
            catch (Exception ex)
            {
                AfficherNotif("Erreur chargement membres : " + ex.Message);
            }
        }

        private void ChargerEspecesAliens()
        {
            try
            {
                string requete = "SELECT E.id, E.nom, E.couleur FROM Espece E " +
                                 "INNER JOIN Ennemi EN ON E.id = EN.idEspece ORDER BY E.nom ASC";

                SQLiteCommand cmd = new SQLiteCommand(requete, Connexion.Connec);
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    cboAliens.Items.Clear();
                    while (reader.Read())
                    {
                        string affichage = $"{reader["nom"]} - {reader["couleur"]} - {reader["id"]}";
                        cboAliens.Items.Add(affichage);
                    }
                }
            }
            catch (Exception ex)
            {
                AfficherNotif("Erreur chargement espèces : " + ex.Message);
            }
        }

        private void BloquerLettres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ExecuterAjoutMembre()
        {
            if (cboMembres.SelectedIndex == -1)
            {
                AfficherNotif("Veuillez sélectionner un membre.");
                return;
            }

            if (_placesRestantes <= 0)
            {
                AfficherNotif("L'équipage est déjà complet pour cette mission !");
                return;
            }

            string ligneSelectionnee = cboMembres.SelectedItem.ToString();
            string[] fragments = ligneSelectionnee.Split('-');
            string matricule = fragments.Last().Trim();

            using (SQLiteTransaction transaction = Connexion.Connec.BeginTransaction())
            {
                try
                {
                    string requete = "INSERT INTO Composer (nomPlanete, numeroMission, matriculeMembre) VALUES (@planete, @num, @matricule)";
                    using (SQLiteCommand cmd = new SQLiteCommand(requete, Connexion.Connec, transaction))
                    {
                        cmd.Parameters.AddWithValue("@planete", _nomPlanete);
                        cmd.Parameters.AddWithValue("@num", _numeroMission);
                        cmd.Parameters.AddWithValue("@matricule", matricule);
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    _placesRestantes--;
                    lblNbMembreaffecter.Text = _placesRestantes.ToString();

                    string nomPrenom = fragments[0].Trim();
                    string statut = fragments[1].Trim();
                    richtxtMembres.AppendText($"{nomPrenom} - {statut}\n");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    AfficherNotif("Ce membre est déjà affecté à cette mission.");
                }
            }
        }

        private void btnAjouterMembre_Click(object sender, EventArgs e) { ExecuterAjoutMembre(); }
        private void btnAjouterMembre_Click_1(object sender, EventArgs e) { ExecuterAjoutMembre(); }

        private void ExecuterValiderMembres()
        {
            cboMembres.Enabled = false;
            btnAjouterMembre.Enabled = false;

            _membresValides = true;
            AfficherNotif("Section membres validée et verrouillée !", true);

            VérifierFermetureFormulaire();
        }

        // On redirige TOUS les clics possibles vers ExecuterValiderMembres()
        private void btnValiderMembres_Click(object sender, EventArgs e) { ExecuterValiderMembres(); }
        private void btnValiderMembres_Click_1(object sender, EventArgs e) { ExecuterValiderMembres(); }
        private void btnValiderMembres_Click_2(object sender, EventArgs e) { ExecuterValiderMembres(); }

        private void ExecuterAjoutAlien()
        {
            if (cboAliens.SelectedIndex == -1)
            {
                AfficherNotif("Veuillez sélectionner une espèce d'alien.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtQuantiteAlien.Text) || Convert.ToInt32(txtQuantiteAlien.Text) <= 0)
            {
                AfficherNotif("La quantité doit être supérieure à 0.");
                return;
            }

            string ligneSelectionnee = cboAliens.SelectedItem.ToString();
            string[] fragments = ligneSelectionnee.Split('-');
            int idEspece = Convert.ToInt32(fragments.Last().Trim());
            int quantite = Convert.ToInt32(txtQuantiteAlien.Text);

            using (SQLiteTransaction transaction = Connexion.Connec.BeginTransaction())
            {
                try
                {
                    string requete = "INSERT INTO ObjectifCapture (nomPlanete, numeroMission, idEspeceEnnemi, objectif) VALUES (@planete, @num, @idEspece, @objectif)";
                    using (SQLiteCommand cmd = new SQLiteCommand(requete, Connexion.Connec, transaction))
                    {
                        cmd.Parameters.AddWithValue("@planete", _nomPlanete);
                        cmd.Parameters.AddWithValue("@num", _numeroMission);
                        cmd.Parameters.AddWithValue("@idEspece", idEspece);
                        cmd.Parameters.AddWithValue("@objectif", quantite);
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    string nomAlien = fragments[0].Trim();
                    string couleur = fragments[1].Trim();
                    richtxtAliens.AppendText($"{nomAlien} - {couleur} --> objectif de captures : {quantite}\n");

                    txtQuantiteAlien.Text = "1";
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    AfficherNotif("Cet objectif existe déjà pour cette mission.");
                }
            }
        }

        private void btnAjouterAlien_Click(object sender, EventArgs e) { ExecuterAjoutAlien(); }
        private void btnAjouterAlien_Click_1(object sender, EventArgs e) { ExecuterAjoutAlien(); }
        private void btnAjouterAlien_Click_2(object sender, EventArgs e) { ExecuterAjoutAlien(); }

        private void ExecuterValiderObjectifs()
        {
            cboAliens.Enabled = false;
            txtQuantiteAlien.Enabled = false;
            btnAjouterAlien.Enabled = false;

            _objectifsValides = true;
            AfficherNotif("Section objectifs validée et verrouillée !", true);

            VérifierFermetureFormulaire();
        }

        private void btnValiderObjectifs_Click(object sender, EventArgs e) { ExecuterValiderObjectifs(); }
        private void btnValiderObjectifs_Click_1(object sender, EventArgs e) { ExecuterValiderObjectifs(); }

        private void VérifierFermetureFormulaire()
        {
            if (_membresValides && _objectifsValides)
            {
                AfficherNotif("Validation en cours...", true);

                Timer timerFermeture = new Timer();
                timerFermeture.Interval = 1500;
                timerFermeture.Tick += (s, ev) =>
                {
                    timerFermeture.Stop();
                    timerFermeture.Dispose();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                };
                timerFermeture.Start();
            }
        }

        private void cboMembres_SelectedIndexChanged(object sender, EventArgs e) { }

        private List<Panel> _notifs = new List<Panel>();

        private void AfficherNotif(string message, bool isSuccess = false)
        {
            Panel notif = new Panel();
            notif.Size = new Size(380, 60);
            notif.BackColor = isSuccess ? Color.FromArgb(39, 174, 96) : Color.FromArgb(192, 57, 43);

            Label lbl = new Label();
            lbl.Text = message;
            lbl.Dock = DockStyle.Fill;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.ForeColor = Color.White;
            lbl.Font = new Font("Arial", 9.5F, FontStyle.Bold);
            notif.Controls.Add(lbl);

            int posY = 20 + (_notifs.Count * 70);
            notif.Location = new Point(-notif.Width, posY);

            this.Controls.Add(notif);
            notif.BringToFront();
            _notifs.Add(notif);

            AnimerEntree(notif, 20, posY);
        }

        private void AnimerEntree(Panel notif, int cibleX, int posY)
        {
            Timer timerEntree = new Timer();
            timerEntree.Interval = 5;
            timerEntree.Tick += (s, ev) =>
            {
                if (notif.Left < cibleX)
                {
                    int pas = Math.Max(2, (cibleX - notif.Left) / 4);
                    notif.Left += pas;
                }
                else
                {
                    notif.Left = cibleX;
                    timerEntree.Stop();
                    timerEntree.Dispose();

                    Timer timerAttente = new Timer();
                    timerAttente.Interval = 2500;
                    timerAttente.Tick += (s2, ev2) =>
                    {
                        timerAttente.Stop();
                        timerAttente.Dispose();
                        AnimerSortie(notif);
                    };
                    timerAttente.Start();
                }
            };
            timerEntree.Start();
        }

        private void AnimerSortie(Panel notif)
        {
            Timer timerSortie = new Timer();
            timerSortie.Interval = 5;
            timerSortie.Tick += (s, ev) =>
            {
                if (notif.Left > -notif.Width)
                {
                    int pas = Math.Max(2, (notif.Left + notif.Width) / 4);
                    notif.Left -= pas;
                }
                else
                {
                    timerSortie.Stop();
                    timerSortie.Dispose();
                    _notifs.Remove(notif);
                    this.Controls.Remove(notif);
                    notif.Dispose();
                    ReorganiserNotifs();
                }
            };
            timerSortie.Start();
        }

        private void ReorganiserNotifs()
        {
            for (int i = 0; i < _notifs.Count; i++)
            {
                int cibleY = 20 + (i * 70);
                Panel notif = _notifs[i];

                Timer timerReorg = new Timer();
                timerReorg.Interval = 5;
                timerReorg.Tick += (s, ev) =>
                {
                    if (notif.Top != cibleY)
                    {
                        int pas = Math.Max(1, Math.Abs(notif.Top - cibleY) / 4);
                        if (notif.Top > cibleY) notif.Top -= pas;
                        else notif.Top += pas;
                    }
                    else
                    {
                        timerReorg.Stop();
                        timerReorg.Dispose();
                    }
                };
                timerReorg.Start();
            }
        }
    }
}
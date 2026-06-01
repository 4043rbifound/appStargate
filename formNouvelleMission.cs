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
    public partial class formNouvelleMission : Form
    {
        public formNouvelleMission()
        {
            InitializeComponent();
        }

        private void formNouvelleMission_Load(object sender, EventArgs e)
        {
            dtpDepart.Value = DateTime.Today;
            dtpRetour.Value = DateTime.Today;
            try
            {
                string requete = "SELECT nom FROM Planete ORDER BY nom ASC";
                SQLiteCommand cmd = new SQLiteCommand(requete, Connexion.Connec);

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    cboPlanete.Items.Clear();
                    while (reader.Read())
                    {
                        cboPlanete.Items.Add(reader["nom"].ToString());
                    }
                }
                ChargerChefsMilitaires();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur au chargement des planètes : " + ex.Message);
            }
            txtBudget.KeyPress += BloquerLettres_KeyPress;
            txtNbMembre.KeyPress += BloquerLettres_KeyPress;
            txtObjectifDataBaz.KeyPress += BloquerLettres_KeyPress;
        }
        private void ChargerChefsMilitaires()
        {
            try
            {
                string dateAujourdhui = DateTime.Today.ToString("yyyy-MM-dd");

                string requete = "SELECT M.matricule, M.nom, M.prenom, MI.grade " +
                                 "FROM Membre M " +
                                 "INNER JOIN Militaire MI ON M.matricule = MI.matriculeMembre " +
                                 "WHERE M.matricule NOT IN (" +
                                 "    SELECT matriculeChef FROM Mission " +
                                 "    WHERE dateDepart <= @aujourdhui AND dateRetour >= @aujourdhui" +
                                 ") " +
                                 "ORDER BY M.nom, M.prenom";

                SQLiteCommand cmd = new SQLiteCommand(requete, Connexion.Connec);
                cmd.Parameters.AddWithValue("@aujourdhui", dateAujourdhui);

                SQLiteDataReader reader = cmd.ExecuteReader();

                cboChefMission.Items.Clear();

                while (reader.Read())
                {
                    // On affiche le nom, prénom et grade de manière classique
                    string affichage = $"{reader["nom"]} {reader["prenom"]} - {reader["grade"]}";
                    cboChefMission.Items.Add(affichage);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                AfficherNotif("Erreur filtrage chefs : " + ex.Message);
            }
        }
        private void BloquerLettres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void lblNom_Click(object sender, EventArgs e)
        {

        }

        private void cboPlanete_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNbMembre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void grpNouvelleMission_Enter(object sender, EventArgs e)
        {

        }

        private void btnValiderPlanete_Click(object sender, EventArgs e)
        {
            // on vérifie qu'une planete est selectionnée
            if (cboPlanete.SelectedIndex == -1)
            {
                AfficherNotif("Veuillez d'abord choisir une planète.");
                return;
            }

            string planeteChoisie = cboPlanete.SelectedItem.ToString();

            try
            {
                // on compte nb mission pour la planete 
                string requete = "SELECT COUNT(*) FROM Mission WHERE nomPlanete = @planete";

                SQLiteCommand cmd = new SQLiteCommand(requete, Connexion.Connec);
                cmd.Parameters.AddWithValue("@planete", planeteChoisie);

                int nbMissionsPrecedentes = Convert.ToInt32(cmd.ExecuteScalar());
                int numNouvelleMission = nbMissionsPrecedentes + 1;

                // maj des lbl
                lblNomDeMission.Text = planeteChoisie;
                lblNumMission.Text = numNouvelleMission.ToString();


                // on bloque tout
                cboPlanete.Enabled = false;

                btnValiderPlanete.Enabled = false;

                btnValiderPlanete.BackColor = Color.DarkGray;

            }
            catch (Exception ex)
            {
                AfficherNotif("Erreur SQL : " + ex.Message);
            }
        }






        private void btnValiderMission_Click(object sender, EventArgs e)
        {
            // verif champ 
            if (cboPlanete.SelectedIndex == -1) { AfficherNotif("Sélectionnez et validez d'abord une planète."); return; }
            if (cboChefMission.SelectedIndex == -1) { AfficherNotif("Sélectionnez un chef de mission."); return; }
            if (string.IsNullOrWhiteSpace(richtxtFeuilleRoute.Text)) { AfficherNotif("La feuille de route ne peut pas être vide."); return; }
            if (string.IsNullOrWhiteSpace(txtBudget.Text)) { AfficherNotif("Veuillez indiquer un budget."); return; }
            if (string.IsNullOrWhiteSpace(txtNbMembre.Text)) { AfficherNotif("Veuillez indiquer le nombre de membres."); return; }
            if (string.IsNullOrWhiteSpace(txtObjectifDataBaz.Text)) { AfficherNotif("Veuillez indiquer l'objectif DataBaz."); return; }
            if(dtpDepart.Value >= dtpRetour.Value) { AfficherNotif("La date de départ doit être antérieure à la date de retour."); return; }


            try
            {
                // on récupère la ligne complète de la ComboBox
                string texteSelectionne = cboChefMission.SelectedItem.ToString();

                // On sépare la partie Identité et la partie Grade en coupant au niveau du tiret "-"
                string identite = texteSelectionne.Split('-')[0].Trim();

                // On sépare le Nom et le Prénom en coupant au niveau de l'espace
                string nomChef = identite.Split(' ')[0].Trim();
                string prenomChef = identite.Split(' ')[1].Trim();

                string reqMatricule = "SELECT matricule FROM Membre WHERE nom = @nom AND prenom = @prenom";
                SQLiteCommand cmdMatricule = new SQLiteCommand(reqMatricule, Connexion.Connec);
                cmdMatricule.Parameters.AddWithValue("@nom", nomChef);
                cmdMatricule.Parameters.AddWithValue("@prenom", prenomChef);

                object resultat = cmdMatricule.ExecuteScalar();

                if (resultat == null || resultat == DBNull.Value)
                {
                    AfficherNotif($"BDD: Aucun matricule pour Nom='{nomChef}' et Prénom='{prenomChef}'");
                    return; 
                }

                string matriculeChef = resultat.ToString();

                // insertion  
                string requeteInsertion = "INSERT INTO Mission (numero, nomPlanete, dateDepart, dateRetour, feuilleDeRoute, budget, nbMembreRequis, objectifDataBaz, matriculeChef) " +
                                                  "VALUES (@num, @planete, @depart, @retour, @route, @budget, @membres, @databaz, @matriculeChef)";
                SQLiteCommand cmd = new SQLiteCommand(requeteInsertion, Connexion.Connec);

                cmd.Parameters.AddWithValue("@planete", lblNomDeMission.Text);
                cmd.Parameters.AddWithValue("@depart", dtpDepart.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@retour", dtpRetour.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@route", richtxtFeuilleRoute.Text);
                cmd.Parameters.AddWithValue("@budget", Convert.ToInt32(txtBudget.Text));
                cmd.Parameters.AddWithValue("@membres", Convert.ToInt32(txtNbMembre.Text));
                cmd.Parameters.AddWithValue("@databaz", Convert.ToInt32(txtObjectifDataBaz.Text));
                cmd.Parameters.AddWithValue("@matriculeChef", matriculeChef);
                cmd.Parameters.AddWithValue("@num", Convert.ToInt32(lblNumMission.Text));

                cmd.ExecuteNonQuery();


                AfficherNotif("Insertion de la mission en cours...", Color.FromArgb(39, 174, 96));
                // création d'un timer 
                Timer timerTransition = new Timer();
                timerTransition.Interval = 1500; // 1500 millisecondes = 1,5 seconde

                timerTransition.Tick += (s, ev) =>
                {
                    // se délcenceh au bout de 1.5 seconde
                    timerTransition.Stop();  // arrete le timer    
                    timerTransition.Dispose();   // libere la mémoire


                    string planeteMission = lblNomDeMission.Text;
                    frmEquipageMission frmEquipage = new frmEquipageMission(Convert.ToInt32(lblNumMission.Text), planeteMission, Convert.ToInt32(txtNbMembre.Text));

                    this.Hide();
                    frmEquipage.ShowDialog();
                    this.Close();
                };
                timerTransition.Start(); 
            }
            catch (Exception ex)
            {
                AfficherNotif("Erreur lors de l'enregistrement : " + ex.Message);
            }
        } 
// Une liste globale qui sert à stocker toutes les notifications actuellement affichées à l'écran
private List<Panel> _notifs = new List<Panel>();

        // Méthode principale pour créer et afficher graphiquement une nouvelle notification
        // On ajoute le paramètre 'couleurFond'. Si on ne le précise pas, il prend le rouge par défaut.
        private void AfficherNotif(string message, Color? couleurFond = null)
        {
            Panel notif = new Panel();
            notif.Size = new Size(350, 60);

            // Si aucune couleur n'est fournie, on applique ton rouge foncé élégant par défaut
            // Sinon, on applique la couleur demandée
            notif.BackColor = couleurFond ?? Color.FromArgb(192, 57, 43);

            Label lbl = new Label();
            lbl.Text = message;
            lbl.Dock = DockStyle.Fill;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.ForeColor = Color.White;
            lbl.Font = new Font("Arial", 10, FontStyle.Bold);
            notif.Controls.Add(lbl);

            int posY = 20 + (_notifs.Count * 70);
            notif.Location = new Point(-notif.Width, posY);

            this.Controls.Add(notif);
            notif.BringToFront();
            _notifs.Add(notif);

            AnimerEntree(notif, 20, posY);
        }

        // Méthode qui gère l'apparition animée (glissement de la gauche vers la droite)
        private void AnimerEntree(Panel notif, int cibleX, int posY)
        {
            // On crée un outil de chrono (Timer) pour répéter une action à intervalles réguliers
            Timer timerEntree = new Timer();
            // On règle l'intervalle à 5 millisecondes (le chrono va "biper" très vite pour une animation fluide)
            timerEntree.Interval = 5;
            // On définit l'action qui s'exécute à chaque "bip" du chrono (événement Tick)
            timerEntree.Tick += (s, ev) =>
            {
                // TANT QUE la notification n'a pas atteint sa position X finale (20 pixels du bord gauche)
                if (notif.Left < cibleX)
                {
                    // On calcule un "pas" de déplacement dynamique pour créer un effet d'amorti (ralentissement à la fin)
                    int pas = Math.Max(2, (cibleX - notif.Left) / 4);
                    // On déplace la notification vers la droite en ajoutant ce pas à sa coordonnée X (Left)
                    notif.Left += pas;
                }
                else // SINON (la notification est bien arrivée à sa place cibleX)
                {
                    // On la cale pile poil sur sa position cible
                    notif.Left = cibleX;
                    // On arrête le chrono de déplacement
                    timerEntree.Stop();
                    // On détruit le chrono de déplacement pour libérer la mémoire du PC
                    timerEntree.Dispose();

                    // On crée un DEUXIÈME chrono qui va servir de compte à rebours avant de faire disparaître la notif
                    Timer timerAttente = new Timer();
                    // On règle le temps d'affichage à 2500 millisecondes (2,5 secondes d'attente à l'écran)
                    timerAttente.Interval = 2500;
                    // Action à la fin des 2,5 secondes :
                    timerAttente.Tick += (s2, ev2) =>
                    {
                        // On arrête le chrono d'attente
                        timerAttente.Stop();
                        // On détruit le chrono d'attente
                        timerAttente.Dispose();
                        // On lance la méthode pour faire repartir la notification vers la gauche
                        AnimerSortie(notif);
                    };
                    // On démarre le compte à rebours des 2,5 secondes
                    timerAttente.Start();
                }
            };
            // On démarre immédiatement le chrono de déplacement initial
            timerEntree.Start();
        }

        // Méthode qui gère la disparition animée (glissement de la droite vers la gauche)
        private void AnimerSortie(Panel notif)
        {
            // On crée un nouveau chrono pour l'animation de sortie
            Timer timerSortie = new Timer();
            // Vitesse du chrono fixée à 5 millisecondes
            timerSortie.Interval = 5;
            // Action exécutée à chaque "bip" du chrono :
            timerSortie.Tick += (s, ev) =>
            {
                // TANT QUE la notification n'est pas entièrement sortie de l'écran par la gauche
                if (notif.Left > -notif.Width)
                {
                    // On calcule un pas dynamique pour créer l'effet d'amorti de sortie
                    int pas = Math.Max(2, (notif.Left + notif.Width) / 4);
                    // On recule la notification vers la gauche en soustrayant le pas à sa coordonnée X
                    notif.Left -= pas;
                }
                else // SINON (la notification est totalement invisible, hors écran)
                {
                    // On stoppe le chrono de sortie
                    timerSortie.Stop();
                    // On détruit le chrono de sortie
                    timerSortie.Dispose();
                    // On supprime la notification de notre liste globale
                    _notifs.Remove(notif);
                    // On retire définitivement le composant Panel de l'affichage du formulaire
                    this.Controls.Remove(notif);
                    // On détruit proprement le Panel pour libérer la mémoire RAM
                    notif.Dispose();
                    // On appelle la fonction pour faire remonter les autres notifications restantes s'il y en a
                    ReorganiserNotifs();
                }
            };
            // On démarre le chrono de sortie
            timerSortie.Start();
        }

        // Méthode qui gère le déplacement vertical des notifications restantes pour boucher les "trous"
        private void ReorganiserNotifs()
        {
            // On parcourt toute la liste des notifications restantes à l'aide d'une boucle
            for (int i = 0; i < _notifs.Count; i++)
            {
                // On recalcule sa nouvelle position Y théorique en fonction de son nouvel index 'i' dans la liste
                int cibleY = 20 + (i * 70);
                // On récupère la notification courante ciblée par la boucle
                Panel notif = _notifs[i];

                // On crée un chrono dédié pour animer la montée ou la descente de cette notification spécifique
                Timer timerReorg = new Timer();
                // Vitesse du chrono fixée à 5 millisecondes pour un glissement fluide
                timerReorg.Interval = 5;
                // Action exécutée à chaque "bip" de ce chrono :
                timerReorg.Tick += (s, ev) =>
                {
                    // SI la position du haut du panel (Top) n'est pas encore égale à la position cible calculée
                    if (notif.Top != cibleY)
                    {
                        // On calcule l'écart restant à parcourir avec une valeur absolue (Math.Abs) divisée par 4 pour l'effet d'amorti
                        int pas = Math.Max(1, Math.Abs(notif.Top - cibleY) / 4);
                        // SI la notification est trop basse (Top plus grand que cibleY), on la fait remonter en soustrayant le pas
                        if (notif.Top > cibleY) notif.Top -= pas;
                        // SINON (elle est trop haute), on la fait descendre en ajoutant le pas
                        else notif.Top += pas;
                    }
                    else // SINON (la notification est parfaitement arrivée à sa nouvelle hauteur cible)
                    {
                        // On arrête le chrono de réorganisation pour cette notification
                        timerReorg.Stop(); 
                        // On détruit le chrono pour libérer la mémoire
                        timerReorg.Dispose();
                    }
                };
                // On démarre le chrono de réorganisation pour lancer l'ajustement visuel
                timerReorg.Start();
            }
        }

        private void lblNomDeMission_Click(object sender, EventArgs e)
        {

        }
    }
}
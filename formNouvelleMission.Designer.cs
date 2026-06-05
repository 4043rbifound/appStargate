namespace appStargate
{
    partial class formNouvelleMission
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTonne = new System.Windows.Forms.Label();
            this.lblDollard = new System.Windows.Forms.Label();
            this.txtBudget = new System.Windows.Forms.TextBox();
            this.txtObjectifDataBaz = new System.Windows.Forms.TextBox();
            this.txtNbMembre = new System.Windows.Forms.TextBox();
            this.lblBudget = new System.Windows.Forms.Label();
            this.lblObjectifDB = new System.Windows.Forms.Label();
            this.lblNombreMembre = new System.Windows.Forms.Label();
            this.btnValiderMission = new System.Windows.Forms.Button();
            this.lblChoixPlanete = new System.Windows.Forms.Label();
            this.cboPlanete = new System.Windows.Forms.ComboBox();
            this.btnValiderPlanete = new System.Windows.Forms.Button();
            this.lblMission = new System.Windows.Forms.Label();
            this.lblNomDeMission = new System.Windows.Forms.Label();
            this.lblNumMission = new System.Windows.Forms.Label();
            this.lblChoixChefMission = new System.Windows.Forms.Label();
            this.cboChefMission = new System.Windows.Forms.ComboBox();
            this.lblDateDepart = new System.Windows.Forms.Label();
            this.lblDateRetour = new System.Windows.Forms.Label();
            this.dtpDepart = new System.Windows.Forms.DateTimePicker();
            this.dtpRetour = new System.Windows.Forms.DateTimePicker();
            this.lblFeuilleRoute = new System.Windows.Forms.Label();
            this.richtxtFeuilleRoute = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCreerNewMission = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTonne
            // 
            this.lblTonne.AutoSize = true;
            this.lblTonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTonne.Location = new System.Drawing.Point(982, 610);
            this.lblTonne.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTonne.Name = "lblTonne";
            this.lblTonne.Size = new System.Drawing.Size(85, 29);
            this.lblTonne.TabIndex = 21;
            this.lblTonne.Text = "tonnes";
            // 
            // lblDollard
            // 
            this.lblDollard.AutoSize = true;
            this.lblDollard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDollard.Location = new System.Drawing.Point(982, 661);
            this.lblDollard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDollard.Name = "lblDollard";
            this.lblDollard.Size = new System.Drawing.Size(26, 29);
            this.lblDollard.TabIndex = 20;
            this.lblDollard.Text = "$";
            this.lblDollard.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBudget
            // 
            this.txtBudget.Location = new System.Drawing.Point(875, 661);
            this.txtBudget.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBudget.Name = "txtBudget";
            this.txtBudget.Size = new System.Drawing.Size(83, 26);
            this.txtBudget.TabIndex = 19;
            // 
            // txtObjectifDataBaz
            // 
            this.txtObjectifDataBaz.Location = new System.Drawing.Point(875, 605);
            this.txtObjectifDataBaz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtObjectifDataBaz.Name = "txtObjectifDataBaz";
            this.txtObjectifDataBaz.Size = new System.Drawing.Size(83, 26);
            this.txtObjectifDataBaz.TabIndex = 18;
            // 
            // txtNbMembre
            // 
            this.txtNbMembre.Location = new System.Drawing.Point(875, 523);
            this.txtNbMembre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNbMembre.Name = "txtNbMembre";
            this.txtNbMembre.Size = new System.Drawing.Size(83, 26);
            this.txtNbMembre.TabIndex = 17;
            this.txtNbMembre.TextChanged += new System.EventHandler(this.txtNbMembre_TextChanged);
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblBudget.Location = new System.Drawing.Point(710, 658);
            this.lblBudget.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(90, 29);
            this.lblBudget.TabIndex = 16;
            this.lblBudget.Text = "Budget";
            // 
            // lblObjectifDB
            // 
            this.lblObjectifDB.AutoSize = true;
            this.lblObjectifDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblObjectifDB.Location = new System.Drawing.Point(663, 601);
            this.lblObjectifDB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblObjectifDB.Name = "lblObjectifDB";
            this.lblObjectifDB.Size = new System.Drawing.Size(191, 29);
            this.lblObjectifDB.TabIndex = 15;
            this.lblObjectifDB.Text = "Objectif DataBaz";
            // 
            // lblNombreMembre
            // 
            this.lblNombreMembre.AutoSize = true;
            this.lblNombreMembre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNombreMembre.Location = new System.Drawing.Point(640, 523);
            this.lblNombreMembre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreMembre.Name = "lblNombreMembre";
            this.lblNombreMembre.Size = new System.Drawing.Size(231, 29);
            this.lblNombreMembre.TabIndex = 14;
            this.lblNombreMembre.Text = "Nombre de membre";
            // 
            // btnValiderMission
            // 
            this.btnValiderMission.Location = new System.Drawing.Point(1323, 909);
            this.btnValiderMission.Margin = new System.Windows.Forms.Padding(2);
            this.btnValiderMission.Name = "btnValiderMission";
            this.btnValiderMission.Size = new System.Drawing.Size(160, 50);
            this.btnValiderMission.TabIndex = 22;
            this.btnValiderMission.Text = "Valider";
            this.btnValiderMission.UseVisualStyleBackColor = true;
            this.btnValiderMission.Click += new System.EventHandler(this.btnValiderMission_Click);
            // 
            // lblChoixPlanete
            // 
            this.lblChoixPlanete.AutoSize = true;
            this.lblChoixPlanete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoixPlanete.ForeColor = System.Drawing.Color.White;
            this.lblChoixPlanete.Location = new System.Drawing.Point(30, 156);
            this.lblChoixPlanete.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChoixPlanete.Name = "lblChoixPlanete";
            this.lblChoixPlanete.Size = new System.Drawing.Size(154, 29);
            this.lblChoixPlanete.TabIndex = 0;
            this.lblChoixPlanete.Text = "I - PLANETE";
            // 
            // cboPlanete
            // 
            this.cboPlanete.FormattingEnabled = true;
            this.cboPlanete.Location = new System.Drawing.Point(243, 156);
            this.cboPlanete.Margin = new System.Windows.Forms.Padding(2);
            this.cboPlanete.Name = "cboPlanete";
            this.cboPlanete.Size = new System.Drawing.Size(316, 28);
            this.cboPlanete.TabIndex = 1;
            this.cboPlanete.SelectedIndexChanged += new System.EventHandler(this.cboPlanete_SelectedIndexChanged);
            // 
            // btnValiderPlanete
            // 
            this.btnValiderPlanete.Location = new System.Drawing.Point(630, 153);
            this.btnValiderPlanete.Margin = new System.Windows.Forms.Padding(2);
            this.btnValiderPlanete.Name = "btnValiderPlanete";
            this.btnValiderPlanete.Size = new System.Drawing.Size(162, 32);
            this.btnValiderPlanete.TabIndex = 2;
            this.btnValiderPlanete.Text = "Valider";
            this.btnValiderPlanete.UseVisualStyleBackColor = true;
            this.btnValiderPlanete.Click += new System.EventHandler(this.btnValiderPlanete_Click);
            // 
            // lblMission
            // 
            this.lblMission.AutoSize = true;
            this.lblMission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.lblMission.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMission.ForeColor = System.Drawing.Color.White;
            this.lblMission.Location = new System.Drawing.Point(707, 25);
            this.lblMission.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMission.Name = "lblMission";
            this.lblMission.Size = new System.Drawing.Size(212, 46);
            this.lblMission.TabIndex = 3;
            this.lblMission.Text = "MISSION :";
            this.lblMission.Click += new System.EventHandler(this.lblNom_Click);
            // 
            // lblNomDeMission
            // 
            this.lblNomDeMission.AutoSize = true;
            this.lblNomDeMission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.lblNomDeMission.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomDeMission.ForeColor = System.Drawing.Color.White;
            this.lblNomDeMission.Location = new System.Drawing.Point(979, 26);
            this.lblNomDeMission.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomDeMission.Name = "lblNomDeMission";
            this.lblNomDeMission.Size = new System.Drawing.Size(205, 46);
            this.lblNomDeMission.TabIndex = 4;
            this.lblNomDeMission.Text = "PLANETE";
            // 
            // lblNumMission
            // 
            this.lblNumMission.AutoSize = true;
            this.lblNumMission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.lblNumMission.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumMission.ForeColor = System.Drawing.Color.White;
            this.lblNumMission.Location = new System.Drawing.Point(1288, 25);
            this.lblNumMission.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumMission.Name = "lblNumMission";
            this.lblNumMission.Size = new System.Drawing.Size(42, 46);
            this.lblNumMission.TabIndex = 5;
            this.lblNumMission.Text = "0";
            // 
            // lblChoixChefMission
            // 
            this.lblChoixChefMission.AutoSize = true;
            this.lblChoixChefMission.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoixChefMission.ForeColor = System.Drawing.Color.White;
            this.lblChoixChefMission.Location = new System.Drawing.Point(30, 258);
            this.lblChoixChefMission.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChoixChefMission.Name = "lblChoixChefMission";
            this.lblChoixChefMission.Size = new System.Drawing.Size(263, 29);
            this.lblChoixChefMission.TabIndex = 6;
            this.lblChoixChefMission.Text = "II - CHEF DE MISSION";
            // 
            // cboChefMission
            // 
            this.cboChefMission.FormattingEnabled = true;
            this.cboChefMission.Location = new System.Drawing.Point(332, 262);
            this.cboChefMission.Margin = new System.Windows.Forms.Padding(2);
            this.cboChefMission.Name = "cboChefMission";
            this.cboChefMission.Size = new System.Drawing.Size(514, 28);
            this.cboChefMission.TabIndex = 7;
            // 
            // lblDateDepart
            // 
            this.lblDateDepart.AutoSize = true;
            this.lblDateDepart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDateDepart.Location = new System.Drawing.Point(501, 352);
            this.lblDateDepart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateDepart.Name = "lblDateDepart";
            this.lblDateDepart.Size = new System.Drawing.Size(138, 29);
            this.lblDateDepart.TabIndex = 8;
            this.lblDateDepart.Text = "Date départ";
            // 
            // lblDateRetour
            // 
            this.lblDateRetour.AutoSize = true;
            this.lblDateRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDateRetour.Location = new System.Drawing.Point(521, 463);
            this.lblDateRetour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateRetour.Name = "lblDateRetour";
            this.lblDateRetour.Size = new System.Drawing.Size(132, 29);
            this.lblDateRetour.TabIndex = 9;
            this.lblDateRetour.Text = "Date retour";
            // 
            // dtpDepart
            // 
            this.dtpDepart.Location = new System.Drawing.Point(668, 355);
            this.dtpDepart.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDepart.Name = "dtpDepart";
            this.dtpDepart.Size = new System.Drawing.Size(381, 26);
            this.dtpDepart.TabIndex = 10;
            // 
            // dtpRetour
            // 
            this.dtpRetour.Location = new System.Drawing.Point(696, 466);
            this.dtpRetour.Margin = new System.Windows.Forms.Padding(2);
            this.dtpRetour.Name = "dtpRetour";
            this.dtpRetour.Size = new System.Drawing.Size(381, 26);
            this.dtpRetour.TabIndex = 11;
            // 
            // lblFeuilleRoute
            // 
            this.lblFeuilleRoute.AutoSize = true;
            this.lblFeuilleRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFeuilleRoute.Location = new System.Drawing.Point(11, 709);
            this.lblFeuilleRoute.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFeuilleRoute.Name = "lblFeuilleRoute";
            this.lblFeuilleRoute.Size = new System.Drawing.Size(182, 29);
            this.lblFeuilleRoute.TabIndex = 12;
            this.lblFeuilleRoute.Text = "Feuille de route";
            this.lblFeuilleRoute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richtxtFeuilleRoute
            // 
            this.richtxtFeuilleRoute.Location = new System.Drawing.Point(192, 709);
            this.richtxtFeuilleRoute.Margin = new System.Windows.Forms.Padding(2);
            this.richtxtFeuilleRoute.Name = "richtxtFeuilleRoute";
            this.richtxtFeuilleRoute.Size = new System.Drawing.Size(503, 222);
            this.richtxtFeuilleRoute.TabIndex = 23;
            this.richtxtFeuilleRoute.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1606, 105);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // lblCreerNewMission
            // 
            this.lblCreerNewMission.AutoSize = true;
            this.lblCreerNewMission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.lblCreerNewMission.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lblCreerNewMission.ForeColor = System.Drawing.Color.White;
            this.lblCreerNewMission.Location = new System.Drawing.Point(37, 24);
            this.lblCreerNewMission.Name = "lblCreerNewMission";
            this.lblCreerNewMission.Size = new System.Drawing.Size(532, 46);
            this.lblCreerNewMission.TabIndex = 25;
            this.lblCreerNewMission.Text = "Créer une nouvelle mission";
            // 
            // formNouvelleMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1575, 970);
            this.Controls.Add(this.lblCreerNewMission);
            this.Controls.Add(this.richtxtFeuilleRoute);
            this.Controls.Add(this.lblFeuilleRoute);
            this.Controls.Add(this.btnValiderMission);
            this.Controls.Add(this.dtpRetour);
            this.Controls.Add(this.lblTonne);
            this.Controls.Add(this.dtpDepart);
            this.Controls.Add(this.lblDateRetour);
            this.Controls.Add(this.lblNombreMembre);
            this.Controls.Add(this.lblDateDepart);
            this.Controls.Add(this.lblDollard);
            this.Controls.Add(this.cboChefMission);
            this.Controls.Add(this.lblObjectifDB);
            this.Controls.Add(this.lblChoixChefMission);
            this.Controls.Add(this.txtBudget);
            this.Controls.Add(this.lblBudget);
            this.Controls.Add(this.lblNumMission);
            this.Controls.Add(this.txtObjectifDataBaz);
            this.Controls.Add(this.lblNomDeMission);
            this.Controls.Add(this.txtNbMembre);
            this.Controls.Add(this.lblMission);
            this.Controls.Add(this.lblChoixPlanete);
            this.Controls.Add(this.btnValiderPlanete);
            this.Controls.Add(this.cboPlanete);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "formNouvelleMission";
            this.Text = "Création d\'une nouvelle mission";
            this.Load += new System.EventHandler(this.formNouvelleMission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtObjectifDataBaz;
        private System.Windows.Forms.TextBox txtNbMembre;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Label lblObjectifDB;
        private System.Windows.Forms.Label lblNombreMembre;
        private System.Windows.Forms.TextBox txtBudget;
        private System.Windows.Forms.Label lblDollard;
        private System.Windows.Forms.Label lblTonne;
        private System.Windows.Forms.Button btnValiderMission;
        private System.Windows.Forms.Label lblChoixPlanete;
        private System.Windows.Forms.ComboBox cboPlanete;
        private System.Windows.Forms.Button btnValiderPlanete;
        private System.Windows.Forms.Label lblMission;
        private System.Windows.Forms.Label lblNomDeMission;
        private System.Windows.Forms.Label lblNumMission;
        private System.Windows.Forms.Label lblChoixChefMission;
        private System.Windows.Forms.ComboBox cboChefMission;
        private System.Windows.Forms.Label lblDateDepart;
        private System.Windows.Forms.Label lblDateRetour;
        private System.Windows.Forms.DateTimePicker dtpDepart;
        private System.Windows.Forms.DateTimePicker dtpRetour;
        private System.Windows.Forms.Label lblFeuilleRoute;
        private System.Windows.Forms.RichTextBox richtxtFeuilleRoute;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCreerNewMission;
    }
}
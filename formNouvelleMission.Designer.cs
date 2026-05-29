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
            this.grpNouvelleMission = new System.Windows.Forms.GroupBox();
            this.lblChoixChefMission = new System.Windows.Forms.Label();
            this.lblNumMission = new System.Windows.Forms.Label();
            this.lblNomDeMission = new System.Windows.Forms.Label();
            this.lblMission = new System.Windows.Forms.Label();
            this.btnValiderPlanete = new System.Windows.Forms.Button();
            this.cboPlanete = new System.Windows.Forms.ComboBox();
            this.lblChoixPlanete = new System.Windows.Forms.Label();
            this.cboChefMission = new System.Windows.Forms.ComboBox();
            this.lblDateDepart = new System.Windows.Forms.Label();
            this.lblDateRetour = new System.Windows.Forms.Label();
            this.dtpDepart = new System.Windows.Forms.DateTimePicker();
            this.dtpRetour = new System.Windows.Forms.DateTimePicker();
            this.lblFeuilleRoute = new System.Windows.Forms.Label();
            this.lblNombreMembre = new System.Windows.Forms.Label();
            this.lblObjectifDB = new System.Windows.Forms.Label();
            this.lblBudget = new System.Windows.Forms.Label();
            this.txtNbMembre = new System.Windows.Forms.TextBox();
            this.txtObjectifDataBaz = new System.Windows.Forms.TextBox();
            this.txtBudget = new System.Windows.Forms.TextBox();
            this.lblDollard = new System.Windows.Forms.Label();
            this.lblTonne = new System.Windows.Forms.Label();
            this.btnValiderMission = new System.Windows.Forms.Button();
            this.richtxtFeuilleRoute = new System.Windows.Forms.RichTextBox();
            this.grpNouvelleMission.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNouvelleMission
            // 
            this.grpNouvelleMission.Controls.Add(this.richtxtFeuilleRoute);
            this.grpNouvelleMission.Controls.Add(this.btnValiderMission);
            this.grpNouvelleMission.Controls.Add(this.lblTonne);
            this.grpNouvelleMission.Controls.Add(this.lblDollard);
            this.grpNouvelleMission.Controls.Add(this.txtBudget);
            this.grpNouvelleMission.Controls.Add(this.txtObjectifDataBaz);
            this.grpNouvelleMission.Controls.Add(this.txtNbMembre);
            this.grpNouvelleMission.Controls.Add(this.lblBudget);
            this.grpNouvelleMission.Controls.Add(this.lblObjectifDB);
            this.grpNouvelleMission.Controls.Add(this.lblNombreMembre);
            this.grpNouvelleMission.Controls.Add(this.lblFeuilleRoute);
            this.grpNouvelleMission.Controls.Add(this.dtpRetour);
            this.grpNouvelleMission.Controls.Add(this.dtpDepart);
            this.grpNouvelleMission.Controls.Add(this.lblDateRetour);
            this.grpNouvelleMission.Controls.Add(this.lblDateDepart);
            this.grpNouvelleMission.Controls.Add(this.cboChefMission);
            this.grpNouvelleMission.Controls.Add(this.lblChoixChefMission);
            this.grpNouvelleMission.Controls.Add(this.lblNumMission);
            this.grpNouvelleMission.Controls.Add(this.lblNomDeMission);
            this.grpNouvelleMission.Controls.Add(this.lblMission);
            this.grpNouvelleMission.Controls.Add(this.btnValiderPlanete);
            this.grpNouvelleMission.Controls.Add(this.cboPlanete);
            this.grpNouvelleMission.Controls.Add(this.lblChoixPlanete);
            this.grpNouvelleMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNouvelleMission.Location = new System.Drawing.Point(67, 50);
            this.grpNouvelleMission.Name = "grpNouvelleMission";
            this.grpNouvelleMission.Size = new System.Drawing.Size(1113, 1287);
            this.grpNouvelleMission.TabIndex = 0;
            this.grpNouvelleMission.TabStop = false;
            this.grpNouvelleMission.Text = "Nouvelle mission";
            this.grpNouvelleMission.Enter += new System.EventHandler(this.grpNouvelleMission_Enter);
            // 
            // lblChoixChefMission
            // 
            this.lblChoixChefMission.AutoSize = true;
            this.lblChoixChefMission.Location = new System.Drawing.Point(40, 332);
            this.lblChoixChefMission.Name = "lblChoixChefMission";
            this.lblChoixChefMission.Size = new System.Drawing.Size(369, 32);
            this.lblChoixChefMission.TabIndex = 6;
            this.lblChoixChefMission.Text = "2 - Choix du chef de mission";
            // 
            // lblNumMission
            // 
            this.lblNumMission.AutoSize = true;
            this.lblNumMission.Location = new System.Drawing.Point(668, 207);
            this.lblNumMission.Name = "lblNumMission";
            this.lblNumMission.Size = new System.Drawing.Size(30, 32);
            this.lblNumMission.TabIndex = 5;
            this.lblNumMission.Text = "0";
            // 
            // lblNomDeMission
            // 
            this.lblNomDeMission.AutoSize = true;
            this.lblNomDeMission.Location = new System.Drawing.Point(384, 207);
            this.lblNomDeMission.Name = "lblNomDeMission";
            this.lblNomDeMission.Size = new System.Drawing.Size(143, 32);
            this.lblNomDeMission.TabIndex = 4;
            this.lblNomDeMission.Text = "PLANETE";
            // 
            // lblMission
            // 
            this.lblMission.AutoSize = true;
            this.lblMission.Location = new System.Drawing.Point(40, 207);
            this.lblMission.Name = "lblMission";
            this.lblMission.Size = new System.Drawing.Size(216, 32);
            this.lblMission.TabIndex = 3;
            this.lblMission.Text = "Nom de mission";
            this.lblMission.Click += new System.EventHandler(this.lblNom_Click);
            // 
            // btnValiderPlanete
            // 
            this.btnValiderPlanete.Location = new System.Drawing.Point(842, 92);
            this.btnValiderPlanete.Name = "btnValiderPlanete";
            this.btnValiderPlanete.Size = new System.Drawing.Size(198, 39);
            this.btnValiderPlanete.TabIndex = 2;
            this.btnValiderPlanete.Text = "Valider";
            this.btnValiderPlanete.UseVisualStyleBackColor = true;
            this.btnValiderPlanete.Click += new System.EventHandler(this.btnValiderPlanete_Click);
            // 
            // cboPlanete
            // 
            this.cboPlanete.FormattingEnabled = true;
            this.cboPlanete.Location = new System.Drawing.Point(390, 92);
            this.cboPlanete.Name = "cboPlanete";
            this.cboPlanete.Size = new System.Drawing.Size(385, 40);
            this.cboPlanete.TabIndex = 1;
            this.cboPlanete.SelectedIndexChanged += new System.EventHandler(this.cboPlanete_SelectedIndexChanged);
            // 
            // lblChoixPlanete
            // 
            this.lblChoixPlanete.AutoSize = true;
            this.lblChoixPlanete.Location = new System.Drawing.Point(40, 92);
            this.lblChoixPlanete.Name = "lblChoixPlanete";
            this.lblChoixPlanete.Size = new System.Drawing.Size(297, 32);
            this.lblChoixPlanete.TabIndex = 0;
            this.lblChoixPlanete.Text = "1 - Choix de la planète";
            // 
            // cboChefMission
            // 
            this.cboChefMission.FormattingEnabled = true;
            this.cboChefMission.Location = new System.Drawing.Point(448, 324);
            this.cboChefMission.Name = "cboChefMission";
            this.cboChefMission.Size = new System.Drawing.Size(627, 40);
            this.cboChefMission.TabIndex = 7;
            // 
            // lblDateDepart
            // 
            this.lblDateDepart.AutoSize = true;
            this.lblDateDepart.Location = new System.Drawing.Point(121, 461);
            this.lblDateDepart.Name = "lblDateDepart";
            this.lblDateDepart.Size = new System.Drawing.Size(162, 32);
            this.lblDateDepart.TabIndex = 8;
            this.lblDateDepart.Text = "Date départ";
            // 
            // lblDateRetour
            // 
            this.lblDateRetour.AutoSize = true;
            this.lblDateRetour.Location = new System.Drawing.Point(121, 556);
            this.lblDateRetour.Name = "lblDateRetour";
            this.lblDateRetour.Size = new System.Drawing.Size(155, 32);
            this.lblDateRetour.TabIndex = 9;
            this.lblDateRetour.Text = "Date retour";
            // 
            // dtpDepart
            // 
            this.dtpDepart.Location = new System.Drawing.Point(417, 461);
            this.dtpDepart.Name = "dtpDepart";
            this.dtpDepart.Size = new System.Drawing.Size(465, 39);
            this.dtpDepart.TabIndex = 10;
            // 
            // dtpRetour
            // 
            this.dtpRetour.Location = new System.Drawing.Point(417, 551);
            this.dtpRetour.Name = "dtpRetour";
            this.dtpRetour.Size = new System.Drawing.Size(465, 39);
            this.dtpRetour.TabIndex = 11;
            // 
            // lblFeuilleRoute
            // 
            this.lblFeuilleRoute.AutoSize = true;
            this.lblFeuilleRoute.Location = new System.Drawing.Point(121, 652);
            this.lblFeuilleRoute.Name = "lblFeuilleRoute";
            this.lblFeuilleRoute.Size = new System.Drawing.Size(211, 32);
            this.lblFeuilleRoute.TabIndex = 12;
            this.lblFeuilleRoute.Text = "Feuille de route";
            this.lblFeuilleRoute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombreMembre
            // 
            this.lblNombreMembre.AutoSize = true;
            this.lblNombreMembre.Location = new System.Drawing.Point(121, 994);
            this.lblNombreMembre.Name = "lblNombreMembre";
            this.lblNombreMembre.Size = new System.Drawing.Size(263, 32);
            this.lblNombreMembre.TabIndex = 14;
            this.lblNombreMembre.Text = "Nombre de membre";
            // 
            // lblObjectifDB
            // 
            this.lblObjectifDB.AutoSize = true;
            this.lblObjectifDB.Location = new System.Drawing.Point(121, 1089);
            this.lblObjectifDB.Name = "lblObjectifDB";
            this.lblObjectifDB.Size = new System.Drawing.Size(228, 32);
            this.lblObjectifDB.TabIndex = 15;
            this.lblObjectifDB.Text = "Objectif DataBaz";
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Location = new System.Drawing.Point(121, 1157);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(105, 32);
            this.lblBudget.TabIndex = 16;
            this.lblBudget.Text = "Budget";
            // 
            // txtNbMembre
            // 
            this.txtNbMembre.Location = new System.Drawing.Point(417, 991);
            this.txtNbMembre.Name = "txtNbMembre";
            this.txtNbMembre.Size = new System.Drawing.Size(100, 39);
            this.txtNbMembre.TabIndex = 17;
            this.txtNbMembre.TextChanged += new System.EventHandler(this.txtNbMembre_TextChanged);
            // 
            // txtObjectifDataBaz
            // 
            this.txtObjectifDataBaz.Location = new System.Drawing.Point(417, 1089);
            this.txtObjectifDataBaz.Name = "txtObjectifDataBaz";
            this.txtObjectifDataBaz.Size = new System.Drawing.Size(100, 39);
            this.txtObjectifDataBaz.TabIndex = 18;
            // 
            // txtBudget
            // 
            this.txtBudget.Location = new System.Drawing.Point(417, 1157);
            this.txtBudget.Name = "txtBudget";
            this.txtBudget.Size = new System.Drawing.Size(100, 39);
            this.txtBudget.TabIndex = 19;
            // 
            // lblDollard
            // 
            this.lblDollard.AutoSize = true;
            this.lblDollard.Location = new System.Drawing.Point(547, 1157);
            this.lblDollard.Name = "lblDollard";
            this.lblDollard.Size = new System.Drawing.Size(30, 32);
            this.lblDollard.TabIndex = 20;
            this.lblDollard.Text = "$";
            this.lblDollard.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTonne
            // 
            this.lblTonne.AutoSize = true;
            this.lblTonne.Location = new System.Drawing.Point(547, 1096);
            this.lblTonne.Name = "lblTonne";
            this.lblTonne.Size = new System.Drawing.Size(100, 32);
            this.lblTonne.TabIndex = 21;
            this.lblTonne.Text = "tonnes";
            // 
            // btnValiderMission
            // 
            this.btnValiderMission.Location = new System.Drawing.Point(892, 1199);
            this.btnValiderMission.Name = "btnValiderMission";
            this.btnValiderMission.Size = new System.Drawing.Size(195, 60);
            this.btnValiderMission.TabIndex = 22;
            this.btnValiderMission.Text = "Valider";
            this.btnValiderMission.UseVisualStyleBackColor = true;
            this.btnValiderMission.Click += new System.EventHandler(this.btnValiderMission_Click);
            // 
            // richtxtFeuilleRoute
            // 
            this.richtxtFeuilleRoute.Location = new System.Drawing.Point(417, 652);
            this.richtxtFeuilleRoute.Name = "richtxtFeuilleRoute";
            this.richtxtFeuilleRoute.Size = new System.Drawing.Size(614, 266);
            this.richtxtFeuilleRoute.TabIndex = 23;
            this.richtxtFeuilleRoute.Text = "";
            // 
            // formNouvelleMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 1391);
            this.Controls.Add(this.grpNouvelleMission);
            this.Name = "formNouvelleMission";
            this.Text = "Création d\'une nouvelle mission";
            this.Load += new System.EventHandler(this.formNouvelleMission_Load);
            this.grpNouvelleMission.ResumeLayout(false);
            this.grpNouvelleMission.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNouvelleMission;
        private System.Windows.Forms.Label lblMission;
        private System.Windows.Forms.Button btnValiderPlanete;
        private System.Windows.Forms.ComboBox cboPlanete;
        private System.Windows.Forms.Label lblChoixPlanete;
        private System.Windows.Forms.Label lblNumMission;
        private System.Windows.Forms.Label lblNomDeMission;
        private System.Windows.Forms.Label lblChoixChefMission;
        private System.Windows.Forms.Label lblDateDepart;
        private System.Windows.Forms.ComboBox cboChefMission;
        private System.Windows.Forms.DateTimePicker dtpDepart;
        private System.Windows.Forms.Label lblDateRetour;
        private System.Windows.Forms.Label lblFeuilleRoute;
        private System.Windows.Forms.DateTimePicker dtpRetour;
        private System.Windows.Forms.TextBox txtObjectifDataBaz;
        private System.Windows.Forms.TextBox txtNbMembre;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Label lblObjectifDB;
        private System.Windows.Forms.Label lblNombreMembre;
        private System.Windows.Forms.TextBox txtBudget;
        private System.Windows.Forms.Label lblDollard;
        private System.Windows.Forms.Label lblTonne;
        private System.Windows.Forms.Button btnValiderMission;
        private System.Windows.Forms.RichTextBox richtxtFeuilleRoute;
    }
}
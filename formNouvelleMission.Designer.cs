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
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumMission = new System.Windows.Forms.Label();
            this.lblNomDeMission = new System.Windows.Forms.Label();
            this.lblMission = new System.Windows.Forms.Label();
            this.btnValiderPlanete = new System.Windows.Forms.Button();
            this.cboPlanete = new System.Windows.Forms.ComboBox();
            this.lblChoixPlanete = new System.Windows.Forms.Label();
            this.grpNouvelleMission.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNouvelleMission
            // 
            this.grpNouvelleMission.Controls.Add(this.label1);
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "2 - Choix de la planète";
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
        private System.Windows.Forms.Label label1;
    }
}
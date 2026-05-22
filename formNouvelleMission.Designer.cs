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
            this.lblChoixPlanete = new System.Windows.Forms.Label();
            this.cboPlanete = new System.Windows.Forms.ComboBox();
            this.btnValiderPlanete = new System.Windows.Forms.Button();
            this.lblNom = new System.Windows.Forms.Label();
            this.grpNouvelleMission.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNouvelleMission
            // 
            this.grpNouvelleMission.Controls.Add(this.lblNom);
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
            // lblChoixPlanete
            // 
            this.lblChoixPlanete.AutoSize = true;
            this.lblChoixPlanete.Location = new System.Drawing.Point(40, 92);
            this.lblChoixPlanete.Name = "lblChoixPlanete";
            this.lblChoixPlanete.Size = new System.Drawing.Size(297, 32);
            this.lblChoixPlanete.TabIndex = 0;
            this.lblChoixPlanete.Text = "1 - Choix de la planète";
            // 
            // cboPlanete
            // 
            this.cboPlanete.FormattingEnabled = true;
            this.cboPlanete.Location = new System.Drawing.Point(390, 92);
            this.cboPlanete.Name = "cboPlanete";
            this.cboPlanete.Size = new System.Drawing.Size(385, 40);
            this.cboPlanete.TabIndex = 1;
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
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(40, 273);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(92, 32);
            this.lblNom.TabIndex = 3;
            this.lblNom.Text = "label1";
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
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Button btnValiderPlanete;
        private System.Windows.Forms.ComboBox cboPlanete;
        private System.Windows.Forms.Label lblChoixPlanete;
    }
}
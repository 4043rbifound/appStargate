namespace appliPandora
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.btnNouvelleMission = new System.Windows.Forms.Button();
            this.btnInfosMissions = new System.Windows.Forms.Button();
            this.btn_NVplnt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnNouvelleMission
            // 
            this.btnNouvelleMission.Location = new System.Drawing.Point(31, 126);
            this.btnNouvelleMission.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNouvelleMission.Name = "btnNouvelleMission";
            this.btnNouvelleMission.Size = new System.Drawing.Size(75, 22);
            this.btnNouvelleMission.TabIndex = 1;
            this.btnNouvelleMission.Text = "Nouvelle mission";
            this.btnNouvelleMission.UseVisualStyleBackColor = true;
            this.btnNouvelleMission.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnInfosMissions
            // 
            this.btnInfosMissions.Location = new System.Drawing.Point(31, 226);
            this.btnInfosMissions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInfosMissions.Name = "btnInfosMissions";
            this.btnInfosMissions.Size = new System.Drawing.Size(149, 22);
            this.btnInfosMissions.TabIndex = 2;
            this.btnInfosMissions.Text = "Infos Missions";
            this.btnInfosMissions.UseVisualStyleBackColor = true;
            this.btnInfosMissions.Click += new System.EventHandler(this.btnInfosMissions_Click);
            // 
            // btn_NVplnt
            // 
            this.btn_NVplnt.Location = new System.Drawing.Point(31, 350);
            this.btn_NVplnt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_NVplnt.Name = "btn_NVplnt";
            this.btn_NVplnt.Size = new System.Drawing.Size(149, 22);
            this.btn_NVplnt.TabIndex = 3;
            this.btn_NVplnt.Text = "Infos Planétes";
            this.btn_NVplnt.UseVisualStyleBackColor = true;
            this.btn_NVplnt.Click += new System.EventHandler(this.btn_NVplnt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 486);
            this.Controls.Add(this.btn_NVplnt);
            this.Controls.Add(this.btnInfosMissions);
            this.Controls.Add(this.btnNouvelleMission);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNouvelleMission;
        private System.Windows.Forms.Button btnInfosMissions;
        private System.Windows.Forms.Button btn_NVplnt;
    }
}


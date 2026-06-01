namespace appStargate
{
    partial class MembreUserControle
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNomPrenom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.pictureBoxMembre = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMembre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomPrenom
            // 
            this.lblNomPrenom.AutoSize = true;
            this.lblNomPrenom.BackColor = System.Drawing.SystemColors.Control;
            this.lblNomPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomPrenom.Location = new System.Drawing.Point(73, 183);
            this.lblNomPrenom.Name = "lblNomPrenom";
            this.lblNomPrenom.Size = new System.Drawing.Size(51, 20);
            this.lblNomPrenom.TabIndex = 1;
            this.lblNomPrenom.Text = "NON ";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.BackColor = System.Drawing.SystemColors.Control;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(73, 206);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(70, 20);
            this.lblPrenom.TabIndex = 3;
            this.lblPrenom.Text = "Prénom";
            // 
            // pictureBoxMembre
            // 
            this.pictureBoxMembre.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxMembre.BackgroundImage = global::appStargate.Properties.Resources.soldat;
            this.pictureBoxMembre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMembre.Location = new System.Drawing.Point(19, 19);
            this.pictureBoxMembre.Name = "pictureBoxMembre";
            this.pictureBoxMembre.Size = new System.Drawing.Size(177, 161);
            this.pictureBoxMembre.TabIndex = 0;
            this.pictureBoxMembre.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 227);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.BackgroundImage = global::appStargate.Properties.Resources.civil1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(19, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(177, 161);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // MembreUserControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(219)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNomPrenom);
            this.Controls.Add(this.pictureBoxMembre);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MembreUserControle";
            this.Size = new System.Drawing.Size(215, 250);
            this.Load += new System.EventHandler(this.MembreUserControle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMembre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMembre;
        private System.Windows.Forms.Label lblNomPrenom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

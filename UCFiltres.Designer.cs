namespace appStargate
{
    partial class UCFiltres
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFiltrer = new System.Windows.Forms.Button();
            this.CboCouleur = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(21, 104);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(238, 26);
            this.txtNom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Couleur :";
            // 
            // btnFiltrer
            // 
            this.btnFiltrer.Location = new System.Drawing.Point(90, 234);
            this.btnFiltrer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFiltrer.Name = "btnFiltrer";
            this.btnFiltrer.Size = new System.Drawing.Size(90, 54);
            this.btnFiltrer.TabIndex = 4;
            this.btnFiltrer.Text = "🔍";
            this.btnFiltrer.UseVisualStyleBackColor = true;
            this.btnFiltrer.Visible = false;
            // 
            // CboCouleur
            // 
            this.CboCouleur.FormattingEnabled = true;
            this.CboCouleur.Location = new System.Drawing.Point(21, 182);
            this.CboCouleur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CboCouleur.Name = "CboCouleur";
            this.CboCouleur.Size = new System.Drawing.Size(238, 28);
            this.CboCouleur.TabIndex = 5;
            // 
            // UCFiltres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CboCouleur);
            this.Controls.Add(this.btnFiltrer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UCFiltres";
            this.Size = new System.Drawing.Size(270, 292);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFiltrer;
        private System.Windows.Forms.ComboBox CboCouleur;
    }
}

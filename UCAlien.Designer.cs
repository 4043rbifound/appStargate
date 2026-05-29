namespace appStargate
{
    partial class UCAlien
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pbAlien = new System.Windows.Forms.PictureBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblCouleur = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien)).BeginInit();
            this.SuspendLayout();

            // pbAlien
            this.pbAlien.Location = new System.Drawing.Point(15, 10);
            this.pbAlien.Name = "pbAlien";
            this.pbAlien.Size = new System.Drawing.Size(120, 120);
            this.pbAlien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAlien.TabIndex = 0;
            this.pbAlien.TabStop = false;

            // lblNom
            this.lblNom.AutoSize = false; // ← false pour éviter le décalage
            this.lblNom.Location = new System.Drawing.Point(5, 135);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(140, 20);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "";
            this.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNom.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);

            // lblCouleur
            this.lblCouleur.AutoSize = false; // ← false
            this.lblCouleur.Location = new System.Drawing.Point(5, 158);
            this.lblCouleur.Name = "lblCouleur";
            this.lblCouleur.Size = new System.Drawing.Size(140, 20);
            this.lblCouleur.TabIndex = 2;
            this.lblCouleur.Text = "";
            this.lblCouleur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblType
            this.lblType.AutoSize = false; // ← false
            this.lblType.Location = new System.Drawing.Point(5, 178);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(140, 20);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // UCAlien
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblCouleur);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.pbAlien);
            this.Name = "UCAlien";
            this.Size = new System.Drawing.Size(150, 200);
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox pbAlien;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblCouleur;
        private System.Windows.Forms.Label lblType;
    }
}
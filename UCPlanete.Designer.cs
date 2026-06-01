namespace appStargate
{
    partial class UCPlanete
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
            this.pbPlanete = new System.Windows.Forms.PictureBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblGravite = new System.Windows.Forms.Label();
            this.lblDatabaz = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlanete)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPlanete
            // 
            this.pbPlanete.Location = new System.Drawing.Point(5, 5);
            this.pbPlanete.Name = "pbPlanete";
            this.pbPlanete.Size = new System.Drawing.Size(60, 60);
            this.pbPlanete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlanete.TabIndex = 0;
            this.pbPlanete.TabStop = false;
            // 
            // lblNom
            // 
            this.lblNom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNom.Location = new System.Drawing.Point(75, 5);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(150, 20);
            this.lblNom.TabIndex = 1;
            this.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTemp
            // 
            this.lblTemp.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTemp.Location = new System.Drawing.Point(75, 28);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(150, 18);
            this.lblTemp.TabIndex = 2;
            this.lblTemp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGravite
            // 
            this.lblGravite.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblGravite.Location = new System.Drawing.Point(75, 46);
            this.lblGravite.Name = "lblGravite";
            this.lblGravite.Size = new System.Drawing.Size(150, 18);
            this.lblGravite.TabIndex = 3;
            this.lblGravite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDatabaz
            // 
            this.lblDatabaz.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblDatabaz.Location = new System.Drawing.Point(220, 25);
            this.lblDatabaz.Name = "lblDatabaz";
            this.lblDatabaz.Size = new System.Drawing.Size(167, 23);
            this.lblDatabaz.TabIndex = 4;
            this.lblDatabaz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCPlanete
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.lblDatabaz);
            this.Controls.Add(this.lblGravite);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.pbPlanete);
            this.Name = "UCPlanete";
            this.Size = new System.Drawing.Size(390, 70);
            this.Load += new System.EventHandler(this.UCPlanete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlanete)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.PictureBox pbPlanete;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblGravite;
        private System.Windows.Forms.Label lblDatabaz;
    }
}
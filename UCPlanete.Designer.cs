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

            // pbPlanete
            this.pbPlanete.Location = new System.Drawing.Point(15, 10);
            this.pbPlanete.Name = "pbPlanete";
            this.pbPlanete.Size = new System.Drawing.Size(120, 120);
            this.pbPlanete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlanete.TabIndex = 0;
            this.pbPlanete.TabStop = false;

            // lblNom
            this.lblNom.AutoSize = false;
            this.lblNom.Location = new System.Drawing.Point(5, 135);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(145, 20);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "";
            this.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNom.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);

            // lblTemp
            this.lblTemp.AutoSize = false;
            this.lblTemp.Location = new System.Drawing.Point(5, 158);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(145, 20);
            this.lblTemp.TabIndex = 2;
            this.lblTemp.Text = "";
            this.lblTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblGravite
            this.lblGravite.AutoSize = false;
            this.lblGravite.Location = new System.Drawing.Point(5, 178);
            this.lblGravite.Name = "lblGravite";
            this.lblGravite.Size = new System.Drawing.Size(145, 20);
            this.lblGravite.TabIndex = 3;
            this.lblGravite.Text = "";
            this.lblGravite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblDatabaz
            this.lblDatabaz.AutoSize = false;
            this.lblDatabaz.Location = new System.Drawing.Point(5, 198);
            this.lblDatabaz.Name = "lblDatabaz";
            this.lblDatabaz.Size = new System.Drawing.Size(145, 20);
            this.lblDatabaz.TabIndex = 4;
            this.lblDatabaz.Text = "";
            this.lblDatabaz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // UCPlanete
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.lblDatabaz);
            this.Controls.Add(this.lblGravite);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.pbPlanete);
            this.Name = "UCPlanete";
            this.Size = new System.Drawing.Size(160, 240);
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
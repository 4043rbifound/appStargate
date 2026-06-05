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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlanete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPlanete
            // 
            this.pbPlanete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.pbPlanete.Location = new System.Drawing.Point(20, 10);
            this.pbPlanete.Name = "pbPlanete";
            this.pbPlanete.Size = new System.Drawing.Size(120, 120);
            this.pbPlanete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlanete.TabIndex = 0;
            this.pbPlanete.TabStop = false;
            // 
            // lblNom
            // 
            this.lblNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.lblNom.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblNom.ForeColor = System.Drawing.Color.White;
            this.lblNom.Location = new System.Drawing.Point(8, 135);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(145, 20);
            this.lblNom.TabIndex = 1;
            this.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTemp
            // 
            this.lblTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.lblTemp.ForeColor = System.Drawing.Color.White;
            this.lblTemp.Location = new System.Drawing.Point(10, 158);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(145, 20);
            this.lblTemp.TabIndex = 2;
            this.lblTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGravite
            // 
            this.lblGravite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.lblGravite.ForeColor = System.Drawing.Color.White;
            this.lblGravite.Location = new System.Drawing.Point(11, 178);
            this.lblGravite.Name = "lblGravite";
            this.lblGravite.Size = new System.Drawing.Size(145, 20);
            this.lblGravite.TabIndex = 3;
            this.lblGravite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDatabaz
            // 
            this.lblDatabaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.lblDatabaz.ForeColor = System.Drawing.Color.White;
            this.lblDatabaz.Location = new System.Drawing.Point(8, 198);
            this.lblDatabaz.Name = "lblDatabaz";
            this.lblDatabaz.Size = new System.Drawing.Size(145, 20);
            this.lblDatabaz.TabIndex = 4;
            this.lblDatabaz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.pictureBox1.Location = new System.Drawing.Point(7, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 225);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // UCPlanete
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(87)))), ((int)(((byte)(129)))));
            this.Controls.Add(this.lblDatabaz);
            this.Controls.Add(this.lblGravite);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.pbPlanete);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UCPlanete";
            this.Size = new System.Drawing.Size(160, 240);
            this.Load += new System.EventHandler(this.UCPlanete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlanete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.PictureBox pbPlanete;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblGravite;
        private System.Windows.Forms.Label lblDatabaz;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
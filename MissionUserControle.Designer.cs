namespace appStargate
{
    partial class MissionUserControle
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblTitreMission = new System.Windows.Forms.Label();
            this.lblDateDebutMission = new System.Windows.Forms.Label();
            this.lblChefMission = new System.Windows.Forms.Label();
            this.lblDateFinMission = new System.Windows.Forms.Label();
            this.lblBudget = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.ImageMission = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageMission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblTitreMission
            // 
            this.lblTitreMission.AutoSize = true;
            this.lblTitreMission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.lblTitreMission.Font = new System.Drawing.Font("Impact", 18F);
            this.lblTitreMission.ForeColor = System.Drawing.Color.White;
            this.lblTitreMission.Location = new System.Drawing.Point(229, 21);
            this.lblTitreMission.Name = "lblTitreMission";
            this.lblTitreMission.Size = new System.Drawing.Size(88, 44);
            this.lblTitreMission.TabIndex = 5;
            this.lblTitreMission.Text = "Titre";
            this.lblTitreMission.Click += new System.EventHandler(this.lblTitreMission_Click);
            // 
            // lblDateDebutMission
            // 
            this.lblDateDebutMission.AutoSize = true;
            this.lblDateDebutMission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.lblDateDebutMission.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblDateDebutMission.ForeColor = System.Drawing.Color.White;
            this.lblDateDebutMission.Location = new System.Drawing.Point(233, 93);
            this.lblDateDebutMission.Name = "lblDateDebutMission";
            this.lblDateDebutMission.Size = new System.Drawing.Size(132, 29);
            this.lblDateDebutMission.TabIndex = 6;
            this.lblDateDebutMission.Text = "DateDebut";
            this.lblDateDebutMission.Click += new System.EventHandler(this.lblDateDebutMission_Click);
            // 
            // lblChefMission
            // 
            this.lblChefMission.AutoSize = true;
            this.lblChefMission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.lblChefMission.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblChefMission.ForeColor = System.Drawing.Color.White;
            this.lblChefMission.Location = new System.Drawing.Point(502, 93);
            this.lblChefMission.Name = "lblChefMission";
            this.lblChefMission.Size = new System.Drawing.Size(66, 29);
            this.lblChefMission.TabIndex = 7;
            this.lblChefMission.Text = "Chef";
            // 
            // lblDateFinMission
            // 
            this.lblDateFinMission.AutoSize = true;
            this.lblDateFinMission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.lblDateFinMission.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblDateFinMission.ForeColor = System.Drawing.Color.White;
            this.lblDateFinMission.Location = new System.Drawing.Point(233, 151);
            this.lblDateFinMission.Name = "lblDateFinMission";
            this.lblDateFinMission.Size = new System.Drawing.Size(101, 29);
            this.lblDateFinMission.TabIndex = 8;
            this.lblDateFinMission.Text = "DateFin";
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.lblBudget.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblBudget.ForeColor = System.Drawing.Color.White;
            this.lblBudget.Location = new System.Drawing.Point(502, 151);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(182, 29);
            this.lblBudget.TabIndex = 10;
            this.lblBudget.Text = "Budget : 5000€";
            this.lblBudget.Click += new System.EventHandler(this.lblBudget_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::appStargate.Properties.Resources._694985;
            this.pictureBox4.Location = new System.Drawing.Point(817, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(68, 59);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // ImageMission
            // 
            this.ImageMission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            this.ImageMission.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImageMission.Image = global::appStargate.Properties.Resources.Artemis_II_patch;
            this.ImageMission.Location = new System.Drawing.Point(23, 21);
            this.ImageMission.Name = "ImageMission";
            this.ImageMission.Size = new System.Drawing.Size(155, 154);
            this.ImageMission.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageMission.TabIndex = 1;
            this.ImageMission.TabStop = false;
            this.ImageMission.Click += new System.EventHandler(this.ImageMission_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 192);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 192);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.pictureBox3.Location = new System.Drawing.Point(187, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(712, 192);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // MissionUserControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lblBudget);
            this.Controls.Add(this.lblDateFinMission);
            this.Controls.Add(this.lblChefMission);
            this.Controls.Add(this.lblDateDebutMission);
            this.Controls.Add(this.lblTitreMission);
            this.Controls.Add(this.ImageMission);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Name = "MissionUserControle";
            this.Size = new System.Drawing.Size(886, 192);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageMission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImageMission;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblTitreMission;
        private System.Windows.Forms.Label lblDateDebutMission;
        private System.Windows.Forms.Label lblChefMission;
        private System.Windows.Forms.Label lblDateFinMission;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}
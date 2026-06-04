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
            this.components = new System.ComponentModel.Container();
            this.btnNouvelleMission = new System.Windows.Forms.Button();
            this.btn_NVplnt = new System.Windows.Forms.Button();
            this.flowLayoutPanelMissions = new System.Windows.Forms.FlowLayoutPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblTableauBord = new System.Windows.Forms.Label();
            this.lblTotalMission = new System.Windows.Forms.Label();
            this.btnRaces = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNouvelleMission
            // 
            this.btnNouvelleMission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.btnNouvelleMission.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNouvelleMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnNouvelleMission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.btnNouvelleMission.Location = new System.Drawing.Point(975, 1);
            this.btnNouvelleMission.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnNouvelleMission.Name = "btnNouvelleMission";
            this.btnNouvelleMission.Size = new System.Drawing.Size(223, 73);
            this.btnNouvelleMission.TabIndex = 1;
            this.btnNouvelleMission.Text = "Nouvelle mission";
            this.btnNouvelleMission.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNouvelleMission.UseVisualStyleBackColor = false;
            this.btnNouvelleMission.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_NVplnt
            // 
            this.btn_NVplnt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.btn_NVplnt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_NVplnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_NVplnt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.btn_NVplnt.Location = new System.Drawing.Point(752, 1);
            this.btn_NVplnt.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btn_NVplnt.Name = "btn_NVplnt";
            this.btn_NVplnt.Size = new System.Drawing.Size(223, 73);
            this.btn_NVplnt.TabIndex = 3;
            this.btn_NVplnt.Text = "Infos Planètes";
            this.btn_NVplnt.UseVisualStyleBackColor = false;
            this.btn_NVplnt.Click += new System.EventHandler(this.btn_NVplnt_Click);
            // 
            // flowLayoutPanelMissions
            // 
            this.flowLayoutPanelMissions.AutoScroll = true;
            this.flowLayoutPanelMissions.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelMissions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelMissions.Location = new System.Drawing.Point(544, 128);
            this.flowLayoutPanelMissions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanelMissions.Name = "flowLayoutPanelMissions";
            this.flowLayoutPanelMissions.Size = new System.Drawing.Size(820, 655);
            this.flowLayoutPanelMissions.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblTableauBord
            // 
            this.lblTableauBord.AutoSize = true;
            this.lblTableauBord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.lblTableauBord.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lblTableauBord.ForeColor = System.Drawing.Color.White;
            this.lblTableauBord.Location = new System.Drawing.Point(99, 21);
            this.lblTableauBord.Name = "lblTableauBord";
            this.lblTableauBord.Size = new System.Drawing.Size(280, 40);
            this.lblTableauBord.TabIndex = 6;
            this.lblTableauBord.Text = "Tableau de Bord";
            // 
            // lblTotalMission
            // 
            this.lblTotalMission.AutoSize = true;
            this.lblTotalMission.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalMission.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalMission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTotalMission.Location = new System.Drawing.Point(748, 85);
            this.lblTotalMission.Name = "lblTotalMission";
            this.lblTotalMission.Size = new System.Drawing.Size(37, 40);
            this.lblTotalMission.TabIndex = 7;
            this.lblTotalMission.Text = "n";
            this.lblTotalMission.Click += new System.EventHandler(this.lblTotalMission_Click);
            // 
            // btnRaces
            // 
            this.btnRaces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.btnRaces.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRaces.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRaces.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.btnRaces.Location = new System.Drawing.Point(1196, 1);
            this.btnRaces.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnRaces.Name = "btnRaces";
            this.btnRaces.Size = new System.Drawing.Size(223, 73);
            this.btnRaces.TabIndex = 8;
            this.btnRaces.Text = "👽 Races";
            this.btnRaces.UseVisualStyleBackColor = false;
            this.btnRaces.Click += new System.EventHandler(this.btnRaces_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(547, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 40);
            this.label1.TabIndex = 11;
            this.label1.Text = "Missions : ";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::appStargate.Properties.Resources._out;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Location = new System.Drawing.Point(-1, 746);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(87, 75);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::appStargate.Properties.Resources.logoSg;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 74);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(536, 84);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.pictureBox3.Location = new System.Drawing.Point(-1, 71);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(85, 764);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.button1.Location = new System.Drawing.Point(532, 1);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 73);
            this.button1.TabIndex = 14;
            this.button1.Text = "Statistique";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::appStargate.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1417, 821);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_NVplnt);
            this.Controls.Add(this.btnRaces);
            this.Controls.Add(this.lblTotalMission);
            this.Controls.Add(this.lblTableauBord);
            this.Controls.Add(this.flowLayoutPanelMissions);
            this.Controls.Add(this.btnNouvelleMission);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tableau de bord";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNouvelleMission;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMissions;
        private System.Windows.Forms.Button btn_NVplnt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblTableauBord;
        private System.Windows.Forms.Label lblTotalMission;
        private System.Windows.Forms.Button btnRaces;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button1;
    }
}


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
            this.button1 = new System.Windows.Forms.Button();
            this.btnNouvelleMission = new System.Windows.Forms.Button();
            this.btn_NVplnt = new System.Windows.Forms.Button();
            this.flowLayoutPanelMissions = new System.Windows.Forms.FlowLayoutPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblTableauBord = new System.Windows.Forms.Label();
            this.lblTotalMission = new System.Windows.Forms.Label();
            this.btnRaces = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 457);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 18);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnNouvelleMission
            // 
            this.btnNouvelleMission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.btnNouvelleMission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNouvelleMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnNouvelleMission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.btnNouvelleMission.Location = new System.Drawing.Point(322, 28);
            this.btnNouvelleMission.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNouvelleMission.Name = "btnNouvelleMission";
            this.btnNouvelleMission.Size = new System.Drawing.Size(167, 59);
            this.btnNouvelleMission.TabIndex = 1;
            this.btnNouvelleMission.Text = "Nouvelle mission";
            this.btnNouvelleMission.UseVisualStyleBackColor = false;
            this.btnNouvelleMission.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_NVplnt
            // 
            this.btn_NVplnt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.btn_NVplnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NVplnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_NVplnt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.btn_NVplnt.Location = new System.Drawing.Point(23, 28);
            this.btn_NVplnt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_NVplnt.Name = "btn_NVplnt";
            this.btn_NVplnt.Size = new System.Drawing.Size(167, 59);
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
            this.flowLayoutPanelMissions.Location = new System.Drawing.Point(322, 126);
            this.flowLayoutPanelMissions.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.flowLayoutPanelMissions.Name = "flowLayoutPanelMissions";
            this.flowLayoutPanelMissions.Size = new System.Drawing.Size(704, 499);
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
            this.lblTableauBord.BackColor = System.Drawing.Color.Transparent;
            this.lblTableauBord.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lblTableauBord.ForeColor = System.Drawing.Color.White;
            this.lblTableauBord.Location = new System.Drawing.Point(17, 348);
            this.lblTableauBord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTableauBord.Name = "lblTableauBord";
            this.lblTableauBord.Size = new System.Drawing.Size(230, 32);
            this.lblTableauBord.TabIndex = 6;
            this.lblTableauBord.Text = "Tableau de Bord";
            // 
            // lblTotalMission
            // 
            this.lblTotalMission.AutoSize = true;
            this.lblTotalMission.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalMission.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalMission.ForeColor = System.Drawing.Color.White;
            this.lblTotalMission.Location = new System.Drawing.Point(-1, 510);
            this.lblTotalMission.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalMission.Name = "lblTotalMission";
            this.lblTotalMission.Size = new System.Drawing.Size(173, 32);
            this.lblTotalMission.TabIndex = 7;
            this.lblTotalMission.Text = "Missions : n";
            // 
            // btnRaces
            // 
            this.btnRaces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.btnRaces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRaces.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.btnRaces.Location = new System.Drawing.Point(591, 28);
            this.btnRaces.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRaces.Name = "btnRaces";
            this.btnRaces.Size = new System.Drawing.Size(167, 59);
            this.btnRaces.TabIndex = 8;
            this.btnRaces.Text = "👽 Races";
            this.btnRaces.UseVisualStyleBackColor = false;
            this.btnRaces.Click += new System.EventHandler(this.btnRaces_Click);
            // 
            // btnStats
            // 
            this.btnStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.btnStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.btnStats.Location = new System.Drawing.Point(859, 28);
            this.btnStats.Margin = new System.Windows.Forms.Padding(2);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(167, 59);
            this.btnStats.TabIndex = 9;
            this.btnStats.Text = "Stats";
            this.btnStats.UseVisualStyleBackColor = false;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::appStargate.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 667);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnRaces);
            this.Controls.Add(this.lblTotalMission);
            this.Controls.Add(this.lblTableauBord);
            this.Controls.Add(this.btn_NVplnt);
            this.Controls.Add(this.flowLayoutPanelMissions);
            this.Controls.Add(this.btnNouvelleMission);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tableau de bord";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNouvelleMission;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMissions;
        private System.Windows.Forms.Button btn_NVplnt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblTableauBord;
        private System.Windows.Forms.Label lblTotalMission;
        private System.Windows.Forms.Button btnRaces;
        private System.Windows.Forms.Button btnStats;
    }
}


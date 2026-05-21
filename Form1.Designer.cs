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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 701);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnNouvelleMission
            // 
            this.btnNouvelleMission.Location = new System.Drawing.Point(35, 88);
            this.btnNouvelleMission.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNouvelleMission.Name = "btnNouvelleMission";
            this.btnNouvelleMission.Size = new System.Drawing.Size(212, 69);
            this.btnNouvelleMission.TabIndex = 1;
            this.btnNouvelleMission.Text = "Nouvelle mission";
            this.btnNouvelleMission.UseVisualStyleBackColor = true;
            this.btnNouvelleMission.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_NVplnt
            // 
            this.btn_NVplnt.Location = new System.Drawing.Point(35, 200);
            this.btn_NVplnt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_NVplnt.Name = "btn_NVplnt";
            this.btn_NVplnt.Size = new System.Drawing.Size(212, 69);
            this.btn_NVplnt.TabIndex = 3;
            this.btn_NVplnt.Text = "Infos Planètes";
            this.btn_NVplnt.UseVisualStyleBackColor = true;
            this.btn_NVplnt.Click += new System.EventHandler(this.btn_NVplnt_Click);
            // 
            // flowLayoutPanelMissions
            // 
            this.flowLayoutPanelMissions.AutoScroll = true;
            this.flowLayoutPanelMissions.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelMissions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelMissions.Location = new System.Drawing.Point(339, 88);
            this.flowLayoutPanelMissions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanelMissions.Name = "flowLayoutPanelMissions";
            this.flowLayoutPanelMissions.Size = new System.Drawing.Size(900, 641);
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
            this.lblTableauBord.Location = new System.Drawing.Point(331, 25);
            this.lblTableauBord.Name = "lblTableauBord";
            this.lblTableauBord.Size = new System.Drawing.Size(326, 46);
            this.lblTableauBord.TabIndex = 6;
            this.lblTableauBord.Text = "Tableau de Bord";
            // 
            // lblTotalMission
            // 
            this.lblTotalMission.AutoSize = true;
            this.lblTotalMission.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalMission.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalMission.ForeColor = System.Drawing.Color.White;
            this.lblTotalMission.Location = new System.Drawing.Point(992, 25);
            this.lblTotalMission.Name = "lblTotalMission";
            this.lblTotalMission.Size = new System.Drawing.Size(247, 46);
            this.lblTotalMission.TabIndex = 7;
            this.lblTotalMission.Text = "Missions : n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::appStargate.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1269, 760);
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
            this.Text = "Form1";
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
    }
}


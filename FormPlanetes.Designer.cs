namespace appStargate
{
    partial class FormPlanetes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlanetes));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flpPlanetes = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMissions = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRaces = new System.Windows.Forms.DataGridView();
            this.lblTitrePlanete = new System.Windows.Forms.Label();
            this.pnlBas = new System.Windows.Forms.Panel();
            this.btnRetour = new System.Windows.Forms.Button();
            this.pnlNotif = new System.Windows.Forms.Panel();
            this.lblNotif = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaces)).BeginInit();
            this.pnlBas.SuspendLayout();
            this.pnlNotif.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flpPlanetes);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.dgvRaces);
            this.splitContainer1.Panel2.Controls.Add(this.lblTitrePlanete);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1063, 615);
            this.splitContainer1.SplitterDistance = 440;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // flpPlanetes
            // 
            this.flpPlanetes.AutoScroll = true;
            this.flpPlanetes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.flpPlanetes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPlanetes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpPlanetes.Location = new System.Drawing.Point(0, 0);
            this.flpPlanetes.Margin = new System.Windows.Forms.Padding(2);
            this.flpPlanetes.Name = "flpPlanetes";
            this.flpPlanetes.Size = new System.Drawing.Size(440, 615);
            this.flpPlanetes.TabIndex = 0;
            this.flpPlanetes.WrapContents = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = global::appStargate.Properties.Resources.imgfondtext;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(28, 252);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(559, 158);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Controls.Add(this.lblMissions);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(500, 103);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // lblMissions
            // 
            this.lblMissions.AutoSize = true;
            this.lblMissions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMissions.ForeColor = System.Drawing.Color.White;
            this.lblMissions.Location = new System.Drawing.Point(3, 0);
            this.lblMissions.MaximumSize = new System.Drawing.Size(687, 0);
            this.lblMissions.Name = "lblMissions";
            this.lblMissions.Size = new System.Drawing.Size(50, 16);
            this.lblMissions.TabIndex = 3;
            this.lblMissions.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(7, 220);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Missions effectuées :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(32, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Races présentes :";
            // 
            // dgvRaces
            // 
            this.dgvRaces.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRaces.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaces.GridColor = System.Drawing.Color.White;
            this.dgvRaces.Location = new System.Drawing.Point(35, 62);
            this.dgvRaces.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRaces.Name = "dgvRaces";
            this.dgvRaces.RowHeadersWidth = 51;
            this.dgvRaces.Size = new System.Drawing.Size(360, 122);
            this.dgvRaces.TabIndex = 1;
            this.dgvRaces.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRaces_CellContentClick);
            // 
            // lblTitrePlanete
            // 
            this.lblTitrePlanete.AutoSize = true;
            this.lblTitrePlanete.Location = new System.Drawing.Point(33, 7);
            this.lblTitrePlanete.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitrePlanete.Name = "lblTitrePlanete";
            this.lblTitrePlanete.Size = new System.Drawing.Size(0, 13);
            this.lblTitrePlanete.TabIndex = 3;
            // 
            // pnlBas
            // 
            this.pnlBas.BackColor = System.Drawing.Color.Transparent;
            this.pnlBas.Controls.Add(this.btnRetour);
            this.pnlBas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBas.Location = new System.Drawing.Point(0, 615);
            this.pnlBas.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBas.Name = "pnlBas";
            this.pnlBas.Size = new System.Drawing.Size(1063, 44);
            this.pnlBas.TabIndex = 2;
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnRetour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRetour.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnRetour.FlatAppearance.BorderSize = 0;
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnRetour.ForeColor = System.Drawing.Color.Transparent;
            this.btnRetour.Location = new System.Drawing.Point(2, 2);
            this.btnRetour.Margin = new System.Windows.Forms.Padding(2);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(126, 40);
            this.btnRetour.TabIndex = 0;
            this.btnRetour.Text = "← Retour";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // pnlNotif
            // 
            this.pnlNotif.BackColor = System.Drawing.Color.Red;
            this.pnlNotif.Controls.Add(this.lblNotif);
            this.pnlNotif.ForeColor = System.Drawing.Color.Snow;
            this.pnlNotif.Location = new System.Drawing.Point(2, 0);
            this.pnlNotif.Margin = new System.Windows.Forms.Padding(2);
            this.pnlNotif.Name = "pnlNotif";
            this.pnlNotif.Size = new System.Drawing.Size(295, 20);
            this.pnlNotif.TabIndex = 1;
            this.pnlNotif.Visible = false;
            // 
            // lblNotif
            // 
            this.lblNotif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNotif.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNotif.Location = new System.Drawing.Point(0, 0);
            this.lblNotif.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNotif.Name = "lblNotif";
            this.lblNotif.Size = new System.Drawing.Size(295, 20);
            this.lblNotif.TabIndex = 0;
            this.lblNotif.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPlanetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1063, 659);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnlNotif);
            this.Controls.Add(this.pnlBas);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPlanetes";
            this.Text = " Stargate — Planètes";
            this.Load += new System.EventHandler(this.FormPlanetes_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaces)).EndInit();
            this.pnlBas.ResumeLayout(false);
            this.pnlNotif.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flpPlanetes;
        private System.Windows.Forms.Panel pnlBas;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRaces;
        private System.Windows.Forms.Label lblTitrePlanete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlNotif;
        private System.Windows.Forms.Label lblNotif;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lblMissions;
    }
}
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flpPlanetes = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlBas = new System.Windows.Forms.Panel();
            this.btnRetour = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMissions = new System.Windows.Forms.ListBox();
            this.dgvRaces = new System.Windows.Forms.DataGridView();
            this.lblTitrePlanete = new System.Windows.Forms.Label();
            this.pnlNotif = new System.Windows.Forms.Panel();
            this.lblNotif = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaces)).BeginInit();
            this.pnlNotif.SuspendLayout();
            this.pnlBas.SuspendLayout();
            this.SuspendLayout();

            // pnlBas — barre du bas fixe
            this.pnlBas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBas.Height = 45;
            this.pnlBas.Name = "pnlBas";
            this.pnlBas.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.pnlBas.Controls.Add(this.btnRetour);

            // btnRetour — dans pnlBas
            this.btnRetour.Location = new System.Drawing.Point(10, 5);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(110, 35);
            this.btnRetour.Text = "← Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);

            // splitContainer1
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.SplitterDistance = 419;
            this.splitContainer1.TabIndex = 0;

            // splitContainer1.Panel1
            this.splitContainer1.Panel1.Controls.Add(this.flpPlanetes);

            // splitContainer1.Panel2
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.lbMissions);
            this.splitContainer1.Panel2.Controls.Add(this.dgvRaces);
            this.splitContainer1.Panel2.Controls.Add(this.lblTitrePlanete);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(972, 609);

            // flpPlanetes
            this.flpPlanetes.AutoScroll = true;
            this.flpPlanetes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPlanetes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpPlanetes.Location = new System.Drawing.Point(0, 0);
            this.flpPlanetes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flpPlanetes.Name = "flpPlanetes";
            this.flpPlanetes.WrapContents = false;

            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 246);
            this.label2.Name = "label2";
            this.label2.Text = "Missions effectuées :";

            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 39);
            this.label1.Name = "label1";
            this.label1.Text = "Races présentes :";

            // lbMissions
            this.lbMissions.FormattingEnabled = true;
            this.lbMissions.HorizontalScrollbar = true;
            this.lbMissions.Location = new System.Drawing.Point(47, 277);
            this.lbMissions.Name = "lbMissions";
            this.lbMissions.Size = new System.Drawing.Size(480, 148);
            this.lbMissions.TabIndex = 2;

            // dgvRaces
            this.dgvRaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaces.Location = new System.Drawing.Point(47, 76);
            this.dgvRaces.Name = "dgvRaces";
            this.dgvRaces.RowHeadersWidth = 51;
            this.dgvRaces.Size = new System.Drawing.Size(480, 150);
            this.dgvRaces.TabIndex = 1;
            this.dgvRaces.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRaces_CellContentClick);

            // lblTitrePlanete
            this.lblTitrePlanete.AutoSize = true;
            this.lblTitrePlanete.Location = new System.Drawing.Point(44, 9);
            this.lblTitrePlanete.Name = "lblTitrePlanete";
            this.lblTitrePlanete.Text = "";

            // pnlNotif
            this.pnlNotif.BackColor = System.Drawing.Color.Red;
            this.pnlNotif.Controls.Add(this.lblNotif);
            this.pnlNotif.ForeColor = System.Drawing.Color.Snow;
            this.pnlNotif.Location = new System.Drawing.Point(3, 0);
            this.pnlNotif.Name = "pnlNotif";
            this.pnlNotif.Size = new System.Drawing.Size(393, 25);
            this.pnlNotif.Visible = false;

            // lblNotif
            this.lblNotif.AutoSize = false;
            this.lblNotif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNotif.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNotif.Name = "lblNotif";
            this.lblNotif.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // FormPlanetes
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 654);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnlNotif);
            this.Controls.Add(this.pnlBas);
            this.Name = "FormPlanetes";
            this.Text = "🌍 Stargate — Planètes";
            this.Load += new System.EventHandler(this.FormPlanetes_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaces)).EndInit();
            this.pnlNotif.ResumeLayout(false);
            this.pnlBas.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flpPlanetes;
        private System.Windows.Forms.Panel pnlBas;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbMissions;
        private System.Windows.Forms.DataGridView dgvRaces;
        private System.Windows.Forms.Label lblTitrePlanete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlNotif;
        private System.Windows.Forms.Label lblNotif;
    }
}
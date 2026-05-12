namespace appStargate
{
    partial class FormPlanetes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flpPlanetes = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlDetail = new System.Windows.Forms.Panel();
            this.lblTitrePlanete = new System.Windows.Forms.Label();
            this.dgvRaces = new System.Windows.Forms.DataGridView();
            this.lbMissions = new System.Windows.Forms.ListBox();
            this.flpPlanetes.SuspendLayout();
            this.pnlDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaces)).BeginInit();
            this.SuspendLayout();
            // 
            // flpPlanetes
            // 
            this.flpPlanetes.AutoScroll = true;
            this.flpPlanetes.Controls.Add(this.pnlDetail);
            this.flpPlanetes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPlanetes.Location = new System.Drawing.Point(0, 0);
            this.flpPlanetes.Name = "flpPlanetes";
            this.flpPlanetes.Size = new System.Drawing.Size(800, 450);
            this.flpPlanetes.TabIndex = 0;
            this.flpPlanetes.Paint += new System.Windows.Forms.PaintEventHandler(this.flpPlanetes_Paint);
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.lbMissions);
            this.pnlDetail.Controls.Add(this.dgvRaces);
            this.pnlDetail.Controls.Add(this.lblTitrePlanete);
            this.pnlDetail.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDetail.Location = new System.Drawing.Point(3, 3);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(400, 0);
            this.pnlDetail.TabIndex = 0;
            this.pnlDetail.Visible = false;
            // 
            // lblTitrePlanete
            // 
            this.lblTitrePlanete.AutoSize = true;
            this.lblTitrePlanete.Location = new System.Drawing.Point(147, -3);
            this.lblTitrePlanete.Name = "lblTitrePlanete";
            this.lblTitrePlanete.Size = new System.Drawing.Size(0, 16);
            this.lblTitrePlanete.TabIndex = 1;
            // 
            // dgvRaces
            // 
            this.dgvRaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaces.Location = new System.Drawing.Point(49, 0);
            this.dgvRaces.Name = "dgvRaces";
            this.dgvRaces.RowHeadersWidth = 51;
            this.dgvRaces.RowTemplate.Height = 24;
            this.dgvRaces.Size = new System.Drawing.Size(240, 150);
            this.dgvRaces.TabIndex = 1;
            // 
            // lbMissions
            // 
            this.lbMissions.FormattingEnabled = true;
            this.lbMissions.ItemHeight = 16;
            this.lbMissions.Location = new System.Drawing.Point(-44, 25);
            this.lbMissions.Name = "lbMissions";
            this.lbMissions.Size = new System.Drawing.Size(120, 84);
            this.lbMissions.TabIndex = 1;
            // 
            // FormPlanetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flpPlanetes);
            this.Name = "FormPlanetes";
            this.Text = "FormPlanetes";
            this.flpPlanetes.ResumeLayout(false);
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaces)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpPlanetes;
        private System.Windows.Forms.Panel pnlDetail;
        private System.Windows.Forms.Label lblTitrePlanete;
        private System.Windows.Forms.ListBox lbMissions;
        private System.Windows.Forms.DataGridView dgvRaces;
    }
}
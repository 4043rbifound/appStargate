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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flpPlanetes = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitrePlanete = new System.Windows.Forms.Label();
            this.dgvRaces = new System.Windows.Forms.DataGridView();
            this.lbMissions = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaces)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flpPlanetes);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.lbMissions);
            this.splitContainer1.Panel2.Controls.Add(this.dgvRaces);
            this.splitContainer1.Panel2.Controls.Add(this.lblTitrePlanete);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // flpPlanetes
            // 
            this.flpPlanetes.AutoScroll = true;
            this.flpPlanetes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPlanetes.Location = new System.Drawing.Point(0, 0);
            this.flpPlanetes.Name = "flpPlanetes";
            this.flpPlanetes.Size = new System.Drawing.Size(266, 450);
            this.flpPlanetes.TabIndex = 0;
            // 
            // lblTitrePlanete
            // 
            this.lblTitrePlanete.AutoSize = true;
            this.lblTitrePlanete.Location = new System.Drawing.Point(44, 9);
            this.lblTitrePlanete.Name = "lblTitrePlanete";
            this.lblTitrePlanete.Size = new System.Drawing.Size(44, 16);
            this.lblTitrePlanete.TabIndex = 0;
            this.lblTitrePlanete.Text = "label1";
            // 
            // dgvRaces
            // 
            this.dgvRaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaces.Location = new System.Drawing.Point(47, 76);
            this.dgvRaces.Name = "dgvRaces";
            this.dgvRaces.RowHeadersWidth = 51;
            this.dgvRaces.RowTemplate.Height = 24;
            this.dgvRaces.Size = new System.Drawing.Size(480, 150);
            this.dgvRaces.TabIndex = 1;
            // 
            // lbMissions
            // 
            this.lbMissions.FormattingEnabled = true;
            this.lbMissions.HorizontalScrollbar = true;
            this.lbMissions.ItemHeight = 16;
            this.lbMissions.Location = new System.Drawing.Point(47, 277);
            this.lbMissions.Name = "lbMissions";
            this.lbMissions.Size = new System.Drawing.Size(480, 148);
            this.lbMissions.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Races présentes :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Missions effectuées :";
            // 
            // FormPlanetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormPlanetes";
            this.Text = "FormPlanetes";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaces)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flpPlanetes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbMissions;
        private System.Windows.Forms.DataGridView dgvRaces;
        private System.Windows.Forms.Label lblTitrePlanete;
        private System.Windows.Forms.Label label2;
    }
}
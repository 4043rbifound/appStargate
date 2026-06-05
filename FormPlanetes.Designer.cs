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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flpPlanetes = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.chartRaces = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMissions = new System.Windows.Forms.ListBox();
            this.dgvRaces = new System.Windows.Forms.DataGridView();
            this.lblTitrePlanete = new System.Windows.Forms.Label();
            this.pnlNotif = new System.Windows.Forms.Panel();
            this.lblNotif = new System.Windows.Forms.Label();
            this.pctQuitter = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flpPlanetes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaces)).BeginInit();
            this.pnlNotif.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctQuitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flpPlanetes);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pctQuitter);
            this.splitContainer1.Panel2.Controls.Add(this.chartRaces);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox10);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.lbMissions);
            this.splitContainer1.Panel2.Controls.Add(this.dgvRaces);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel2_MouseDown);
            this.splitContainer1.Panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel2_MouseMove);
            this.splitContainer1.Size = new System.Drawing.Size(1094, 897);
            this.splitContainer1.SplitterDistance = 361;
            this.splitContainer1.TabIndex = 0;
            // 
            // flpPlanetes
            // 
            this.flpPlanetes.AutoScroll = true;
            this.flpPlanetes.Controls.Add(this.button1);
            this.flpPlanetes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPlanetes.Location = new System.Drawing.Point(0, 0);
            this.flpPlanetes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpPlanetes.Name = "flpPlanetes";
            this.flpPlanetes.Size = new System.Drawing.Size(361, 897);
            this.flpPlanetes.TabIndex = 0;
            this.flpPlanetes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flpPlanetes_MouseDown);
            this.flpPlanetes.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flpPlanetes_MouseMove);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 122);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // chartRaces
            // 
            this.chartRaces.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartRaces.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRaces.Legends.Add(legend1);
            this.chartRaces.Location = new System.Drawing.Point(21, 548);
            this.chartRaces.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chartRaces.Name = "chartRaces";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartRaces.Series.Add(series1);
            this.chartRaces.Size = new System.Drawing.Size(425, 345);
            this.chartRaces.TabIndex = 5;
            this.chartRaces.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Missions effectuées :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Races présentes :";
            // 
            // lbMissions
            // 
            this.lbMissions.FormattingEnabled = true;
            this.lbMissions.HorizontalScrollbar = true;
            this.lbMissions.ItemHeight = 20;
            this.lbMissions.Location = new System.Drawing.Point(20, 346);
            this.lbMissions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbMissions.Name = "lbMissions";
            this.lbMissions.Size = new System.Drawing.Size(591, 184);
            this.lbMissions.TabIndex = 2;
            // 
            // dgvRaces
            // 
            this.dgvRaces.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRaces.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvRaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRaces.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRaces.Location = new System.Drawing.Point(20, 118);
            this.dgvRaces.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRaces.Name = "dgvRaces";
            this.dgvRaces.RowHeadersWidth = 51;
            this.dgvRaces.RowTemplate.Height = 24;
            this.dgvRaces.Size = new System.Drawing.Size(591, 188);
            this.dgvRaces.TabIndex = 1;
            this.dgvRaces.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRaces_CellContentClick);
            // 
            // lblTitrePlanete
            // 
            this.lblTitrePlanete.AutoSize = true;
            this.lblTitrePlanete.Location = new System.Drawing.Point(379, 11);
            this.lblTitrePlanete.Name = "lblTitrePlanete";
            this.lblTitrePlanete.Size = new System.Drawing.Size(51, 20);
            this.lblTitrePlanete.TabIndex = 0;
            this.lblTitrePlanete.Text = "label1";
            // 
            // pnlNotif
            // 
            this.pnlNotif.BackColor = System.Drawing.Color.Red;
            this.pnlNotif.Controls.Add(this.lblNotif);
            this.pnlNotif.Controls.Add(this.lblTitrePlanete);
            this.pnlNotif.ForeColor = System.Drawing.Color.Snow;
            this.pnlNotif.Location = new System.Drawing.Point(3, 0);
            this.pnlNotif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlNotif.Name = "pnlNotif";
            this.pnlNotif.Size = new System.Drawing.Size(442, 31);
            this.pnlNotif.TabIndex = 1;
            this.pnlNotif.Visible = false;
            // 
            // lblNotif
            // 
            this.lblNotif.AutoSize = true;
            this.lblNotif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNotif.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotif.Location = new System.Drawing.Point(0, 0);
            this.lblNotif.Name = "lblNotif";
            this.lblNotif.Size = new System.Drawing.Size(75, 28);
            this.lblNotif.TabIndex = 0;
            this.lblNotif.Text = "label3";
            this.lblNotif.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pctQuitter
            // 
            this.pctQuitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.pctQuitter.BackgroundImage = global::appStargate.Properties.Resources.croix;
            this.pctQuitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctQuitter.Location = new System.Drawing.Point(631, 0);
            this.pctQuitter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctQuitter.Name = "pctQuitter";
            this.pctQuitter.Size = new System.Drawing.Size(98, 94);
            this.pctQuitter.TabIndex = 84;
            this.pctQuitter.TabStop = false;
            this.pctQuitter.Click += new System.EventHandler(this.pctQuitter_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImage = global::appStargate.Properties.Resources._out;
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox10.Location = new System.Drawing.Point(505, 0);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(97, 94);
            this.pictureBox10.TabIndex = 83;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // FormPlanetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1094, 897);
            this.Controls.Add(this.pnlNotif);
            this.Controls.Add(this.splitContainer1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPlanetes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormPlanetes";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flpPlanetes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaces)).EndInit();
            this.pnlNotif.ResumeLayout(false);
            this.pnlNotif.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctQuitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
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
        private System.Windows.Forms.Panel pnlNotif;
        private System.Windows.Forms.Label lblNotif;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRaces;
        private System.Windows.Forms.PictureBox pctQuitter;
        private System.Windows.Forms.PictureBox pictureBox10;
    }
}
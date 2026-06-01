namespace appStargate
{
    partial class FormStats
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
            this.pnlBas = new System.Windows.Forms.Panel();
            this.tabStats = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnRetour = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMembres = new System.Windows.Forms.ComboBox();
            this.dgvMembresCommuns = new System.Windows.Forms.DataGridView();
            this.dgvMissionsGrandes = new System.Windows.Forms.DataGridView();
            this.dgvMissionsPlanete = new System.Windows.Forms.DataGridView();
            this.dgvDepensesMax = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cboMissions = new System.Windows.Forms.ComboBox();
            this.dgvInformateurs = new System.Windows.Forms.DataGridView();
            this.pnlBas.SuspendLayout();
            this.tabStats.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembresCommuns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMissionsGrandes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMissionsPlanete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepensesMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformateurs)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBas
            // 
            this.pnlBas.Controls.Add(this.btnRetour);
            this.pnlBas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBas.Location = new System.Drawing.Point(0, 405);
            this.pnlBas.Name = "pnlBas";
            this.pnlBas.Size = new System.Drawing.Size(800, 45);
            this.pnlBas.TabIndex = 0;
            // 
            // tabStats
            // 
            this.tabStats.Controls.Add(this.tabPage1);
            this.tabStats.Controls.Add(this.tabPage2);
            this.tabStats.Controls.Add(this.tabPage3);
            this.tabStats.Controls.Add(this.tabPage4);
            this.tabStats.Controls.Add(this.tabPage5);
            this.tabStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabStats.Location = new System.Drawing.Point(0, 0);
            this.tabStats.Name = "tabStats";
            this.tabStats.SelectedIndex = 0;
            this.tabStats.Size = new System.Drawing.Size(800, 405);
            this.tabStats.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvMembresCommuns);
            this.tabPage1.Controls.Add(this.cboMembres);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 379);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Membres communs";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvMissionsGrandes);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 379);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Missions > 10";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvMissionsPlanete);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 379);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Missions par planète";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgvDepensesMax);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(792, 379);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Dépenses max";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dgvInformateurs);
            this.tabPage5.Controls.Add(this.cboMissions);
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(792, 379);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Informateurs";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(12, 6);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(110, 35);
            this.btnRetour.TabIndex = 0;
            this.btnRetour.Text = "← Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // cboMembres
            // 
            this.cboMembres.FormattingEnabled = true;
            this.cboMembres.Location = new System.Drawing.Point(10, 40);
            this.cboMembres.Name = "cboMembres";
            this.cboMembres.Size = new System.Drawing.Size(300, 21);
            this.cboMembres.TabIndex = 1;
            this.cboMembres.SelectedIndexChanged += new System.EventHandler(this.cboMissions_SelectedIndexChanged);
            // 
            // dgvMembresCommuns
            // 
            this.dgvMembresCommuns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembresCommuns.Location = new System.Drawing.Point(3, 67);
            this.dgvMembresCommuns.Name = "dgvMembresCommuns";
            this.dgvMembresCommuns.Size = new System.Drawing.Size(789, 312);
            this.dgvMembresCommuns.TabIndex = 2;
            // 
            // dgvMissionsGrandes
            // 
            this.dgvMissionsGrandes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMissionsGrandes.Location = new System.Drawing.Point(10, 10);
            this.dgvMissionsGrandes.Name = "dgvMissionsGrandes";
            this.dgvMissionsGrandes.Size = new System.Drawing.Size(782, 369);
            this.dgvMissionsGrandes.TabIndex = 0;
            // 
            // dgvMissionsPlanete
            // 
            this.dgvMissionsPlanete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMissionsPlanete.Location = new System.Drawing.Point(10, 10);
            this.dgvMissionsPlanete.Name = "dgvMissionsPlanete";
            this.dgvMissionsPlanete.Size = new System.Drawing.Size(782, 369);
            this.dgvMissionsPlanete.TabIndex = 0;
            // 
            // dgvDepensesMax
            // 
            this.dgvDepensesMax.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepensesMax.Location = new System.Drawing.Point(10, 10);
            this.dgvDepensesMax.Name = "dgvDepensesMax";
            this.dgvDepensesMax.Size = new System.Drawing.Size(782, 369);
            this.dgvDepensesMax.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // cboMissions
            // 
            this.cboMissions.FormattingEnabled = true;
            this.cboMissions.Location = new System.Drawing.Point(10, 40);
            this.cboMissions.Name = "cboMissions";
            this.cboMissions.Size = new System.Drawing.Size(121, 21);
            this.cboMissions.TabIndex = 1;
            this.cboMissions.SelectedIndexChanged += new System.EventHandler(this.cboMissions_SelectedIndexChanged);
            // 
            // dgvInformateurs
            // 
            this.dgvInformateurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformateurs.Location = new System.Drawing.Point(10, 80);
            this.dgvInformateurs.Name = "dgvInformateurs";
            this.dgvInformateurs.Size = new System.Drawing.Size(782, 299);
            this.dgvInformateurs.TabIndex = 2;
            // 
            // FormStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabStats);
            this.Controls.Add(this.pnlBas);
            this.Name = "FormStats";
            this.Text = "FormStats";
            this.pnlBas.ResumeLayout(false);
            this.tabStats.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembresCommuns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMissionsGrandes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMissionsPlanete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepensesMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformateurs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBas;
        private System.Windows.Forms.TabControl tabStats;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMembresCommuns;
        private System.Windows.Forms.ComboBox cboMembres;
        private System.Windows.Forms.DataGridView dgvMissionsGrandes;
        private System.Windows.Forms.DataGridView dgvMissionsPlanete;
        private System.Windows.Forms.DataGridView dgvDepensesMax;
        private System.Windows.Forms.DataGridView dgvInformateurs;
        private System.Windows.Forms.ComboBox cboMissions;
        private System.Windows.Forms.Label label2;
    }
}
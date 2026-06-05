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
            this.tabStats = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rtbMembresCommuns = new System.Windows.Forms.RichTextBox();
            this.cboMembres = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rtbMissionsGrandes = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rtbMissionsPlanete = new System.Windows.Forms.RichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.rtbDepensesMax = new System.Windows.Forms.RichTextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.rtbInformateurs = new System.Windows.Forms.RichTextBox();
            this.cboMissions = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlBas = new System.Windows.Forms.Panel();
            this.btnRetour = new System.Windows.Forms.Button();
            this.lblBouger = new System.Windows.Forms.Label();
            this.tabStats.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.pnlBas.SuspendLayout();
            this.SuspendLayout();
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
            this.tabStats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabStats.Name = "tabStats";
            this.tabStats.SelectedIndex = 0;
            this.tabStats.Size = new System.Drawing.Size(666, 679);
            this.tabStats.TabIndex = 0;
            this.tabStats.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabStats_MouseDown);
            this.tabStats.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tabStats_MouseMove);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.tabPage1.Controls.Add(this.rtbMembresCommuns);
            this.tabPage1.Controls.Add(this.cboMembres);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(658, 646);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Membres communs";
            // 
            // rtbMembresCommuns
            // 
            this.rtbMembresCommuns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.rtbMembresCommuns.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbMembresCommuns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbMembresCommuns.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbMembresCommuns.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.rtbMembresCommuns.Location = new System.Drawing.Point(4, 66);
            this.rtbMembresCommuns.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbMembresCommuns.Name = "rtbMembresCommuns";
            this.rtbMembresCommuns.ReadOnly = true;
            this.rtbMembresCommuns.Size = new System.Drawing.Size(650, 575);
            this.rtbMembresCommuns.TabIndex = 2;
            this.rtbMembresCommuns.Text = "";
            // 
            // cboMembres
            // 
            this.cboMembres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.cboMembres.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboMembres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMembres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.cboMembres.FormattingEnabled = true;
            this.cboMembres.Location = new System.Drawing.Point(4, 38);
            this.cboMembres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboMembres.Name = "cboMembres";
            this.cboMembres.Size = new System.Drawing.Size(650, 28);
            this.cboMembres.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sélectionner un membre :";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.tabPage2.Controls.Add(this.rtbMissionsGrandes);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(658, 646);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Missions > 10";
            // 
            // rtbMissionsGrandes
            // 
            this.rtbMissionsGrandes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.rtbMissionsGrandes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbMissionsGrandes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbMissionsGrandes.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbMissionsGrandes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.rtbMissionsGrandes.Location = new System.Drawing.Point(4, 5);
            this.rtbMissionsGrandes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbMissionsGrandes.Name = "rtbMissionsGrandes";
            this.rtbMissionsGrandes.ReadOnly = true;
            this.rtbMissionsGrandes.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbMissionsGrandes.Size = new System.Drawing.Size(650, 636);
            this.rtbMissionsGrandes.TabIndex = 0;
            this.rtbMissionsGrandes.Text = "";
            this.rtbMissionsGrandes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rtbMissionsGrandes_MouseDown);
            this.rtbMissionsGrandes.MouseMove += new System.Windows.Forms.MouseEventHandler(this.rtbMissionsGrandes_MouseMove);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.tabPage3.Controls.Add(this.rtbMissionsPlanete);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Size = new System.Drawing.Size(658, 646);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Missions par planète";
            // 
            // rtbMissionsPlanete
            // 
            this.rtbMissionsPlanete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.rtbMissionsPlanete.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbMissionsPlanete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbMissionsPlanete.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbMissionsPlanete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.rtbMissionsPlanete.Location = new System.Drawing.Point(4, 5);
            this.rtbMissionsPlanete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbMissionsPlanete.Name = "rtbMissionsPlanete";
            this.rtbMissionsPlanete.ReadOnly = true;
            this.rtbMissionsPlanete.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbMissionsPlanete.Size = new System.Drawing.Size(650, 636);
            this.rtbMissionsPlanete.TabIndex = 0;
            this.rtbMissionsPlanete.Text = "";
            this.rtbMissionsPlanete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rtbMissionsPlanete_MouseDown);
            this.rtbMissionsPlanete.MouseMove += new System.Windows.Forms.MouseEventHandler(this.rtbMissionsPlanete_MouseMove);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.tabPage4.Controls.Add(this.rtbDepensesMax);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage4.Size = new System.Drawing.Size(658, 646);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Dépenses max";
            // 
            // rtbDepensesMax
            // 
            this.rtbDepensesMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.rtbDepensesMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDepensesMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDepensesMax.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDepensesMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.rtbDepensesMax.Location = new System.Drawing.Point(4, 5);
            this.rtbDepensesMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbDepensesMax.Name = "rtbDepensesMax";
            this.rtbDepensesMax.ReadOnly = true;
            this.rtbDepensesMax.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbDepensesMax.Size = new System.Drawing.Size(650, 636);
            this.rtbDepensesMax.TabIndex = 3;
            this.rtbDepensesMax.Text = "";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.tabPage5.Controls.Add(this.rtbInformateurs);
            this.tabPage5.Controls.Add(this.cboMissions);
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage5.Size = new System.Drawing.Size(658, 646);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Informateurs";
            // 
            // rtbInformateurs
            // 
            this.rtbInformateurs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.rtbInformateurs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbInformateurs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbInformateurs.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbInformateurs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.rtbInformateurs.Location = new System.Drawing.Point(4, 66);
            this.rtbInformateurs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbInformateurs.Name = "rtbInformateurs";
            this.rtbInformateurs.ReadOnly = true;
            this.rtbInformateurs.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbInformateurs.Size = new System.Drawing.Size(650, 575);
            this.rtbInformateurs.TabIndex = 8;
            this.rtbInformateurs.Text = "";
            this.rtbInformateurs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rtbInformateurs_MouseDown);
            this.rtbInformateurs.MouseMove += new System.Windows.Forms.MouseEventHandler(this.rtbInformateurs_MouseMove);
            // 
            // cboMissions
            // 
            this.cboMissions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.cboMissions.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboMissions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.cboMissions.FormattingEnabled = true;
            this.cboMissions.Location = new System.Drawing.Point(4, 38);
            this.cboMissions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboMissions.Name = "cboMissions";
            this.cboMissions.Size = new System.Drawing.Size(650, 28);
            this.cboMissions.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(4, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sélectionner une mission :";
            // 
            // pnlBas
            // 
            this.pnlBas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.pnlBas.Controls.Add(this.lblBouger);
            this.pnlBas.Controls.Add(this.btnRetour);
            this.pnlBas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBas.Location = new System.Drawing.Point(0, 610);
            this.pnlBas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlBas.Name = "pnlBas";
            this.pnlBas.Size = new System.Drawing.Size(666, 69);
            this.pnlBas.TabIndex = 1;
            this.pnlBas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBas_MouseDown);
            this.pnlBas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBas_MouseMove);
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetour.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.ForeColor = System.Drawing.Color.White;
            this.btnRetour.Location = new System.Drawing.Point(0, 0);
            this.btnRetour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(147, 69);
            this.btnRetour.TabIndex = 0;
            this.btnRetour.Text = "← Retour";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // lblBouger
            // 
            this.lblBouger.AutoSize = true;
            this.lblBouger.Location = new System.Drawing.Point(182, 27);
            this.lblBouger.Name = "lblBouger";
            this.lblBouger.Size = new System.Drawing.Size(438, 20);
            this.lblBouger.TabIndex = 1;
            this.lblBouger.Text = "(cet espace permet de modifer l\'emplacement de cette page)";
            this.lblBouger.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblBouger_MouseDown);
            this.lblBouger.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblBouger_MouseMove);
            // 
            // FormStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(666, 679);
            this.Controls.Add(this.pnlBas);
            this.Controls.Add(this.tabStats);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormStats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormStats";
            this.tabStats.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.pnlBas.ResumeLayout(false);
            this.pnlBas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabStats;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel pnlBas;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.RichTextBox rtbMembresCommuns;
        private System.Windows.Forms.ComboBox cboMembres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.RichTextBox rtbMissionsGrandes;
        private System.Windows.Forms.RichTextBox rtbInformateurs;
        private System.Windows.Forms.ComboBox cboMissions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbDepensesMax;
        private System.Windows.Forms.RichTextBox rtbMissionsPlanete;
        private System.Windows.Forms.Label lblBouger;
    }
}
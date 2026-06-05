namespace appStargate
{
    partial class formEditMission
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
            this.grpModeEdition = new System.Windows.Forms.GroupBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.grpSaisie = new System.Windows.Forms.GroupBox();
            this.panelContact = new System.Windows.Forms.Panel();
            this.cboInformateur = new System.Windows.Forms.ComboBox();
            this.lblInformateur = new System.Windows.Forms.Label();
            this.txtAppreciation = new System.Windows.Forms.TextBox();
            this.txtSomme = new System.Windows.Forms.TextBox();
            this.lblAppreciation = new System.Windows.Forms.Label();
            this.lblSomme = new System.Windows.Forms.Label();
            this.dtpDateContact = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.panelDepense = new System.Windows.Forms.Panel();
            this.cboTypeDepense = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.lblMotif = new System.Windows.Forms.Label();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.lblMontant = new System.Windows.Forms.Label();
            this.dtpDateDepense = new System.Windows.Forms.DateTimePicker();
            this.lblDateDepense = new System.Windows.Forms.Label();
            this.panelEvenement = new System.Windows.Forms.Panel();
            this.txtCommentaires = new System.Windows.Forms.TextBox();
            this.lblCommentaires = new System.Windows.Forms.Label();
            this.dtpDateEvenement = new System.Windows.Forms.DateTimePicker();
            this.lblDateEvenement = new System.Windows.Forms.Label();
            this.picEvenement = new System.Windows.Forms.PictureBox();
            this.picDepense = new System.Windows.Forms.PictureBox();
            this.picContact = new System.Windows.Forms.PictureBox();
            this.grpModeEdition.SuspendLayout();
            this.grpSaisie.SuspendLayout();
            this.panelContact.SuspendLayout();
            this.panelDepense.SuspendLayout();
            this.panelEvenement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEvenement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDepense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picContact)).BeginInit();
            this.SuspendLayout();
            // 
            // grpModeEdition
            // 
            this.grpModeEdition.Controls.Add(this.btnAnnuler);
            this.grpModeEdition.Controls.Add(this.btnValider);
            this.grpModeEdition.Controls.Add(this.grpSaisie);
            this.grpModeEdition.Controls.Add(this.picEvenement);
            this.grpModeEdition.Controls.Add(this.picDepense);
            this.grpModeEdition.Controls.Add(this.picContact);
            this.grpModeEdition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpModeEdition.Location = new System.Drawing.Point(31, 23);
            this.grpModeEdition.Name = "grpModeEdition";
            this.grpModeEdition.Size = new System.Drawing.Size(830, 1121);
            this.grpModeEdition.TabIndex = 0;
            this.grpModeEdition.TabStop = false;
            this.grpModeEdition.Text = "Mode Edition";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(416, 988);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(161, 66);
            this.btnAnnuler.TabIndex = 5;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click_1);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(601, 988);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(161, 66);
            this.btnValider.TabIndex = 4;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click_1);
            // 
            // grpSaisie
            // 
            this.grpSaisie.Controls.Add(this.panelContact);
            this.grpSaisie.Controls.Add(this.panelDepense);
            this.grpSaisie.Controls.Add(this.panelEvenement);
            this.grpSaisie.Location = new System.Drawing.Point(60, 182);
            this.grpSaisie.Name = "grpSaisie";
            this.grpSaisie.Size = new System.Drawing.Size(708, 777);
            this.grpSaisie.TabIndex = 3;
            this.grpSaisie.TabStop = false;
            // 
            // panelContact
            // 
            this.panelContact.Controls.Add(this.cboInformateur);
            this.panelContact.Controls.Add(this.lblInformateur);
            this.panelContact.Controls.Add(this.txtAppreciation);
            this.panelContact.Controls.Add(this.txtSomme);
            this.panelContact.Controls.Add(this.lblAppreciation);
            this.panelContact.Controls.Add(this.lblSomme);
            this.panelContact.Controls.Add(this.dtpDateContact);
            this.panelContact.Controls.Add(this.lblDate);
            this.panelContact.Location = new System.Drawing.Point(18, 28);
            this.panelContact.Name = "panelContact";
            this.panelContact.Size = new System.Drawing.Size(684, 726);
            this.panelContact.TabIndex = 0;
            // 
            // cboInformateur
            // 
            this.cboInformateur.FormattingEnabled = true;
            this.cboInformateur.Location = new System.Drawing.Point(227, 581);
            this.cboInformateur.Name = "cboInformateur";
            this.cboInformateur.Size = new System.Drawing.Size(439, 40);
            this.cboInformateur.TabIndex = 7;
            // 
            // lblInformateur
            // 
            this.lblInformateur.AutoSize = true;
            this.lblInformateur.Location = new System.Drawing.Point(11, 584);
            this.lblInformateur.Name = "lblInformateur";
            this.lblInformateur.Size = new System.Drawing.Size(172, 32);
            this.lblInformateur.TabIndex = 6;
            this.lblInformateur.Text = "Informateurs";
            // 
            // txtAppreciation
            // 
            this.txtAppreciation.AcceptsReturn = true;
            this.txtAppreciation.Location = new System.Drawing.Point(227, 183);
            this.txtAppreciation.Multiline = true;
            this.txtAppreciation.Name = "txtAppreciation";
            this.txtAppreciation.Size = new System.Drawing.Size(440, 367);
            this.txtAppreciation.TabIndex = 5;
            // 
            // txtSomme
            // 
            this.txtSomme.Location = new System.Drawing.Point(227, 123);
            this.txtSomme.Name = "txtSomme";
            this.txtSomme.Size = new System.Drawing.Size(181, 39);
            this.txtSomme.TabIndex = 4;
            // 
            // lblAppreciation
            // 
            this.lblAppreciation.AutoSize = true;
            this.lblAppreciation.Location = new System.Drawing.Point(11, 183);
            this.lblAppreciation.Name = "lblAppreciation";
            this.lblAppreciation.Size = new System.Drawing.Size(174, 32);
            this.lblAppreciation.TabIndex = 3;
            this.lblAppreciation.Text = "Appréciation";
            // 
            // lblSomme
            // 
            this.lblSomme.AutoSize = true;
            this.lblSomme.Location = new System.Drawing.Point(11, 123);
            this.lblSomme.Name = "lblSomme";
            this.lblSomme.Size = new System.Drawing.Size(111, 32);
            this.lblSomme.TabIndex = 2;
            this.lblSomme.Text = "Somme";
            // 
            // dtpDateContact
            // 
            this.dtpDateContact.Location = new System.Drawing.Point(227, 56);
            this.dtpDateContact.Name = "dtpDateContact";
            this.dtpDateContact.Size = new System.Drawing.Size(408, 39);
            this.dtpDateContact.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(11, 63);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(74, 32);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date";
            // 
            // panelDepense
            // 
            this.panelDepense.Controls.Add(this.cboTypeDepense);
            this.panelDepense.Controls.Add(this.lblType);
            this.panelDepense.Controls.Add(this.txtMotif);
            this.panelDepense.Controls.Add(this.lblMotif);
            this.panelDepense.Controls.Add(this.txtMontant);
            this.panelDepense.Controls.Add(this.lblMontant);
            this.panelDepense.Controls.Add(this.dtpDateDepense);
            this.panelDepense.Controls.Add(this.lblDateDepense);
            this.panelDepense.Location = new System.Drawing.Point(18, 31);
            this.panelDepense.Name = "panelDepense";
            this.panelDepense.Size = new System.Drawing.Size(684, 726);
            this.panelDepense.TabIndex = 1;
            // 
            // cboTypeDepense
            // 
            this.cboTypeDepense.FormattingEnabled = true;
            this.cboTypeDepense.Location = new System.Drawing.Point(176, 374);
            this.cboTypeDepense.Name = "cboTypeDepense";
            this.cboTypeDepense.Size = new System.Drawing.Size(332, 40);
            this.cboTypeDepense.TabIndex = 7;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(30, 382);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(98, 32);
            this.lblType.TabIndex = 6;
            this.lblType.Text = "Motif : ";
            // 
            // txtMotif
            // 
            this.txtMotif.Location = new System.Drawing.Point(176, 267);
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(173, 39);
            this.txtMotif.TabIndex = 5;
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(30, 274);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(98, 32);
            this.lblMotif.TabIndex = 4;
            this.lblMotif.Text = "Motif : ";
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(176, 173);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(173, 39);
            this.txtMontant.TabIndex = 3;
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(30, 180);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(132, 32);
            this.lblMontant.TabIndex = 2;
            this.lblMontant.Text = "Montant :";
            // 
            // dtpDateDepense
            // 
            this.dtpDateDepense.Location = new System.Drawing.Point(176, 60);
            this.dtpDateDepense.Name = "dtpDateDepense";
            this.dtpDateDepense.Size = new System.Drawing.Size(422, 39);
            this.dtpDateDepense.TabIndex = 1;
            // 
            // lblDateDepense
            // 
            this.lblDateDepense.AutoSize = true;
            this.lblDateDepense.Location = new System.Drawing.Point(30, 60);
            this.lblDateDepense.Name = "lblDateDepense";
            this.lblDateDepense.Size = new System.Drawing.Size(74, 32);
            this.lblDateDepense.TabIndex = 0;
            this.lblDateDepense.Text = "Date";
            // 
            // panelEvenement
            // 
            this.panelEvenement.Controls.Add(this.txtCommentaires);
            this.panelEvenement.Controls.Add(this.lblCommentaires);
            this.panelEvenement.Controls.Add(this.dtpDateEvenement);
            this.panelEvenement.Controls.Add(this.lblDateEvenement);
            this.panelEvenement.Location = new System.Drawing.Point(6, 31);
            this.panelEvenement.Name = "panelEvenement";
            this.panelEvenement.Size = new System.Drawing.Size(681, 729);
            this.panelEvenement.TabIndex = 2;
            // 
            // txtCommentaires
            // 
            this.txtCommentaires.Location = new System.Drawing.Point(160, 302);
            this.txtCommentaires.Multiline = true;
            this.txtCommentaires.Name = "txtCommentaires";
            this.txtCommentaires.Size = new System.Drawing.Size(460, 391);
            this.txtCommentaires.TabIndex = 3;
            // 
            // lblCommentaires
            // 
            this.lblCommentaires.AutoSize = true;
            this.lblCommentaires.Location = new System.Drawing.Point(45, 245);
            this.lblCommentaires.Name = "lblCommentaires";
            this.lblCommentaires.Size = new System.Drawing.Size(198, 32);
            this.lblCommentaires.TabIndex = 2;
            this.lblCommentaires.Text = "Commentaires";
            // 
            // dtpDateEvenement
            // 
            this.dtpDateEvenement.Location = new System.Drawing.Point(160, 116);
            this.dtpDateEvenement.Name = "dtpDateEvenement";
            this.dtpDateEvenement.Size = new System.Drawing.Size(460, 39);
            this.dtpDateEvenement.TabIndex = 1;
            // 
            // lblDateEvenement
            // 
            this.lblDateEvenement.AutoSize = true;
            this.lblDateEvenement.Location = new System.Drawing.Point(45, 123);
            this.lblDateEvenement.Name = "lblDateEvenement";
            this.lblDateEvenement.Size = new System.Drawing.Size(74, 32);
            this.lblDateEvenement.TabIndex = 0;
            this.lblDateEvenement.Text = "Date";
            // 
            // picEvenement
            // 
            this.picEvenement.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picEvenement.Location = new System.Drawing.Point(628, 68);
            this.picEvenement.Name = "picEvenement";
            this.picEvenement.Size = new System.Drawing.Size(140, 85);
            this.picEvenement.TabIndex = 2;
            this.picEvenement.TabStop = false;
            this.picEvenement.Click += new System.EventHandler(this.picEvenement_Click_1);
            // 
            // picDepense
            // 
            this.picDepense.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.picDepense.Location = new System.Drawing.Point(354, 68);
            this.picDepense.Name = "picDepense";
            this.picDepense.Size = new System.Drawing.Size(140, 85);
            this.picDepense.TabIndex = 1;
            this.picDepense.TabStop = false;
            this.picDepense.Click += new System.EventHandler(this.picDepense_Click_1);
            // 
            // picContact
            // 
            this.picContact.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picContact.Location = new System.Drawing.Point(60, 68);
            this.picContact.Name = "picContact";
            this.picContact.Size = new System.Drawing.Size(140, 85);
            this.picContact.TabIndex = 0;
            this.picContact.TabStop = false;
            this.picContact.Click += new System.EventHandler(this.picContact_Click_1);
            // 
            // formEditMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(888, 1156);
            this.Controls.Add(this.grpModeEdition);
            this.Name = "formEditMission";
            this.Text = "formEditMission";
//            this.Load += new System.EventHandler(this.formEditMission_Load_1);
            this.grpModeEdition.ResumeLayout(false);
            this.grpSaisie.ResumeLayout(false);
            this.panelContact.ResumeLayout(false);
            this.panelContact.PerformLayout();
            this.panelDepense.ResumeLayout(false);
            this.panelDepense.PerformLayout();
            this.panelEvenement.ResumeLayout(false);
            this.panelEvenement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEvenement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDepense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picContact)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpModeEdition;
        private System.Windows.Forms.PictureBox picEvenement;
        private System.Windows.Forms.PictureBox picDepense;
        private System.Windows.Forms.PictureBox picContact;
        private System.Windows.Forms.GroupBox grpSaisie;
        private System.Windows.Forms.Panel panelContact;
        private System.Windows.Forms.Label lblSomme;
        private System.Windows.Forms.DateTimePicker dtpDateContact;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtSomme;
        private System.Windows.Forms.Label lblAppreciation;
        private System.Windows.Forms.TextBox txtAppreciation;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.ComboBox cboInformateur;
        private System.Windows.Forms.Label lblInformateur;
        private System.Windows.Forms.Panel panelDepense;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.DateTimePicker dtpDateDepense;
        private System.Windows.Forms.Label lblDateDepense;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.ComboBox cboTypeDepense;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Panel panelEvenement;
        private System.Windows.Forms.TextBox txtCommentaires;
        private System.Windows.Forms.Label lblCommentaires;
        private System.Windows.Forms.DateTimePicker dtpDateEvenement;
        private System.Windows.Forms.Label lblDateEvenement;
    }
}
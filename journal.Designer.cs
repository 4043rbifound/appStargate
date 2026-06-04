namespace appStargate
{
    partial class journal
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
            this.lblJournal = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.dgvContacts = new System.Windows.Forms.DataGridView();
            this.lblTotalSommes = new System.Windows.Forms.Label();
            this.btnPremier = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnDernier = new System.Windows.Forms.Button();
            this.dgvDepenses = new System.Windows.Forms.DataGridView();
            this.lblTotalDepenses = new System.Windows.Forms.Label();
            this.lblDateJournal = new System.Windows.Forms.Label();
            this.lblCommentaireJournal = new System.Windows.Forms.Label();
            this.lblCompteur = new System.Windows.Forms.Label();
            this.dgvBilanCaptures = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilanCaptures)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJournal
            // 
            this.lblJournal.AutoSize = true;
            this.lblJournal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.lblJournal.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lblJournal.ForeColor = System.Drawing.Color.White;
            this.lblJournal.Location = new System.Drawing.Point(111, 26);
            this.lblJournal.Name = "lblJournal";
            this.lblJournal.Size = new System.Drawing.Size(375, 46);
            this.lblJournal.TabIndex = 42;
            this.lblJournal.Text = "Journal de Mission";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImage = global::appStargate.Properties.Resources._out;
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox10.Location = new System.Drawing.Point(-2, 932);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(97, 94);
            this.pictureBox10.TabIndex = 41;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::appStargate.Properties.Resources.logoSg;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 92);
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.pictureBox8.Location = new System.Drawing.Point(-3, -12);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(1621, 104);
            this.pictureBox8.TabIndex = 43;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.pictureBox9.Location = new System.Drawing.Point(-2, 89);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(96, 956);
            this.pictureBox9.TabIndex = 44;
            this.pictureBox9.TabStop = false;
            // 
            // dgvContacts
            // 
            this.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContacts.Location = new System.Drawing.Point(823, 145);
            this.dgvContacts.Name = "dgvContacts";
            this.dgvContacts.RowHeadersWidth = 62;
            this.dgvContacts.RowTemplate.Height = 28;
            this.dgvContacts.Size = new System.Drawing.Size(710, 399);
            this.dgvContacts.TabIndex = 46;
            // 
            // lblTotalSommes
            // 
            this.lblTotalSommes.AutoSize = true;
            this.lblTotalSommes.Location = new System.Drawing.Point(382, 571);
            this.lblTotalSommes.Name = "lblTotalSommes";
            this.lblTotalSommes.Size = new System.Drawing.Size(134, 20);
            this.lblTotalSommes.TabIndex = 47;
            this.lblTotalSommes.Text = "total des sommes";
            // 
            // btnPremier
            // 
            this.btnPremier.Location = new System.Drawing.Point(201, 339);
            this.btnPremier.Name = "btnPremier";
            this.btnPremier.Size = new System.Drawing.Size(91, 29);
            this.btnPremier.TabIndex = 48;
            this.btnPremier.Text = "<<";
            this.btnPremier.UseVisualStyleBackColor = true;
            this.btnPremier.Click += new System.EventHandler(this.btnPremier_Click);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Location = new System.Drawing.Point(313, 339);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(91, 29);
            this.btnPrecedent.TabIndex = 49;
            this.btnPrecedent.Text = "<";
            this.btnPrecedent.UseVisualStyleBackColor = true;
            this.btnPrecedent.Click += new System.EventHandler(this.btnPrecedent_Click);
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(436, 339);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(91, 29);
            this.btnSuivant.TabIndex = 50;
            this.btnSuivant.Text = ">";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // btnDernier
            // 
            this.btnDernier.Location = new System.Drawing.Point(562, 339);
            this.btnDernier.Name = "btnDernier";
            this.btnDernier.Size = new System.Drawing.Size(91, 29);
            this.btnDernier.TabIndex = 51;
            this.btnDernier.Text = ">>";
            this.btnDernier.UseVisualStyleBackColor = true;
            this.btnDernier.Click += new System.EventHandler(this.btnDernier_Click);
            // 
            // dgvDepenses
            // 
            this.dgvDepenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepenses.Location = new System.Drawing.Point(166, 615);
            this.dgvDepenses.Name = "dgvDepenses";
            this.dgvDepenses.RowHeadersWidth = 62;
            this.dgvDepenses.RowTemplate.Height = 28;
            this.dgvDepenses.Size = new System.Drawing.Size(710, 399);
            this.dgvDepenses.TabIndex = 52;
            // 
            // lblTotalDepenses
            // 
            this.lblTotalDepenses.AutoSize = true;
            this.lblTotalDepenses.Location = new System.Drawing.Point(1120, 585);
            this.lblTotalDepenses.Name = "lblTotalDepenses";
            this.lblTotalDepenses.Size = new System.Drawing.Size(148, 20);
            this.lblTotalDepenses.TabIndex = 53;
            this.lblTotalDepenses.Text = "Total des dépenses";
            // 
            // lblDateJournal
            // 
            this.lblDateJournal.AutoSize = true;
            this.lblDateJournal.Location = new System.Drawing.Point(162, 229);
            this.lblDateJournal.Name = "lblDateJournal";
            this.lblDateJournal.Size = new System.Drawing.Size(44, 20);
            this.lblDateJournal.TabIndex = 54;
            this.lblDateJournal.Text = "Date";
            // 
            // lblCommentaireJournal
            // 
            this.lblCommentaireJournal.AutoSize = true;
            this.lblCommentaireJournal.Location = new System.Drawing.Point(265, 229);
            this.lblCommentaireJournal.Name = "lblCommentaireJournal";
            this.lblCommentaireJournal.Size = new System.Drawing.Size(160, 20);
            this.lblCommentaireJournal.TabIndex = 55;
            this.lblCommentaireJournal.Text = "Commentaire Journal";
            // 
            // lblCompteur
            // 
            this.lblCompteur.AutoSize = true;
            this.lblCompteur.Location = new System.Drawing.Point(558, 472);
            this.lblCompteur.Name = "lblCompteur";
            this.lblCompteur.Size = new System.Drawing.Size(31, 20);
            this.lblCompteur.TabIndex = 56;
            this.lblCompteur.Text = "1/1";
            // 
            // dgvBilanCaptures
            // 
            this.dgvBilanCaptures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBilanCaptures.Location = new System.Drawing.Point(289, 145);
            this.dgvBilanCaptures.Name = "dgvBilanCaptures";
            this.dgvBilanCaptures.RowHeadersWidth = 62;
            this.dgvBilanCaptures.RowTemplate.Height = 28;
            this.dgvBilanCaptures.Size = new System.Drawing.Size(710, 238);
            this.dgvBilanCaptures.TabIndex = 57;
            // 
            // journal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1597, 1026);
            this.Controls.Add(this.dgvBilanCaptures);
            this.Controls.Add(this.lblCompteur);
            this.Controls.Add(this.lblCommentaireJournal);
            this.Controls.Add(this.lblDateJournal);
            this.Controls.Add(this.lblTotalDepenses);
            this.Controls.Add(this.dgvDepenses);
            this.Controls.Add(this.btnDernier);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.btnPrecedent);
            this.Controls.Add(this.btnPremier);
            this.Controls.Add(this.lblTotalSommes);
            this.Controls.Add(this.dgvContacts);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblJournal);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox9);
            this.MaximizeBox = false;
            this.Name = "journal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Journal de Mission :";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilanCaptures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblJournal;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.DataGridView dgvContacts;
        private System.Windows.Forms.Label lblTotalSommes;
        private System.Windows.Forms.Button btnPremier;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnDernier;
        private System.Windows.Forms.DataGridView dgvDepenses;
        private System.Windows.Forms.Label lblTotalDepenses;
        private System.Windows.Forms.Label lblDateJournal;
        private System.Windows.Forms.Label lblCommentaireJournal;
        private System.Windows.Forms.Label lblCompteur;
        private System.Windows.Forms.DataGridView dgvBilanCaptures;
    }
}
namespace appStargate
{
    partial class frmEquipageMission
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
            this.lblAffectationMembre = new System.Windows.Forms.Label();
            this.lblNbMembreaffecter = new System.Windows.Forms.Label();
            this.cboMembre = new System.Windows.Forms.ComboBox();
            this.btnAjouterMembre = new System.Windows.Forms.Button();
            this.lblObjCapture = new System.Windows.Forms.Label();
            this.cboAlien = new System.Windows.Forms.ComboBox();
            this.txtNbAlien = new System.Windows.Forms.TextBox();
            this.btnAjouterAlien = new System.Windows.Forms.Button();
            this.btnValiderMembre = new System.Windows.Forms.Button();
            this.richTxtAlien = new System.Windows.Forms.RichTextBox();
            this.richTxtMembre = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblAffectationMembre
            // 
            this.lblAffectationMembre.AutoSize = true;
            this.lblAffectationMembre.Location = new System.Drawing.Point(64, 79);
            this.lblAffectationMembre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAffectationMembre.Name = "lblAffectationMembre";
            this.lblAffectationMembre.Size = new System.Drawing.Size(560, 32);
            this.lblAffectationMembre.TabIndex = 0;
            this.lblAffectationMembre.Text = "Affectation des membres - reste à affecter : ";
            // 
            // lblNbMembreaffecter
            // 
            this.lblNbMembreaffecter.AutoSize = true;
            this.lblNbMembreaffecter.Location = new System.Drawing.Point(631, 79);
            this.lblNbMembreaffecter.Name = "lblNbMembreaffecter";
            this.lblNbMembreaffecter.Size = new System.Drawing.Size(30, 32);
            this.lblNbMembreaffecter.TabIndex = 2;
            this.lblNbMembreaffecter.Text = "0";
            // 
            // cboMembre
            // 
            this.cboMembre.FormattingEnabled = true;
            this.cboMembre.Location = new System.Drawing.Point(144, 144);
            this.cboMembre.Name = "cboMembre";
            this.cboMembre.Size = new System.Drawing.Size(830, 40);
            this.cboMembre.TabIndex = 3;
            // 
            // btnAjouterMembre
            // 
            this.btnAjouterMembre.Location = new System.Drawing.Point(1012, 143);
            this.btnAjouterMembre.Name = "btnAjouterMembre";
            this.btnAjouterMembre.Size = new System.Drawing.Size(195, 40);
            this.btnAjouterMembre.TabIndex = 4;
            this.btnAjouterMembre.Text = "Ajouter";
            this.btnAjouterMembre.UseVisualStyleBackColor = true;
            // 
            // lblObjCapture
            // 
            this.lblObjCapture.AutoSize = true;
            this.lblObjCapture.Location = new System.Drawing.Point(64, 677);
            this.lblObjCapture.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObjCapture.Name = "lblObjCapture";
            this.lblObjCapture.Size = new System.Drawing.Size(253, 32);
            this.lblObjCapture.TabIndex = 6;
            this.lblObjCapture.Text = "Objectif de capture";
            // 
            // cboAlien
            // 
            this.cboAlien.FormattingEnabled = true;
            this.cboAlien.Location = new System.Drawing.Point(144, 735);
            this.cboAlien.Name = "cboAlien";
            this.cboAlien.Size = new System.Drawing.Size(404, 40);
            this.cboAlien.TabIndex = 7;
            // 
            // txtNbAlien
            // 
            this.txtNbAlien.AcceptsReturn = true;
            this.txtNbAlien.Location = new System.Drawing.Point(581, 735);
            this.txtNbAlien.Name = "txtNbAlien";
            this.txtNbAlien.Size = new System.Drawing.Size(134, 39);
            this.txtNbAlien.TabIndex = 8;
            // 
            // btnAjouterAlien
            // 
            this.btnAjouterAlien.Location = new System.Drawing.Point(1012, 740);
            this.btnAjouterAlien.Name = "btnAjouterAlien";
            this.btnAjouterAlien.Size = new System.Drawing.Size(160, 35);
            this.btnAjouterAlien.TabIndex = 9;
            this.btnAjouterAlien.Text = "Ajouter";
            this.btnAjouterAlien.UseVisualStyleBackColor = true;
            // 
            // btnValiderMembre
            // 
            this.btnValiderMembre.Location = new System.Drawing.Point(1012, 590);
            this.btnValiderMembre.Name = "btnValiderMembre";
            this.btnValiderMembre.Size = new System.Drawing.Size(160, 35);
            this.btnValiderMembre.TabIndex = 10;
            this.btnValiderMembre.Text = "Valider membres";
            this.btnValiderMembre.UseVisualStyleBackColor = true;
            this.btnValiderMembre.Click += new System.EventHandler(this.btnValiderMembre_Click);
            // 
            // richTxtAlien
            // 
            this.richTxtAlien.Location = new System.Drawing.Point(144, 808);
            this.richTxtAlien.Name = "richTxtAlien";
            this.richTxtAlien.Size = new System.Drawing.Size(1054, 306);
            this.richTxtAlien.TabIndex = 11;
            this.richTxtAlien.Text = "";
            // 
            // richTxtMembre
            // 
            this.richTxtMembre.Location = new System.Drawing.Point(144, 259);
            this.richTxtMembre.Name = "richTxtMembre";
            this.richTxtMembre.Size = new System.Drawing.Size(1054, 306);
            this.richTxtMembre.TabIndex = 12;
            this.richTxtMembre.Text = "";
            // 
            // frmEquipageMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 1180);
            this.Controls.Add(this.richTxtMembre);
            this.Controls.Add(this.richTxtAlien);
            this.Controls.Add(this.btnValiderMembre);
            this.Controls.Add(this.btnAjouterAlien);
            this.Controls.Add(this.txtNbAlien);
            this.Controls.Add(this.cboAlien);
            this.Controls.Add(this.lblObjCapture);
            this.Controls.Add(this.btnAjouterMembre);
            this.Controls.Add(this.cboMembre);
            this.Controls.Add(this.lblNbMembreaffecter);
            this.Controls.Add(this.lblAffectationMembre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEquipageMission";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmEquipageMission_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAffectationMembre;
        private System.Windows.Forms.Label lblNbMembreaffecter;
        private System.Windows.Forms.ComboBox cboMembre;
        private System.Windows.Forms.Button btnAjouterMembre;
        private System.Windows.Forms.Label lblObjCapture;
        private System.Windows.Forms.ComboBox cboAlien;
        private System.Windows.Forms.TextBox txtNbAlien;
        private System.Windows.Forms.Button btnAjouterAlien;
        private System.Windows.Forms.Button btnValiderMembre;
        private System.Windows.Forms.RichTextBox richTxtAlien;
        private System.Windows.Forms.RichTextBox richTxtMembre;
    }
}
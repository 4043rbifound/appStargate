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
            this.components = new System.ComponentModel.Container();
            this.lblTitreMembres = new System.Windows.Forms.Label();
            this.lblNbMembreaffecter = new System.Windows.Forms.Label();
            this.cboMembres = new System.Windows.Forms.ComboBox();
            this.btnAjouterMembre = new System.Windows.Forms.Button();
            this.richtxtMembres = new System.Windows.Forms.RichTextBox();
            this.btnValiderMembres = new System.Windows.Forms.Button();
            this.lblTitreCaptures = new System.Windows.Forms.Label();
            this.cboAliens = new System.Windows.Forms.ComboBox();
            this.btnAjouterAlien = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtQuantiteAlien = new System.Windows.Forms.TextBox();
            this.richtxtAliens = new System.Windows.Forms.RichTextBox();
            this.btnValiderObjectifs = new System.Windows.Forms.Button();
            this.lblM = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pctQuitter = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctQuitter)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitreMembres
            // 
            this.lblTitreMembres.AutoSize = true;
            this.lblTitreMembres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.lblTitreMembres.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitreMembres.ForeColor = System.Drawing.Color.White;
            this.lblTitreMembres.Location = new System.Drawing.Point(520, 125);
            this.lblTitreMembres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitreMembres.Name = "lblTitreMembres";
            this.lblTitreMembres.Size = new System.Drawing.Size(228, 30);
            this.lblTitreMembres.TabIndex = 0;
            this.lblTitreMembres.Text = "Reste à affecter : ";
            // 
            // lblNbMembreaffecter
            // 
            this.lblNbMembreaffecter.AutoSize = true;
            this.lblNbMembreaffecter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.lblNbMembreaffecter.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.lblNbMembreaffecter.ForeColor = System.Drawing.Color.White;
            this.lblNbMembreaffecter.Location = new System.Drawing.Point(772, 125);
            this.lblNbMembreaffecter.Name = "lblNbMembreaffecter";
            this.lblNbMembreaffecter.Size = new System.Drawing.Size(27, 30);
            this.lblNbMembreaffecter.TabIndex = 1;
            this.lblNbMembreaffecter.Text = "0";
            // 
            // cboMembres
            // 
            this.cboMembres.FormattingEnabled = true;
            this.cboMembres.Location = new System.Drawing.Point(233, 208);
            this.cboMembres.Name = "cboMembres";
            this.cboMembres.Size = new System.Drawing.Size(861, 37);
            this.cboMembres.TabIndex = 2;
            this.cboMembres.SelectedIndexChanged += new System.EventHandler(this.cboMembres_SelectedIndexChanged);
            // 
            // btnAjouterMembre
            // 
            this.btnAjouterMembre.Location = new System.Drawing.Point(1121, 208);
            this.btnAjouterMembre.Name = "btnAjouterMembre";
            this.btnAjouterMembre.Size = new System.Drawing.Size(211, 40);
            this.btnAjouterMembre.TabIndex = 3;
            this.btnAjouterMembre.Text = "Ajouter";
            this.btnAjouterMembre.UseVisualStyleBackColor = true;
            this.btnAjouterMembre.Click += new System.EventHandler(this.btnAjouterMembre_Click_1);
            // 
            // richtxtMembres
            // 
            this.richtxtMembres.Location = new System.Drawing.Point(233, 265);
            this.richtxtMembres.Name = "richtxtMembres";
            this.richtxtMembres.Size = new System.Drawing.Size(1099, 200);
            this.richtxtMembres.TabIndex = 4;
            this.richtxtMembres.Text = "";
            // 
            // btnValiderMembres
            // 
            this.btnValiderMembres.Location = new System.Drawing.Point(233, 503);
            this.btnValiderMembres.Name = "btnValiderMembres";
            this.btnValiderMembres.Size = new System.Drawing.Size(1099, 40);
            this.btnValiderMembres.TabIndex = 5;
            this.btnValiderMembres.Text = "Valider membres";
            this.btnValiderMembres.UseVisualStyleBackColor = true;
            this.btnValiderMembres.Click += new System.EventHandler(this.btnValiderMembres_Click_2);
            // 
            // lblTitreCaptures
            // 
            this.lblTitreCaptures.AutoSize = true;
            this.lblTitreCaptures.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(87)))), ((int)(((byte)(129)))));
            this.lblTitreCaptures.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitreCaptures.ForeColor = System.Drawing.Color.White;
            this.lblTitreCaptures.Location = new System.Drawing.Point(45, 593);
            this.lblTitreCaptures.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitreCaptures.Name = "lblTitreCaptures";
            this.lblTitreCaptures.Size = new System.Drawing.Size(379, 33);
            this.lblTitreCaptures.TabIndex = 6;
            this.lblTitreCaptures.Text = "OBJECTIFS DE CAPTURES";
            // 
            // cboAliens
            // 
            this.cboAliens.FormattingEnabled = true;
            this.cboAliens.Location = new System.Drawing.Point(233, 680);
            this.cboAliens.Name = "cboAliens";
            this.cboAliens.Size = new System.Drawing.Size(703, 37);
            this.cboAliens.TabIndex = 7;
            // 
            // btnAjouterAlien
            // 
            this.btnAjouterAlien.Location = new System.Drawing.Point(1121, 680);
            this.btnAjouterAlien.Name = "btnAjouterAlien";
            this.btnAjouterAlien.Size = new System.Drawing.Size(211, 40);
            this.btnAjouterAlien.TabIndex = 8;
            this.btnAjouterAlien.Text = "Ajouter";
            this.btnAjouterAlien.UseVisualStyleBackColor = true;
            this.btnAjouterAlien.Click += new System.EventHandler(this.btnAjouterAlien_Click_2);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtQuantiteAlien
            // 
            this.txtQuantiteAlien.Location = new System.Drawing.Point(969, 680);
            this.txtQuantiteAlien.Name = "txtQuantiteAlien";
            this.txtQuantiteAlien.Size = new System.Drawing.Size(125, 35);
            this.txtQuantiteAlien.TabIndex = 10;
            // 
            // richtxtAliens
            // 
            this.richtxtAliens.Location = new System.Drawing.Point(233, 737);
            this.richtxtAliens.Name = "richtxtAliens";
            this.richtxtAliens.Size = new System.Drawing.Size(1099, 164);
            this.richtxtAliens.TabIndex = 11;
            this.richtxtAliens.Text = "";
            // 
            // btnValiderObjectifs
            // 
            this.btnValiderObjectifs.Location = new System.Drawing.Point(233, 953);
            this.btnValiderObjectifs.Name = "btnValiderObjectifs";
            this.btnValiderObjectifs.Size = new System.Drawing.Size(1099, 40);
            this.btnValiderObjectifs.TabIndex = 12;
            this.btnValiderObjectifs.Text = "Valider Objectifs";
            this.btnValiderObjectifs.UseVisualStyleBackColor = true;
            this.btnValiderObjectifs.Click += new System.EventHandler(this.btnValiderObjectifs_Click_1);
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(87)))), ((int)(((byte)(129)))));
            this.lblM.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblM.ForeColor = System.Drawing.Color.White;
            this.lblM.Location = new System.Drawing.Point(45, 121);
            this.lblM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(427, 33);
            this.lblM.TabIndex = 28;
            this.lblM.Text = "AFFECTATION DES MEMBRES";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(87)))), ((int)(((byte)(129)))));
            this.pictureBox3.Location = new System.Drawing.Point(30, 103);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(455, 64);
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.pictureBox2.Location = new System.Drawing.Point(30, 103);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1514, 458);
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.pictureBox1.Location = new System.Drawing.Point(30, 574);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1514, 443);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(87)))), ((int)(((byte)(129)))));
            this.pictureBox4.Location = new System.Drawing.Point(30, 574);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(409, 64);
            this.pictureBox4.TabIndex = 32;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(87)))), ((int)(((byte)(129)))));
            this.pictureBox5.Location = new System.Drawing.Point(215, 190);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(1142, 296);
            this.pictureBox5.TabIndex = 33;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(87)))), ((int)(((byte)(129)))));
            this.pictureBox6.Location = new System.Drawing.Point(215, 660);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(1142, 265);
            this.pictureBox6.TabIndex = 34;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.pictureBox7.Location = new System.Drawing.Point(-3, -12);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(1606, 105);
            this.pictureBox7.TabIndex = 35;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox7_MouseDown);
            this.pictureBox7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox7_MouseMove);
            this.pictureBox7.Move += new System.EventHandler(this.pictureBox7_Move);
            // 
            // pictureBox20
            // 
            this.pictureBox20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.pictureBox20.Location = new System.Drawing.Point(1474, 0);
            this.pictureBox20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(10, 92);
            this.pictureBox20.TabIndex = 51;
            this.pictureBox20.TabStop = false;
            // 
            // pictureBox19
            // 
            this.pictureBox19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.pictureBox19.BackgroundImage = global::appStargate.Properties.Resources.minimiser;
            this.pictureBox19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox19.Location = new System.Drawing.Point(1362, -1);
            this.pictureBox19.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(98, 94);
            this.pictureBox19.TabIndex = 50;
            this.pictureBox19.TabStop = false;
            this.pictureBox19.Click += new System.EventHandler(this.pictureBox19_Click);
            // 
            // pctQuitter
            // 
            this.pctQuitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.pctQuitter.BackgroundImage = global::appStargate.Properties.Resources.croix;
            this.pctQuitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctQuitter.Location = new System.Drawing.Point(1499, -1);
            this.pctQuitter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctQuitter.Name = "pctQuitter";
            this.pctQuitter.Size = new System.Drawing.Size(98, 94);
            this.pctQuitter.TabIndex = 49;
            this.pctQuitter.TabStop = false;
            this.pctQuitter.Click += new System.EventHandler(this.pctQuitter_Click);
            // 
            // frmEquipageMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::appStargate.Properties.Resources.sgback;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1597, 1026);
            this.Controls.Add(this.pictureBox20);
            this.Controls.Add(this.pictureBox19);
            this.Controls.Add(this.pctQuitter);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.lblTitreCaptures);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnValiderObjectifs);
            this.Controls.Add(this.richtxtAliens);
            this.Controls.Add(this.txtQuantiteAlien);
            this.Controls.Add(this.btnAjouterAlien);
            this.Controls.Add(this.cboAliens);
            this.Controls.Add(this.btnValiderMembres);
            this.Controls.Add(this.richtxtMembres);
            this.Controls.Add(this.btnAjouterMembre);
            this.Controls.Add(this.cboMembres);
            this.Controls.Add(this.lblNbMembreaffecter);
            this.Controls.Add(this.lblTitreMembres);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEquipageMission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmEquipageMission";
            this.Load += new System.EventHandler(this.frmEquipageMission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctQuitter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitreMembres;
        private System.Windows.Forms.Label lblNbMembreaffecter;
        private System.Windows.Forms.ComboBox cboMembres;
        private System.Windows.Forms.Button btnAjouterMembre;
        private System.Windows.Forms.RichTextBox richtxtMembres;
        private System.Windows.Forms.Button btnValiderMembres;
        private System.Windows.Forms.Label lblTitreCaptures;
        private System.Windows.Forms.ComboBox cboAliens;
        private System.Windows.Forms.Button btnAjouterAlien;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtQuantiteAlien;
        private System.Windows.Forms.RichTextBox richtxtAliens;
        private System.Windows.Forms.Button btnValiderObjectifs;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pctQuitter;
    }
}
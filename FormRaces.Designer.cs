namespace appStargate
{
    partial class FormRaces
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
            this.pnlFiltres = new System.Windows.Forms.Panel();
            this.btnEnnemis = new System.Windows.Forms.Button();
            this.btnAllies = new System.Windows.Forms.Button();
            this.btnTous = new System.Windows.Forms.Button();
            this.flpAliens = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlFiltres.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFiltres
            // 
            this.pnlFiltres.Controls.Add(this.btnEnnemis);
            this.pnlFiltres.Controls.Add(this.btnAllies);
            this.pnlFiltres.Controls.Add(this.btnTous);
            this.pnlFiltres.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFiltres.Location = new System.Drawing.Point(0, 0);
            this.pnlFiltres.Name = "pnlFiltres";
            this.pnlFiltres.Size = new System.Drawing.Size(200, 450);
            this.pnlFiltres.TabIndex = 0;
            // 
            // btnEnnemis
            // 
            this.btnEnnemis.Location = new System.Drawing.Point(10, 110);
            this.btnEnnemis.Name = "btnEnnemis";
            this.btnEnnemis.Size = new System.Drawing.Size(160, 35);
            this.btnEnnemis.TabIndex = 2;
            this.btnEnnemis.Text = "☠ Ennemis";
            this.btnEnnemis.UseVisualStyleBackColor = true;
            this.btnEnnemis.Click += new System.EventHandler(this.btnEnnemis_Click);
            // 
            // btnAllies
            // 
            this.btnAllies.Location = new System.Drawing.Point(10, 65);
            this.btnAllies.Name = "btnAllies";
            this.btnAllies.Size = new System.Drawing.Size(160, 35);
            this.btnAllies.TabIndex = 1;
            this.btnAllies.Text = "⚡ Alliés";
            this.btnAllies.UseVisualStyleBackColor = true;
            this.btnAllies.Click += new System.EventHandler(this.btnAllies_Click);
            // 
            // btnTous
            // 
            this.btnTous.Location = new System.Drawing.Point(10, 20);
            this.btnTous.Name = "btnTous";
            this.btnTous.Size = new System.Drawing.Size(160, 35);
            this.btnTous.TabIndex = 0;
            this.btnTous.Text = "Tous";
            this.btnTous.UseVisualStyleBackColor = true;
            this.btnTous.Click += new System.EventHandler(this.btnTous_Click);
            // 
            // flpAliens
            // 
            this.flpAliens.AutoScroll = true;
            this.flpAliens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpAliens.Location = new System.Drawing.Point(200, 0);
            this.flpAliens.Name = "flpAliens";
            this.flpAliens.Size = new System.Drawing.Size(600, 450);
            this.flpAliens.TabIndex = 1;
            // 
            // FormRaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flpAliens);
            this.Controls.Add(this.pnlFiltres);
            this.Name = "FormRaces";
            this.Text = "FormRaces";
            this.Load += new System.EventHandler(this.FormRaces_Load);
            this.pnlFiltres.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFiltres;
        private System.Windows.Forms.Button btnEnnemis;
        private System.Windows.Forms.Button btnAllies;
        private System.Windows.Forms.Button btnTous;
        private System.Windows.Forms.FlowLayoutPanel flpAliens;
    }
}
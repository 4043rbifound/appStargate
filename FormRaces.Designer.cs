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
            this.pnlFiltres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlFiltres.Name = "pnlFiltres";
            this.pnlFiltres.Size = new System.Drawing.Size(300, 692);
            this.pnlFiltres.TabIndex = 0;
            // 
            // btnEnnemis
            // 
            this.btnEnnemis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.btnEnnemis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnnemis.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnnemis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.btnEnnemis.Location = new System.Drawing.Point(15, 169);
            this.btnEnnemis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEnnemis.Name = "btnEnnemis";
            this.btnEnnemis.Size = new System.Drawing.Size(240, 54);
            this.btnEnnemis.TabIndex = 2;
            this.btnEnnemis.Text = "☠ Ennemis";
            this.btnEnnemis.UseVisualStyleBackColor = false;
            this.btnEnnemis.Click += new System.EventHandler(this.btnEnnemis_Click);
            // 
            // btnAllies
            // 
            this.btnAllies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.btnAllies.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAllies.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.btnAllies.Location = new System.Drawing.Point(15, 100);
            this.btnAllies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAllies.Name = "btnAllies";
            this.btnAllies.Size = new System.Drawing.Size(240, 54);
            this.btnAllies.TabIndex = 1;
            this.btnAllies.Text = "⚡ Alliés";
            this.btnAllies.UseVisualStyleBackColor = false;
            this.btnAllies.Click += new System.EventHandler(this.btnAllies_Click);
            // 
            // btnTous
            // 
            this.btnTous.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.btnTous.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTous.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTous.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.btnTous.Location = new System.Drawing.Point(15, 31);
            this.btnTous.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTous.Name = "btnTous";
            this.btnTous.Size = new System.Drawing.Size(240, 54);
            this.btnTous.TabIndex = 0;
            this.btnTous.Text = "Tous";
            this.btnTous.UseVisualStyleBackColor = false;
            this.btnTous.Click += new System.EventHandler(this.btnTous_Click);
            // 
            // flpAliens
            // 
            this.flpAliens.AutoScroll = true;
            this.flpAliens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpAliens.Location = new System.Drawing.Point(300, 0);
            this.flpAliens.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flpAliens.Name = "flpAliens";
            this.flpAliens.Size = new System.Drawing.Size(900, 692);
            this.flpAliens.TabIndex = 1;
            // 
            // FormRaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.flpAliens);
            this.Controls.Add(this.pnlFiltres);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
namespace appliPandora
{
    partial class formAuthentification
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
            this.grpAuth = new System.Windows.Forms.GroupBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblMdp = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grpAuth.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAuth
            // 
            this.grpAuth.Controls.Add(this.btnValider);
            this.grpAuth.Controls.Add(this.txtMdp);
            this.grpAuth.Controls.Add(this.txtLogin);
            this.grpAuth.Controls.Add(this.lblMdp);
            this.grpAuth.Controls.Add(this.lblLogin);
            this.grpAuth.Location = new System.Drawing.Point(129, 67);
            this.grpAuth.Name = "grpAuth";
            this.grpAuth.Size = new System.Drawing.Size(1156, 580);
            this.grpAuth.TabIndex = 0;
            this.grpAuth.TabStop = false;
            this.grpAuth.Text = "Authentification";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(778, 380);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(272, 119);
            this.btnValider.TabIndex = 4;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // txtMdp
            // 
            this.txtMdp.Location = new System.Drawing.Point(412, 332);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.Size = new System.Drawing.Size(298, 29);
            this.txtMdp.TabIndex = 3;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(412, 157);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(298, 29);
            this.txtLogin.TabIndex = 2;
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMdp.Location = new System.Drawing.Point(194, 332);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(220, 39);
            this.lblMdp.TabIndex = 1;
            this.lblMdp.Text = "Mot de passe";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(194, 157);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(101, 39);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // formAuthentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 688);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpAuth);
            this.Name = "formAuthentification";
            this.Text = "x²";
            this.Load += new System.EventHandler(this.formAuthentification_Load);
            this.grpAuth.ResumeLayout(false);
            this.grpAuth.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAuth;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.Button button1;
    }
}
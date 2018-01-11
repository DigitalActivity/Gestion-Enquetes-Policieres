namespace GestionEnquetes
{
    partial class DlgLogin
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
            this.textBoxlogin = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.linkLabelPassOublier = new System.Windows.Forms.LinkLabel();
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxlogin
            // 
            this.textBoxlogin.Location = new System.Drawing.Point(65, 22);
            this.textBoxlogin.MaxLength = 100;
            this.textBoxlogin.Name = "textBoxlogin";
            this.textBoxlogin.Size = new System.Drawing.Size(108, 20);
            this.textBoxlogin.TabIndex = 0;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(6, 25);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(33, 13);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "Login";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(6, 51);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(65, 48);
            this.textBoxPassword.MaxLength = 100;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(108, 20);
            this.textBoxPassword.TabIndex = 2;
            // 
            // linkLabelPassOublier
            // 
            this.linkLabelPassOublier.AutoSize = true;
            this.linkLabelPassOublier.Location = new System.Drawing.Point(112, 71);
            this.linkLabelPassOublier.Name = "linkLabelPassOublier";
            this.linkLabelPassOublier.Size = new System.Drawing.Size(67, 13);
            this.linkLabelPassOublier.TabIndex = 6;
            this.linkLabelPassOublier.TabStop = true;
            this.linkLabelPassOublier.Text = "Passe oublié";
            this.linkLabelPassOublier.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelPassOublier_LinkClicked);
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Controls.Add(this.labelLogin);
            this.groupBoxLogin.Controls.Add(this.linkLabelPassOublier);
            this.groupBoxLogin.Controls.Add(this.textBoxlogin);
            this.groupBoxLogin.Controls.Add(this.textBoxPassword);
            this.groupBoxLogin.Controls.Add(this.labelPassword);
            this.groupBoxLogin.Location = new System.Drawing.Point(12, 12);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(179, 92);
            this.groupBoxLogin.TabIndex = 7;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "Acces au compte";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestionEnquetes.Properties.Resources.logo_crest;
            this.pictureBox1.Location = new System.Drawing.Point(12, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 169);
            this.pictureBox1.TabIndex = 1001;
            this.pictureBox1.TabStop = false;
            // 
            // DlgLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 331);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxLogin);
            this.Name = "DlgLogin";
            this.Text = "Authentification";
            this.Controls.SetChildIndex(this.groupBoxLogin, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxlogin;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.LinkLabel linkLabelPassOublier;
        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
namespace GestionEnquetes
{
    partial class DlgResetPass
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
            this.groupBoxInfoLogin = new System.Windows.Forms.GroupBox();
            this.textBoxNewPassword2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.labelPassword2 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.groupBoxInfoLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInfoLogin
            // 
            this.groupBoxInfoLogin.Controls.Add(this.textBoxNewPassword2);
            this.groupBoxInfoLogin.Controls.Add(this.label1);
            this.groupBoxInfoLogin.Controls.Add(this.textBoxNewPassword);
            this.groupBoxInfoLogin.Controls.Add(this.labelPassword2);
            this.groupBoxInfoLogin.Controls.Add(this.textBoxPassword);
            this.groupBoxInfoLogin.Controls.Add(this.labelPassword);
            this.groupBoxInfoLogin.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInfoLogin.Name = "groupBoxInfoLogin";
            this.groupBoxInfoLogin.Size = new System.Drawing.Size(252, 118);
            this.groupBoxInfoLogin.TabIndex = 29;
            this.groupBoxInfoLogin.TabStop = false;
            this.groupBoxInfoLogin.Text = "Reinisitialiser le mot de passe";
            // 
            // textBoxNewPassword2
            // 
            this.textBoxNewPassword2.Location = new System.Drawing.Point(129, 89);
            this.textBoxNewPassword2.MaxLength = 100;
            this.textBoxNewPassword2.Name = "textBoxNewPassword2";
            this.textBoxNewPassword2.PasswordChar = '*';
            this.textBoxNewPassword2.Size = new System.Drawing.Size(110, 20);
            this.textBoxNewPassword2.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Ressaisir";
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Location = new System.Drawing.Point(129, 63);
            this.textBoxNewPassword.MaxLength = 100;
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.PasswordChar = '*';
            this.textBoxNewPassword.Size = new System.Drawing.Size(110, 20);
            this.textBoxNewPassword.TabIndex = 13;
            // 
            // labelPassword2
            // 
            this.labelPassword2.AutoSize = true;
            this.labelPassword2.Location = new System.Drawing.Point(6, 66);
            this.labelPassword2.Name = "labelPassword2";
            this.labelPassword2.Size = new System.Drawing.Size(117, 13);
            this.labelPassword2.TabIndex = 33;
            this.labelPassword2.Text = "Nouveau mot de passe";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(129, 22);
            this.textBoxPassword.MaxLength = 100;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(110, 20);
            this.textBoxPassword.TabIndex = 12;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(6, 26);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(103, 13);
            this.labelPassword.TabIndex = 30;
            this.labelPassword.Text = "Mot de passe actuel";
            // 
            // DlgResetPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 182);
            this.Controls.Add(this.groupBoxInfoLogin);
            this.Name = "DlgResetPass";
            this.Text = "Gestion Compte";
            this.Controls.SetChildIndex(this.groupBoxInfoLogin, 0);
            this.groupBoxInfoLogin.ResumeLayout(false);
            this.groupBoxInfoLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInfoLogin;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Label labelPassword2;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxNewPassword2;
        private System.Windows.Forms.Label label1;
    }
}
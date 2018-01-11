namespace GestionEnquetes
{
    partial class DlgRapportEnquete
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
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxRemarques = new System.Windows.Forms.RichTextBox();
            this.labelAuteur = new System.Windows.Forms.Label();
            this.labelMatricule = new System.Windows.Forms.Label();
            this.labelMdP = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelErreur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 1001;
            this.label1.Text = "Information collectée :";
            // 
            // TextBoxRemarques
            // 
            this.TextBoxRemarques.Location = new System.Drawing.Point(16, 30);
            this.TextBoxRemarques.Name = "TextBoxRemarques";
            this.TextBoxRemarques.Size = new System.Drawing.Size(366, 139);
            this.TextBoxRemarques.TabIndex = 1002;
            this.TextBoxRemarques.Text = "";
            // 
            // labelAuteur
            // 
            this.labelAuteur.AutoSize = true;
            this.labelAuteur.Location = new System.Drawing.Point(16, 176);
            this.labelAuteur.Name = "labelAuteur";
            this.labelAuteur.Size = new System.Drawing.Size(56, 13);
            this.labelAuteur.TabIndex = 1003;
            this.labelAuteur.Text = "Matricule :";
            // 
            // labelMatricule
            // 
            this.labelMatricule.AutoSize = true;
            this.labelMatricule.Enabled = false;
            this.labelMatricule.Location = new System.Drawing.Point(79, 176);
            this.labelMatricule.Name = "labelMatricule";
            this.labelMatricule.Size = new System.Drawing.Size(49, 13);
            this.labelMatricule.TabIndex = 1004;
            this.labelMatricule.Text = "matricule";
            // 
            // labelMdP
            // 
            this.labelMdP.AutoSize = true;
            this.labelMdP.Location = new System.Drawing.Point(160, 176);
            this.labelMdP.Name = "labelMdP";
            this.labelMdP.Size = new System.Drawing.Size(77, 13);
            this.labelMdP.TabIndex = 1005;
            this.labelMdP.Text = "Mot de passe :";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(243, 173);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '•';
            this.textBoxPassword.Size = new System.Drawing.Size(139, 20);
            this.textBoxPassword.TabIndex = 1006;
            // 
            // labelErreur
            // 
            this.labelErreur.AutoSize = true;
            this.labelErreur.ForeColor = System.Drawing.Color.Red;
            this.labelErreur.Location = new System.Drawing.Point(16, 199);
            this.labelErreur.Name = "labelErreur";
            this.labelErreur.Size = new System.Drawing.Size(296, 13);
            this.labelErreur.TabIndex = 1007;
            this.labelErreur.Text = "Erreur - Le mot de passe saisi ne correspond pas au matricule";
            this.labelErreur.Visible = false;
            // 
            // DlgRapportEnquete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 261);
            this.Controls.Add(this.labelErreur);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelMdP);
            this.Controls.Add(this.labelMatricule);
            this.Controls.Add(this.labelAuteur);
            this.Controls.Add(this.TextBoxRemarques);
            this.Controls.Add(this.label1);
            this.Name = "DlgRapportEnquete";
            this.Text = "Ajout - Rapport d\'Enquête";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.TextBoxRemarques, 0);
            this.Controls.SetChildIndex(this.labelAuteur, 0);
            this.Controls.SetChildIndex(this.labelMatricule, 0);
            this.Controls.SetChildIndex(this.labelMdP, 0);
            this.Controls.SetChildIndex(this.textBoxPassword, 0);
            this.Controls.SetChildIndex(this.labelErreur, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox TextBoxRemarques;
        private System.Windows.Forms.Label labelAuteur;
        private System.Windows.Forms.Label labelMatricule;
        private System.Windows.Forms.Label labelMdP;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelErreur;
    }
}
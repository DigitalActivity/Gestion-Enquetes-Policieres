namespace GestionEnquetes
{
    partial class DlgChoisirCompte
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
            this.textBoxCompteId = new System.Windows.Forms.TextBox();
            this.listBoxTousLesComptes = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Compte #";
            // 
            // textBoxCompteId
            // 
            this.textBoxCompteId.Location = new System.Drawing.Point(78, 231);
            this.textBoxCompteId.Name = "textBoxCompteId";
            this.textBoxCompteId.Size = new System.Drawing.Size(100, 20);
            this.textBoxCompteId.TabIndex = 1;
            this.textBoxCompteId.TextChanged += new System.EventHandler(this.textBoxCompteId_TextChanged);
            // 
            // listBoxTousLesComptes
            // 
            this.listBoxTousLesComptes.FormattingEnabled = true;
            this.listBoxTousLesComptes.Location = new System.Drawing.Point(13, 13);
            this.listBoxTousLesComptes.Name = "listBoxTousLesComptes";
            this.listBoxTousLesComptes.Size = new System.Drawing.Size(247, 199);
            this.listBoxTousLesComptes.TabIndex = 1001;
            this.listBoxTousLesComptes.SelectedIndexChanged += new System.EventHandler(this.listBoxTousLesComptes_SelectedIndexChanged);
            this.listBoxTousLesComptes.DoubleClick += new System.EventHandler(this.listBoxTousLesComptes_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 13);
            this.label2.TabIndex = 1002;
            this.label2.Text = "Choix de compte par numero de matricule";
            // 
            // DlgChoisirCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 302);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxTousLesComptes);
            this.Controls.Add(this.textBoxCompteId);
            this.Controls.Add(this.label1);
            this.Name = "DlgChoisirCompte";
            this.Text = "Choisir un compte";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.textBoxCompteId, 0);
            this.Controls.SetChildIndex(this.listBoxTousLesComptes, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCompteId;
        private System.Windows.Forms.ListBox listBoxTousLesComptes;
        private System.Windows.Forms.Label label2;
    }
}
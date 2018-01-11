namespace GestionEnquetes
{
    partial class DlgAjoutVehicule
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
            this.labelMarque = new System.Windows.Forms.Label();
            this.textBoxMarque = new System.Windows.Forms.TextBox();
            this.labelModele = new System.Windows.Forms.Label();
            this.textBoxModele = new System.Windows.Forms.TextBox();
            this.labelAnnee = new System.Windows.Forms.Label();
            this.textBoxAnnee = new System.Windows.Forms.TextBox();
            this.labelStatut = new System.Windows.Forms.Label();
            this.buttonAjouterPersonne = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPersonne = new System.Windows.Forms.ComboBox();
            this.comboBoxStatut = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelMarque
            // 
            this.labelMarque.AutoSize = true;
            this.labelMarque.Location = new System.Drawing.Point(13, 13);
            this.labelMarque.Name = "labelMarque";
            this.labelMarque.Size = new System.Drawing.Size(49, 13);
            this.labelMarque.TabIndex = 0;
            this.labelMarque.Text = "Marque :";
            // 
            // textBoxMarque
            // 
            this.textBoxMarque.Location = new System.Drawing.Point(68, 10);
            this.textBoxMarque.Name = "textBoxMarque";
            this.textBoxMarque.Size = new System.Drawing.Size(136, 20);
            this.textBoxMarque.TabIndex = 1;
            // 
            // labelModele
            // 
            this.labelModele.AutoSize = true;
            this.labelModele.Location = new System.Drawing.Point(210, 13);
            this.labelModele.Name = "labelModele";
            this.labelModele.Size = new System.Drawing.Size(48, 13);
            this.labelModele.TabIndex = 2;
            this.labelModele.Text = "Modèle :";
            // 
            // textBoxModele
            // 
            this.textBoxModele.Location = new System.Drawing.Point(264, 10);
            this.textBoxModele.Name = "textBoxModele";
            this.textBoxModele.Size = new System.Drawing.Size(141, 20);
            this.textBoxModele.TabIndex = 3;
            // 
            // labelAnnee
            // 
            this.labelAnnee.AutoSize = true;
            this.labelAnnee.Location = new System.Drawing.Point(13, 43);
            this.labelAnnee.Name = "labelAnnee";
            this.labelAnnee.Size = new System.Drawing.Size(44, 13);
            this.labelAnnee.TabIndex = 4;
            this.labelAnnee.Text = "Année :";
            // 
            // textBoxAnnee
            // 
            this.textBoxAnnee.Location = new System.Drawing.Point(67, 43);
            this.textBoxAnnee.Name = "textBoxAnnee";
            this.textBoxAnnee.Size = new System.Drawing.Size(137, 20);
            this.textBoxAnnee.TabIndex = 5;
            // 
            // labelStatut
            // 
            this.labelStatut.AutoSize = true;
            this.labelStatut.Location = new System.Drawing.Point(210, 46);
            this.labelStatut.Name = "labelStatut";
            this.labelStatut.Size = new System.Drawing.Size(41, 13);
            this.labelStatut.TabIndex = 7;
            this.labelStatut.Text = "Statut :";
            // 
            // buttonAjouterPersonne
            // 
            this.buttonAjouterPersonne.Location = new System.Drawing.Point(264, 80);
            this.buttonAjouterPersonne.Name = "buttonAjouterPersonne";
            this.buttonAjouterPersonne.Size = new System.Drawing.Size(141, 23);
            this.buttonAjouterPersonne.TabIndex = 8;
            this.buttonAjouterPersonne.Text = "Ajouter Personne";
            this.buttonAjouterPersonne.UseVisualStyleBackColor = true;
            this.buttonAjouterPersonne.Click += new System.EventHandler(this.buttonAjouterPersonne_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Propriétaire : ";
            // 
            // comboBoxPersonne
            // 
            this.comboBoxPersonne.FormattingEnabled = true;
            this.comboBoxPersonne.Location = new System.Drawing.Point(83, 80);
            this.comboBoxPersonne.Name = "comboBoxPersonne";
            this.comboBoxPersonne.Size = new System.Drawing.Size(168, 21);
            this.comboBoxPersonne.TabIndex = 10;
            this.comboBoxPersonne.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.comboBoxStatut_Format);
            // 
            // comboBoxStatut
            // 
            this.comboBoxStatut.FormattingEnabled = true;
            this.comboBoxStatut.Location = new System.Drawing.Point(264, 43);
            this.comboBoxStatut.Name = "comboBoxStatut";
            this.comboBoxStatut.Size = new System.Drawing.Size(141, 21);
            this.comboBoxStatut.TabIndex = 11;
            // 
            // DlgAjoutVehicule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 162);
            this.Controls.Add(this.comboBoxStatut);
            this.Controls.Add(this.comboBoxPersonne);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAjouterPersonne);
            this.Controls.Add(this.labelStatut);
            this.Controls.Add(this.textBoxAnnee);
            this.Controls.Add(this.labelAnnee);
            this.Controls.Add(this.textBoxModele);
            this.Controls.Add(this.labelModele);
            this.Controls.Add(this.textBoxMarque);
            this.Controls.Add(this.labelMarque);
            this.Name = "DlgAjoutVehicule";
            this.Text = "DlgAjoutVehicule";
            this.Controls.SetChildIndex(this.labelMarque, 0);
            this.Controls.SetChildIndex(this.textBoxMarque, 0);
            this.Controls.SetChildIndex(this.labelModele, 0);
            this.Controls.SetChildIndex(this.textBoxModele, 0);
            this.Controls.SetChildIndex(this.labelAnnee, 0);
            this.Controls.SetChildIndex(this.textBoxAnnee, 0);
            this.Controls.SetChildIndex(this.labelStatut, 0);
            this.Controls.SetChildIndex(this.buttonAjouterPersonne, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.comboBoxPersonne, 0);
            this.Controls.SetChildIndex(this.comboBoxStatut, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMarque;
        private System.Windows.Forms.TextBox textBoxMarque;
        private System.Windows.Forms.Label labelModele;
        private System.Windows.Forms.TextBox textBoxModele;
        private System.Windows.Forms.Label labelAnnee;
        private System.Windows.Forms.TextBox textBoxAnnee;
        private System.Windows.Forms.Label labelStatut;
        private System.Windows.Forms.Button buttonAjouterPersonne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPersonne;
        private System.Windows.Forms.ComboBox comboBoxStatut;
    }
}
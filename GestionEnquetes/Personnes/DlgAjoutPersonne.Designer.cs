namespace GestionEnquetes
{
    partial class DlgAjoutPersonne
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
            this.comboBoxCode = new System.Windows.Forms.ComboBox();
            this.labelCodeStatut = new System.Windows.Forms.Label();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.labelAdresse = new System.Windows.Forms.Label();
            this.dateTimePickerNaissance = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.labelPrénom = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxCode
            // 
            this.comboBoxCode.FormattingEnabled = true;
            this.comboBoxCode.Location = new System.Drawing.Point(114, 148);
            this.comboBoxCode.Name = "comboBoxCode";
            this.comboBoxCode.Size = new System.Drawing.Size(180, 21);
            this.comboBoxCode.TabIndex = 19;
            // 
            // labelCodeStatut
            // 
            this.labelCodeStatut.AutoSize = true;
            this.labelCodeStatut.Location = new System.Drawing.Point(22, 151);
            this.labelCodeStatut.Name = "labelCodeStatut";
            this.labelCodeStatut.Size = new System.Drawing.Size(82, 13);
            this.labelCodeStatut.TabIndex = 18;
            this.labelCodeStatut.Text = "Code de statut :";
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(79, 112);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(215, 20);
            this.textBoxAdresse.TabIndex = 17;
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.Location = new System.Drawing.Point(22, 115);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(51, 13);
            this.labelAdresse.TabIndex = 16;
            this.labelAdresse.Text = "Adresse :";
            // 
            // dateTimePickerNaissance
            // 
            this.dateTimePickerNaissance.Location = new System.Drawing.Point(133, 80);
            this.dateTimePickerNaissance.Name = "dateTimePickerNaissance";
            this.dateTimePickerNaissance.Size = new System.Drawing.Size(161, 20);
            this.dateTimePickerNaissance.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Date de naissance :";
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(77, 42);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(217, 20);
            this.textBoxPrenom.TabIndex = 13;
            // 
            // labelPrénom
            // 
            this.labelPrénom.AccessibleRole = System.Windows.Forms.AccessibleRole.RowHeader;
            this.labelPrénom.AutoSize = true;
            this.labelPrénom.Location = new System.Drawing.Point(22, 45);
            this.labelPrénom.Name = "labelPrénom";
            this.labelPrénom.Size = new System.Drawing.Size(49, 13);
            this.labelPrénom.TabIndex = 12;
            this.labelPrénom.Text = "Prénom :";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(63, 12);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(231, 20);
            this.textBoxNom.TabIndex = 11;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(22, 15);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(35, 13);
            this.labelNom.TabIndex = 10;
            this.labelNom.Text = "Nom :";
            // 
            // DlgAjoutPersonne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 252);
            this.Controls.Add(this.comboBoxCode);
            this.Controls.Add(this.labelCodeStatut);
            this.Controls.Add(this.textBoxAdresse);
            this.Controls.Add(this.labelAdresse);
            this.Controls.Add(this.dateTimePickerNaissance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.labelPrénom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelNom);
            this.Name = "DlgAjoutPersonne";
            this.Text = "Ajouter une personne";
            this.Controls.SetChildIndex(this.labelNom, 0);
            this.Controls.SetChildIndex(this.textBoxNom, 0);
            this.Controls.SetChildIndex(this.labelPrénom, 0);
            this.Controls.SetChildIndex(this.textBoxPrenom, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.dateTimePickerNaissance, 0);
            this.Controls.SetChildIndex(this.labelAdresse, 0);
            this.Controls.SetChildIndex(this.textBoxAdresse, 0);
            this.Controls.SetChildIndex(this.labelCodeStatut, 0);
            this.Controls.SetChildIndex(this.comboBoxCode, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCode;
        private System.Windows.Forms.Label labelCodeStatut;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.Label labelAdresse;
        private System.Windows.Forms.DateTimePicker dateTimePickerNaissance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.Label labelPrénom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label labelNom;
    }
}
namespace GestionEnquetes
{
    partial class DlgRapportEvenement
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
            this.comboBoxCodeDeNature = new System.Windows.Forms.ComboBox();
            this.labelCodeNature = new System.Windows.Forms.Label();
            this.labelNoCivique = new System.Windows.Forms.Label();
            this.textBoxNoCivique = new System.Windows.Forms.TextBox();
            this.groupBoxAdresse = new System.Windows.Forms.GroupBox();
            this.comboBoxProvince = new System.Windows.Forms.ComboBox();
            this.textBoxPays = new System.Windows.Forms.TextBox();
            this.labelPays = new System.Windows.Forms.Label();
            this.labelProvince = new System.Windows.Forms.Label();
            this.textBoxVille = new System.Windows.Forms.TextBox();
            this.textBoxCodePostal = new System.Windows.Forms.TextBox();
            this.labelCodePostal = new System.Windows.Forms.Label();
            this.labelVille = new System.Windows.Forms.Label();
            this.textBoxRue = new System.Windows.Forms.TextBox();
            this.labelRue = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBoxRemarques = new System.Windows.Forms.TextBox();
            this.labelRemarques = new System.Windows.Forms.Label();
            this.groupBoxAdresse.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxCodeDeNature
            // 
            this.comboBoxCodeDeNature.FormattingEnabled = true;
            this.comboBoxCodeDeNature.Location = new System.Drawing.Point(107, 12);
            this.comboBoxCodeDeNature.Name = "comboBoxCodeDeNature";
            this.comboBoxCodeDeNature.Size = new System.Drawing.Size(194, 21);
            this.comboBoxCodeDeNature.TabIndex = 1;
            // 
            // labelCodeNature
            // 
            this.labelCodeNature.AutoSize = true;
            this.labelCodeNature.Location = new System.Drawing.Point(12, 15);
            this.labelCodeNature.Name = "labelCodeNature";
            this.labelCodeNature.Size = new System.Drawing.Size(89, 13);
            this.labelCodeNature.TabIndex = 0;
            this.labelCodeNature.Text = "Code de nature : ";
            // 
            // labelNoCivique
            // 
            this.labelNoCivique.AutoSize = true;
            this.labelNoCivique.Location = new System.Drawing.Point(6, 16);
            this.labelNoCivique.Name = "labelNoCivique";
            this.labelNoCivique.Size = new System.Drawing.Size(64, 13);
            this.labelNoCivique.TabIndex = 0;
            this.labelNoCivique.Text = "No civique :";
            // 
            // textBoxNoCivique
            // 
            this.textBoxNoCivique.Location = new System.Drawing.Point(76, 13);
            this.textBoxNoCivique.Name = "textBoxNoCivique";
            this.textBoxNoCivique.Size = new System.Drawing.Size(82, 20);
            this.textBoxNoCivique.TabIndex = 1;
            // 
            // groupBoxAdresse
            // 
            this.groupBoxAdresse.Controls.Add(this.comboBoxProvince);
            this.groupBoxAdresse.Controls.Add(this.textBoxPays);
            this.groupBoxAdresse.Controls.Add(this.labelPays);
            this.groupBoxAdresse.Controls.Add(this.labelProvince);
            this.groupBoxAdresse.Controls.Add(this.textBoxVille);
            this.groupBoxAdresse.Controls.Add(this.textBoxCodePostal);
            this.groupBoxAdresse.Controls.Add(this.labelCodePostal);
            this.groupBoxAdresse.Controls.Add(this.labelVille);
            this.groupBoxAdresse.Controls.Add(this.textBoxRue);
            this.groupBoxAdresse.Controls.Add(this.labelRue);
            this.groupBoxAdresse.Controls.Add(this.labelNoCivique);
            this.groupBoxAdresse.Controls.Add(this.textBoxNoCivique);
            this.groupBoxAdresse.Location = new System.Drawing.Point(12, 39);
            this.groupBoxAdresse.Name = "groupBoxAdresse";
            this.groupBoxAdresse.Size = new System.Drawing.Size(628, 69);
            this.groupBoxAdresse.TabIndex = 4;
            this.groupBoxAdresse.TabStop = false;
            this.groupBoxAdresse.Text = "Adresse";
            // 
            // comboBoxProvince
            // 
            this.comboBoxProvince.FormattingEnabled = true;
            this.comboBoxProvince.Location = new System.Drawing.Point(329, 41);
            this.comboBoxProvince.Name = "comboBoxProvince";
            this.comboBoxProvince.Size = new System.Drawing.Size(84, 21);
            this.comboBoxProvince.TabIndex = 9;
            // 
            // textBoxPays
            // 
            this.textBoxPays.Location = new System.Drawing.Point(494, 41);
            this.textBoxPays.Name = "textBoxPays";
            this.textBoxPays.Size = new System.Drawing.Size(128, 20);
            this.textBoxPays.TabIndex = 11;
            // 
            // labelPays
            // 
            this.labelPays.AutoSize = true;
            this.labelPays.Location = new System.Drawing.Point(452, 47);
            this.labelPays.Name = "labelPays";
            this.labelPays.Size = new System.Drawing.Size(36, 13);
            this.labelPays.TabIndex = 10;
            this.labelPays.Text = "Pays :";
            // 
            // labelProvince
            // 
            this.labelProvince.AutoSize = true;
            this.labelProvince.Location = new System.Drawing.Point(268, 44);
            this.labelProvince.Name = "labelProvince";
            this.labelProvince.Size = new System.Drawing.Size(55, 13);
            this.labelProvince.TabIndex = 8;
            this.labelProvince.Text = "Province :";
            // 
            // textBoxVille
            // 
            this.textBoxVille.Location = new System.Drawing.Point(44, 40);
            this.textBoxVille.Name = "textBoxVille";
            this.textBoxVille.Size = new System.Drawing.Size(153, 20);
            this.textBoxVille.TabIndex = 7;
            // 
            // textBoxCodePostal
            // 
            this.textBoxCodePostal.Location = new System.Drawing.Point(494, 13);
            this.textBoxCodePostal.Name = "textBoxCodePostal";
            this.textBoxCodePostal.Size = new System.Drawing.Size(128, 20);
            this.textBoxCodePostal.TabIndex = 5;
            // 
            // labelCodePostal
            // 
            this.labelCodePostal.AutoSize = true;
            this.labelCodePostal.Location = new System.Drawing.Point(419, 16);
            this.labelCodePostal.Name = "labelCodePostal";
            this.labelCodePostal.Size = new System.Drawing.Size(69, 13);
            this.labelCodePostal.TabIndex = 4;
            this.labelCodePostal.Text = "Code postal :";
            // 
            // labelVille
            // 
            this.labelVille.AutoSize = true;
            this.labelVille.Location = new System.Drawing.Point(6, 43);
            this.labelVille.Name = "labelVille";
            this.labelVille.Size = new System.Drawing.Size(32, 13);
            this.labelVille.TabIndex = 6;
            this.labelVille.Text = "Ville :";
            // 
            // textBoxRue
            // 
            this.textBoxRue.Location = new System.Drawing.Point(243, 13);
            this.textBoxRue.Name = "textBoxRue";
            this.textBoxRue.Size = new System.Drawing.Size(170, 20);
            this.textBoxRue.TabIndex = 3;
            // 
            // labelRue
            // 
            this.labelRue.AutoSize = true;
            this.labelRue.Location = new System.Drawing.Point(204, 16);
            this.labelRue.Name = "labelRue";
            this.labelRue.Size = new System.Drawing.Size(33, 13);
            this.labelRue.TabIndex = 2;
            this.labelRue.Text = "Rue :";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(307, 15);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(36, 13);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Date :";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(349, 12);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(168, 20);
            this.dateTimePicker.TabIndex = 3;
            // 
            // textBoxRemarques
            // 
            this.textBoxRemarques.Location = new System.Drawing.Point(12, 136);
            this.textBoxRemarques.Multiline = true;
            this.textBoxRemarques.Name = "textBoxRemarques";
            this.textBoxRemarques.Size = new System.Drawing.Size(628, 150);
            this.textBoxRemarques.TabIndex = 6;
            // 
            // labelRemarques
            // 
            this.labelRemarques.AutoSize = true;
            this.labelRemarques.Location = new System.Drawing.Point(12, 120);
            this.labelRemarques.Name = "labelRemarques";
            this.labelRemarques.Size = new System.Drawing.Size(67, 13);
            this.labelRemarques.TabIndex = 5;
            this.labelRemarques.Text = "Remarques :";
            // 
            // DlgRapportEvenement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 345);
            this.Controls.Add(this.labelRemarques);
            this.Controls.Add(this.textBoxRemarques);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.groupBoxAdresse);
            this.Controls.Add(this.labelCodeNature);
            this.Controls.Add(this.comboBoxCodeDeNature);
            this.Name = "DlgRapportEvenement";
            this.Text = "Rapport d\'événement";
            this.Controls.SetChildIndex(this.comboBoxCodeDeNature, 0);
            this.Controls.SetChildIndex(this.labelCodeNature, 0);
            this.Controls.SetChildIndex(this.groupBoxAdresse, 0);
            this.Controls.SetChildIndex(this.labelDate, 0);
            this.Controls.SetChildIndex(this.dateTimePicker, 0);
            this.Controls.SetChildIndex(this.textBoxRemarques, 0);
            this.Controls.SetChildIndex(this.labelRemarques, 0);
            this.groupBoxAdresse.ResumeLayout(false);
            this.groupBoxAdresse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCodeDeNature;
        private System.Windows.Forms.Label labelCodeNature;
        private System.Windows.Forms.Label labelNoCivique;
        private System.Windows.Forms.TextBox textBoxNoCivique;
        private System.Windows.Forms.GroupBox groupBoxAdresse;
        private System.Windows.Forms.TextBox textBoxVille;
        private System.Windows.Forms.TextBox textBoxCodePostal;
        private System.Windows.Forms.Label labelCodePostal;
        private System.Windows.Forms.Label labelVille;
        private System.Windows.Forms.TextBox textBoxRue;
        private System.Windows.Forms.Label labelRue;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox textBoxRemarques;
        private System.Windows.Forms.Label labelRemarques;
        private System.Windows.Forms.TextBox textBoxPays;
        private System.Windows.Forms.Label labelPays;
        private System.Windows.Forms.Label labelProvince;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBoxProvince;
    }
}
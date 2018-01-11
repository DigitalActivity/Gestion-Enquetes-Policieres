namespace GestionEnquetes
{
    partial class DlgRapportAccident
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
            this.groupBoxVehiculesExclusDuRapport = new System.Windows.Forms.GroupBox();
            this.buttonAjouterVehicule = new System.Windows.Forms.Button();
            this.dataGridViewVehiculesExclusDuRapport = new System.Windows.Forms.DataGridView();
            this.marque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modèle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no_véhicule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.année = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proprietaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testProprietaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelTitre = new System.Windows.Forms.Label();
            this.labelDateEtHeure = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelRemarques = new System.Windows.Forms.Label();
            this.textBoxRemarques = new System.Windows.Forms.TextBox();
            this.dataGridViewVehiculesInclusDansRapport = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxVehiculesDansRapport = new System.Windows.Forms.GroupBox();
            this.buttonRetirerVehicule = new System.Windows.Forms.Button();
            this.groupBoxAdresse = new System.Windows.Forms.GroupBox();
            this.comboBoxProvince = new System.Windows.Forms.ComboBox();
            this.labelProvince = new System.Windows.Forms.Label();
            this.textBoxPays = new System.Windows.Forms.TextBox();
            this.labelPays = new System.Windows.Forms.Label();
            this.textBoxVille = new System.Windows.Forms.TextBox();
            this.labelVille = new System.Windows.Forms.Label();
            this.textBoxCodePostal = new System.Windows.Forms.TextBox();
            this.labelCodePostal = new System.Windows.Forms.Label();
            this.textBoxRue = new System.Windows.Forms.TextBox();
            this.labelRue = new System.Windows.Forms.Label();
            this.textBoxNoCivique = new System.Windows.Forms.TextBox();
            this.labelNoCivique = new System.Windows.Forms.Label();
            this.groupBoxVehiculesExclusDuRapport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehiculesExclusDuRapport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehiculesInclusDansRapport)).BeginInit();
            this.groupBoxVehiculesDansRapport.SuspendLayout();
            this.groupBoxAdresse.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxVehiculesExclusDuRapport
            // 
            this.groupBoxVehiculesExclusDuRapport.Controls.Add(this.buttonAjouterVehicule);
            this.groupBoxVehiculesExclusDuRapport.Controls.Add(this.dataGridViewVehiculesExclusDuRapport);
            this.groupBoxVehiculesExclusDuRapport.Location = new System.Drawing.Point(12, 29);
            this.groupBoxVehiculesExclusDuRapport.Name = "groupBoxVehiculesExclusDuRapport";
            this.groupBoxVehiculesExclusDuRapport.Size = new System.Drawing.Size(560, 178);
            this.groupBoxVehiculesExclusDuRapport.TabIndex = 1;
            this.groupBoxVehiculesExclusDuRapport.TabStop = false;
            this.groupBoxVehiculesExclusDuRapport.Text = "Véhicules non inclus dans le rapport";
            // 
            // buttonAjouterVehicule
            // 
            this.buttonAjouterVehicule.Location = new System.Drawing.Point(6, 149);
            this.buttonAjouterVehicule.Name = "buttonAjouterVehicule";
            this.buttonAjouterVehicule.Size = new System.Drawing.Size(546, 23);
            this.buttonAjouterVehicule.TabIndex = 1;
            this.buttonAjouterVehicule.Text = "Ajouter véhicule au rapport";
            this.buttonAjouterVehicule.UseVisualStyleBackColor = true;
            this.buttonAjouterVehicule.Click += new System.EventHandler(this.buttonAjouterVehicule_Click);
            // 
            // dataGridViewVehiculesExclusDuRapport
            // 
            this.dataGridViewVehiculesExclusDuRapport.AllowUserToAddRows = false;
            this.dataGridViewVehiculesExclusDuRapport.AllowUserToDeleteRows = false;
            this.dataGridViewVehiculesExclusDuRapport.AllowUserToOrderColumns = true;
            this.dataGridViewVehiculesExclusDuRapport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVehiculesExclusDuRapport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.marque,
            this.modèle,
            this.no_véhicule,
            this.année,
            this.statut,
            this.proprietaire,
            this.testProprietaire});
            this.dataGridViewVehiculesExclusDuRapport.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewVehiculesExclusDuRapport.Name = "dataGridViewVehiculesExclusDuRapport";
            this.dataGridViewVehiculesExclusDuRapport.ReadOnly = true;
            this.dataGridViewVehiculesExclusDuRapport.Size = new System.Drawing.Size(548, 124);
            this.dataGridViewVehiculesExclusDuRapport.TabIndex = 0;
            // 
            // marque
            // 
            this.marque.HeaderText = "Marque";
            this.marque.Name = "marque";
            this.marque.ReadOnly = true;
            // 
            // modèle
            // 
            this.modèle.HeaderText = "Modèle";
            this.modèle.Name = "modèle";
            this.modèle.ReadOnly = true;
            // 
            // no_véhicule
            // 
            this.no_véhicule.HeaderText = "No véhicule";
            this.no_véhicule.Name = "no_véhicule";
            this.no_véhicule.ReadOnly = true;
            // 
            // année
            // 
            this.année.HeaderText = "Année";
            this.année.Name = "année";
            this.année.ReadOnly = true;
            // 
            // statut
            // 
            this.statut.HeaderText = "Statut";
            this.statut.Name = "statut";
            this.statut.ReadOnly = true;
            // 
            // proprietaire
            // 
            this.proprietaire.HeaderText = "Propriétaire";
            this.proprietaire.Name = "proprietaire";
            this.proprietaire.ReadOnly = true;
            // 
            // testProprietaire
            // 
            this.testProprietaire.HeaderText = "testProprietaire";
            this.testProprietaire.Name = "testProprietaire";
            this.testProprietaire.ReadOnly = true;
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Location = new System.Drawing.Point(13, 13);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(97, 13);
            this.labelTitre.TabIndex = 0;
            this.labelTitre.Text = "Rapport d\'accident";
            // 
            // labelDateEtHeure
            // 
            this.labelDateEtHeure.AutoSize = true;
            this.labelDateEtHeure.Location = new System.Drawing.Point(672, 231);
            this.labelDateEtHeure.Name = "labelDateEtHeure";
            this.labelDateEtHeure.Size = new System.Drawing.Size(78, 13);
            this.labelDateEtHeure.TabIndex = 4;
            this.labelDateEtHeure.Text = "Date et heure :";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(756, 225);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(208, 20);
            this.dateTimePicker.TabIndex = 5;
            this.dateTimePicker.Value = new System.DateTime(2017, 9, 8, 16, 30, 0, 0);
            // 
            // labelRemarques
            // 
            this.labelRemarques.AutoSize = true;
            this.labelRemarques.Location = new System.Drawing.Point(15, 299);
            this.labelRemarques.Name = "labelRemarques";
            this.labelRemarques.Size = new System.Drawing.Size(67, 13);
            this.labelRemarques.TabIndex = 6;
            this.labelRemarques.Text = "Remarques :";
            // 
            // textBoxRemarques
            // 
            this.textBoxRemarques.Location = new System.Drawing.Point(12, 315);
            this.textBoxRemarques.Multiline = true;
            this.textBoxRemarques.Name = "textBoxRemarques";
            this.textBoxRemarques.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRemarques.Size = new System.Drawing.Size(1117, 230);
            this.textBoxRemarques.TabIndex = 7;
            // 
            // dataGridViewVehiculesInclusDansRapport
            // 
            this.dataGridViewVehiculesInclusDansRapport.AllowUserToAddRows = false;
            this.dataGridViewVehiculesInclusDansRapport.AllowUserToDeleteRows = false;
            this.dataGridViewVehiculesInclusDansRapport.AllowUserToOrderColumns = true;
            this.dataGridViewVehiculesInclusDansRapport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVehiculesInclusDansRapport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridViewVehiculesInclusDansRapport.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewVehiculesInclusDansRapport.Name = "dataGridViewVehiculesInclusDansRapport";
            this.dataGridViewVehiculesInclusDansRapport.ReadOnly = true;
            this.dataGridViewVehiculesInclusDansRapport.Size = new System.Drawing.Size(546, 124);
            this.dataGridViewVehiculesInclusDansRapport.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Marque";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Modèle";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "No véhicule";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Année";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Statut";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Propriétaire";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // groupBoxVehiculesDansRapport
            // 
            this.groupBoxVehiculesDansRapport.Controls.Add(this.buttonRetirerVehicule);
            this.groupBoxVehiculesDansRapport.Controls.Add(this.dataGridViewVehiculesInclusDansRapport);
            this.groupBoxVehiculesDansRapport.Location = new System.Drawing.Point(578, 29);
            this.groupBoxVehiculesDansRapport.Name = "groupBoxVehiculesDansRapport";
            this.groupBoxVehiculesDansRapport.Size = new System.Drawing.Size(560, 180);
            this.groupBoxVehiculesDansRapport.TabIndex = 2;
            this.groupBoxVehiculesDansRapport.TabStop = false;
            this.groupBoxVehiculesDansRapport.Text = "Véhicules inclus dans le rapport";
            // 
            // buttonRetirerVehicule
            // 
            this.buttonRetirerVehicule.Location = new System.Drawing.Point(6, 149);
            this.buttonRetirerVehicule.Name = "buttonRetirerVehicule";
            this.buttonRetirerVehicule.Size = new System.Drawing.Size(546, 23);
            this.buttonRetirerVehicule.TabIndex = 1;
            this.buttonRetirerVehicule.Text = "Retirer véhicule du rapport";
            this.buttonRetirerVehicule.UseVisualStyleBackColor = true;
            this.buttonRetirerVehicule.Click += new System.EventHandler(this.buttonRetirerVehicule_Click);
            // 
            // groupBoxAdresse
            // 
            this.groupBoxAdresse.Controls.Add(this.comboBoxProvince);
            this.groupBoxAdresse.Controls.Add(this.labelProvince);
            this.groupBoxAdresse.Controls.Add(this.textBoxPays);
            this.groupBoxAdresse.Controls.Add(this.labelPays);
            this.groupBoxAdresse.Controls.Add(this.textBoxVille);
            this.groupBoxAdresse.Controls.Add(this.labelVille);
            this.groupBoxAdresse.Controls.Add(this.textBoxCodePostal);
            this.groupBoxAdresse.Controls.Add(this.labelCodePostal);
            this.groupBoxAdresse.Controls.Add(this.textBoxRue);
            this.groupBoxAdresse.Controls.Add(this.labelRue);
            this.groupBoxAdresse.Controls.Add(this.textBoxNoCivique);
            this.groupBoxAdresse.Controls.Add(this.labelNoCivique);
            this.groupBoxAdresse.Location = new System.Drawing.Point(13, 214);
            this.groupBoxAdresse.Name = "groupBoxAdresse";
            this.groupBoxAdresse.Size = new System.Drawing.Size(653, 73);
            this.groupBoxAdresse.TabIndex = 3;
            this.groupBoxAdresse.TabStop = false;
            this.groupBoxAdresse.Text = "Adresse";
            // 
            // comboBoxProvince
            // 
            this.comboBoxProvince.FormattingEnabled = true;
            this.comboBoxProvince.Location = new System.Drawing.Point(375, 41);
            this.comboBoxProvince.Name = "comboBoxProvince";
            this.comboBoxProvince.Size = new System.Drawing.Size(86, 21);
            this.comboBoxProvince.TabIndex = 9;
            // 
            // labelProvince
            // 
            this.labelProvince.AutoSize = true;
            this.labelProvince.Location = new System.Drawing.Point(313, 44);
            this.labelProvince.Name = "labelProvince";
            this.labelProvince.Size = new System.Drawing.Size(55, 13);
            this.labelProvince.TabIndex = 8;
            this.labelProvince.Text = "Province :";
            // 
            // textBoxPays
            // 
            this.textBoxPays.Location = new System.Drawing.Point(509, 41);
            this.textBoxPays.Name = "textBoxPays";
            this.textBoxPays.Size = new System.Drawing.Size(138, 20);
            this.textBoxPays.TabIndex = 11;
            // 
            // labelPays
            // 
            this.labelPays.AutoSize = true;
            this.labelPays.Location = new System.Drawing.Point(467, 44);
            this.labelPays.Name = "labelPays";
            this.labelPays.Size = new System.Drawing.Size(36, 13);
            this.labelPays.TabIndex = 10;
            this.labelPays.Text = "Pays :";
            // 
            // textBoxVille
            // 
            this.textBoxVille.Location = new System.Drawing.Point(45, 41);
            this.textBoxVille.Name = "textBoxVille";
            this.textBoxVille.Size = new System.Drawing.Size(213, 20);
            this.textBoxVille.TabIndex = 7;
            // 
            // labelVille
            // 
            this.labelVille.AutoSize = true;
            this.labelVille.Location = new System.Drawing.Point(7, 44);
            this.labelVille.Name = "labelVille";
            this.labelVille.Size = new System.Drawing.Size(32, 13);
            this.labelVille.TabIndex = 6;
            this.labelVille.Text = "Ville :";
            // 
            // textBoxCodePostal
            // 
            this.textBoxCodePostal.Location = new System.Drawing.Point(560, 17);
            this.textBoxCodePostal.Name = "textBoxCodePostal";
            this.textBoxCodePostal.Size = new System.Drawing.Size(87, 20);
            this.textBoxCodePostal.TabIndex = 5;
            // 
            // labelCodePostal
            // 
            this.labelCodePostal.AutoSize = true;
            this.labelCodePostal.Location = new System.Drawing.Point(482, 18);
            this.labelCodePostal.Name = "labelCodePostal";
            this.labelCodePostal.Size = new System.Drawing.Size(69, 13);
            this.labelCodePostal.TabIndex = 4;
            this.labelCodePostal.Text = "Code postal :";
            // 
            // textBoxRue
            // 
            this.textBoxRue.Location = new System.Drawing.Point(303, 14);
            this.textBoxRue.Name = "textBoxRue";
            this.textBoxRue.Size = new System.Drawing.Size(158, 20);
            this.textBoxRue.TabIndex = 3;
            // 
            // labelRue
            // 
            this.labelRue.AutoSize = true;
            this.labelRue.Location = new System.Drawing.Point(264, 20);
            this.labelRue.Name = "labelRue";
            this.labelRue.Size = new System.Drawing.Size(33, 13);
            this.labelRue.TabIndex = 2;
            this.labelRue.Text = "Rue :";
            // 
            // textBoxNoCivique
            // 
            this.textBoxNoCivique.Location = new System.Drawing.Point(100, 17);
            this.textBoxNoCivique.Name = "textBoxNoCivique";
            this.textBoxNoCivique.Size = new System.Drawing.Size(72, 20);
            this.textBoxNoCivique.TabIndex = 1;
            // 
            // labelNoCivique
            // 
            this.labelNoCivique.AutoSize = true;
            this.labelNoCivique.Location = new System.Drawing.Point(7, 20);
            this.labelNoCivique.Name = "labelNoCivique";
            this.labelNoCivique.Size = new System.Drawing.Size(87, 13);
            this.labelNoCivique.TabIndex = 0;
            this.labelNoCivique.Text = "Numéro civique :";
            // 
            // DlgRapportAccident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 597);
            this.Controls.Add(this.groupBoxAdresse);
            this.Controls.Add(this.groupBoxVehiculesDansRapport);
            this.Controls.Add(this.textBoxRemarques);
            this.Controls.Add(this.labelRemarques);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.labelDateEtHeure);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.groupBoxVehiculesExclusDuRapport);
            this.Name = "DlgRapportAccident";
            this.Text = "Rapport d\'accident";
            this.Controls.SetChildIndex(this.groupBoxVehiculesExclusDuRapport, 0);
            this.Controls.SetChildIndex(this.labelTitre, 0);
            this.Controls.SetChildIndex(this.labelDateEtHeure, 0);
            this.Controls.SetChildIndex(this.dateTimePicker, 0);
            this.Controls.SetChildIndex(this.labelRemarques, 0);
            this.Controls.SetChildIndex(this.textBoxRemarques, 0);
            this.Controls.SetChildIndex(this.groupBoxVehiculesDansRapport, 0);
            this.Controls.SetChildIndex(this.groupBoxAdresse, 0);
            this.groupBoxVehiculesExclusDuRapport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehiculesExclusDuRapport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehiculesInclusDansRapport)).EndInit();
            this.groupBoxVehiculesDansRapport.ResumeLayout(false);
            this.groupBoxAdresse.ResumeLayout(false);
            this.groupBoxAdresse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxVehiculesExclusDuRapport;
        private System.Windows.Forms.DataGridView dataGridViewVehiculesExclusDuRapport;
        private System.Windows.Forms.Button buttonAjouterVehicule;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Label labelDateEtHeure;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label labelRemarques;
        private System.Windows.Forms.TextBox textBoxRemarques;
        private System.Windows.Forms.DataGridView dataGridViewVehiculesInclusDansRapport;
        private System.Windows.Forms.GroupBox groupBoxVehiculesDansRapport;
        private System.Windows.Forms.Button buttonRetirerVehicule;
        private System.Windows.Forms.GroupBox groupBoxAdresse;
        private System.Windows.Forms.TextBox textBoxPays;
        private System.Windows.Forms.Label labelPays;
        private System.Windows.Forms.TextBox textBoxVille;
        private System.Windows.Forms.Label labelVille;
        private System.Windows.Forms.TextBox textBoxCodePostal;
        private System.Windows.Forms.Label labelCodePostal;
        private System.Windows.Forms.TextBox textBoxRue;
        private System.Windows.Forms.Label labelRue;
        private System.Windows.Forms.TextBox textBoxNoCivique;
        private System.Windows.Forms.Label labelNoCivique;
        private System.Windows.Forms.Label labelProvince;
        private System.Windows.Forms.ComboBox comboBoxProvince;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnMarque;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnModele;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnNoVehicule;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnAnnee;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnStatut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn marque;
        private System.Windows.Forms.DataGridViewTextBoxColumn modèle;
        private System.Windows.Forms.DataGridViewTextBoxColumn no_véhicule;
        private System.Windows.Forms.DataGridViewTextBoxColumn année;
        private System.Windows.Forms.DataGridViewTextBoxColumn statut;
        private System.Windows.Forms.DataGridViewTextBoxColumn proprietaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn testProprietaire;
    }
}
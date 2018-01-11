namespace GestionEnquetes
{
    partial class DlgAjoutDossier
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
            this.comboBoxStatut = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewPersonnes = new System.Windows.Forms.ListView();
            this.colNom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrénom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAjouterPersonne = new System.Windows.Forms.Button();
            this.buttonAjouterVehicule = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.listViewVehicules = new System.Windows.Forms.ListView();
            this.colMarque = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colModele = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAnnee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAfficherREnq = new System.Windows.Forms.Button();
            this.buttonSupprimerREnq = new System.Windows.Forms.Button();
            this.buttonAjouterREnq = new System.Windows.Forms.Button();
            this.labelREnq = new System.Windows.Forms.Label();
            this.labelRAcc = new System.Windows.Forms.Label();
            this.buttonAjouterRAcc = new System.Windows.Forms.Button();
            this.buttonSupprimerRAcc = new System.Windows.Forms.Button();
            this.buttonAfficherRAcc = new System.Windows.Forms.Button();
            this.labelREve = new System.Windows.Forms.Label();
            this.buttonAjouterREve = new System.Windows.Forms.Button();
            this.buttonSupprimerREve = new System.Windows.Forms.Button();
            this.buttonAfficherREve = new System.Windows.Forms.Button();
            this.buttonModifDest = new System.Windows.Forms.Button();
            this.labelDestination = new System.Windows.Forms.Label();
            this.checkBoxEtiquete = new System.Windows.Forms.CheckBox();
            this.buttonModifierREnq = new System.Windows.Forms.Button();
            this.buttonModifierRAcc = new System.Windows.Forms.Button();
            this.buttonModifierREve = new System.Windows.Forms.Button();
            this.groupBoxRAcc = new System.Windows.Forms.GroupBox();
            this.groupBoxREve = new System.Windows.Forms.GroupBox();
            this.groupBoxREnq = new System.Windows.Forms.GroupBox();
            this.buttonRetirerDest = new System.Windows.Forms.Button();
            this.buttonAjouterDest = new System.Windows.Forms.Button();
            this.buttonHistorique = new System.Windows.Forms.Button();
            this.groupBoxDestination = new System.Windows.Forms.GroupBox();
            this.groupBoxRAcc.SuspendLayout();
            this.groupBoxREve.SuspendLayout();
            this.groupBoxREnq.SuspendLayout();
            this.groupBoxDestination.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxStatut
            // 
            this.comboBoxStatut.Enabled = false;
            this.comboBoxStatut.FormattingEnabled = true;
            this.comboBoxStatut.Location = new System.Drawing.Point(45, 29);
            this.comboBoxStatut.Name = "comboBoxStatut";
            this.comboBoxStatut.Size = new System.Drawing.Size(224, 21);
            this.comboBoxStatut.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Statut";
            // 
            // listViewPersonnes
            // 
            this.listViewPersonnes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNom,
            this.colPrénom});
            this.listViewPersonnes.Location = new System.Drawing.Point(42, 80);
            this.listViewPersonnes.Name = "listViewPersonnes";
            this.listViewPersonnes.Size = new System.Drawing.Size(224, 139);
            this.listViewPersonnes.TabIndex = 8;
            this.listViewPersonnes.UseCompatibleStateImageBehavior = false;
            this.listViewPersonnes.View = System.Windows.Forms.View.Details;
            this.listViewPersonnes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewPersonnes_DoubleClick);
            // 
            // colNom
            // 
            this.colNom.Text = "Nom";
            this.colNom.Width = 101;
            // 
            // colPrénom
            // 
            this.colPrénom.Text = "Prénom";
            this.colPrénom.Width = 119;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Personnes impliqués";
            // 
            // buttonAjouterPersonne
            // 
            this.buttonAjouterPersonne.Location = new System.Drawing.Point(42, 225);
            this.buttonAjouterPersonne.Name = "buttonAjouterPersonne";
            this.buttonAjouterPersonne.Size = new System.Drawing.Size(224, 23);
            this.buttonAjouterPersonne.TabIndex = 10;
            this.buttonAjouterPersonne.Text = "Ajouter une presonne";
            this.buttonAjouterPersonne.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAjouterPersonne.UseVisualStyleBackColor = true;
            this.buttonAjouterPersonne.Click += new System.EventHandler(this.buttonAjouterPersonne_Click);
            // 
            // buttonAjouterVehicule
            // 
            this.buttonAjouterVehicule.Location = new System.Drawing.Point(347, 225);
            this.buttonAjouterVehicule.Name = "buttonAjouterVehicule";
            this.buttonAjouterVehicule.Size = new System.Drawing.Size(293, 23);
            this.buttonAjouterVehicule.TabIndex = 13;
            this.buttonAjouterVehicule.Text = "Ajouter un vehicule";
            this.buttonAjouterVehicule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAjouterVehicule.UseVisualStyleBackColor = true;
            this.buttonAjouterVehicule.Click += new System.EventHandler(this.buttonAjouterVehicule_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(347, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Véhicules impliqués";
            // 
            // listViewVehicules
            // 
            this.listViewVehicules.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMarque,
            this.colModele,
            this.colAnnee});
            this.listViewVehicules.Location = new System.Drawing.Point(347, 80);
            this.listViewVehicules.Name = "listViewVehicules";
            this.listViewVehicules.Size = new System.Drawing.Size(293, 139);
            this.listViewVehicules.TabIndex = 11;
            this.listViewVehicules.UseCompatibleStateImageBehavior = false;
            this.listViewVehicules.View = System.Windows.Forms.View.Details;
            this.listViewVehicules.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewVehicules_DoubleClick);
            // 
            // colMarque
            // 
            this.colMarque.Text = "Marque";
            this.colMarque.Width = 92;
            // 
            // colModele
            // 
            this.colModele.Text = "Modèle";
            this.colModele.Width = 116;
            // 
            // colAnnee
            // 
            this.colAnnee.Text = "Année";
            this.colAnnee.Width = 81;
            // 
            // buttonAfficherREnq
            // 
            this.buttonAfficherREnq.Location = new System.Drawing.Point(139, 35);
            this.buttonAfficherREnq.Name = "buttonAfficherREnq";
            this.buttonAfficherREnq.Size = new System.Drawing.Size(55, 23);
            this.buttonAfficherREnq.TabIndex = 1003;
            this.buttonAfficherREnq.Text = "Afficher";
            this.buttonAfficherREnq.UseVisualStyleBackColor = true;
            this.buttonAfficherREnq.Click += new System.EventHandler(this.buttonAfficherREnq_Click);
            // 
            // buttonSupprimerREnq
            // 
            this.buttonSupprimerREnq.Location = new System.Drawing.Point(41, 35);
            this.buttonSupprimerREnq.Name = "buttonSupprimerREnq";
            this.buttonSupprimerREnq.Size = new System.Drawing.Size(25, 23);
            this.buttonSupprimerREnq.TabIndex = 1004;
            this.buttonSupprimerREnq.Text = "-";
            this.buttonSupprimerREnq.UseVisualStyleBackColor = true;
            this.buttonSupprimerREnq.Click += new System.EventHandler(this.buttonSupprimerREnq_Click);
            // 
            // buttonAjouterREnq
            // 
            this.buttonAjouterREnq.Location = new System.Drawing.Point(10, 35);
            this.buttonAjouterREnq.Name = "buttonAjouterREnq";
            this.buttonAjouterREnq.Size = new System.Drawing.Size(25, 23);
            this.buttonAjouterREnq.TabIndex = 1005;
            this.buttonAjouterREnq.Text = "+";
            this.buttonAjouterREnq.UseVisualStyleBackColor = true;
            this.buttonAjouterREnq.Click += new System.EventHandler(this.buttonAjouterREnq_Click);
            // 
            // labelREnq
            // 
            this.labelREnq.AutoSize = true;
            this.labelREnq.Location = new System.Drawing.Point(9, 16);
            this.labelREnq.Name = "labelREnq";
            this.labelREnq.Size = new System.Drawing.Size(162, 13);
            this.labelREnq.TabIndex = 1006;
            this.labelREnq.Text = "Aucun rapport d\'enquête n\'est lié";
            // 
            // labelRAcc
            // 
            this.labelRAcc.AutoSize = true;
            this.labelRAcc.Location = new System.Drawing.Point(7, 16);
            this.labelRAcc.Name = "labelRAcc";
            this.labelRAcc.Size = new System.Drawing.Size(164, 13);
            this.labelRAcc.TabIndex = 1010;
            this.labelRAcc.Text = "Aucun rapport d\'accident n\'est lié";
            // 
            // buttonAjouterRAcc
            // 
            this.buttonAjouterRAcc.Location = new System.Drawing.Point(10, 32);
            this.buttonAjouterRAcc.Name = "buttonAjouterRAcc";
            this.buttonAjouterRAcc.Size = new System.Drawing.Size(25, 23);
            this.buttonAjouterRAcc.TabIndex = 1009;
            this.buttonAjouterRAcc.Text = "+";
            this.buttonAjouterRAcc.UseVisualStyleBackColor = true;
            this.buttonAjouterRAcc.Click += new System.EventHandler(this.buttonAjouterRAcc_Click);
            // 
            // buttonSupprimerRAcc
            // 
            this.buttonSupprimerRAcc.Location = new System.Drawing.Point(41, 32);
            this.buttonSupprimerRAcc.Name = "buttonSupprimerRAcc";
            this.buttonSupprimerRAcc.Size = new System.Drawing.Size(25, 23);
            this.buttonSupprimerRAcc.TabIndex = 1008;
            this.buttonSupprimerRAcc.Text = "-";
            this.buttonSupprimerRAcc.UseVisualStyleBackColor = true;
            this.buttonSupprimerRAcc.Click += new System.EventHandler(this.buttonSupprimerRAcc_Click);
            // 
            // buttonAfficherRAcc
            // 
            this.buttonAfficherRAcc.Location = new System.Drawing.Point(139, 32);
            this.buttonAfficherRAcc.Name = "buttonAfficherRAcc";
            this.buttonAfficherRAcc.Size = new System.Drawing.Size(55, 23);
            this.buttonAfficherRAcc.TabIndex = 1007;
            this.buttonAfficherRAcc.Text = "Afficher";
            this.buttonAfficherRAcc.UseVisualStyleBackColor = true;
            this.buttonAfficherRAcc.Click += new System.EventHandler(this.buttonAfficherRAcc_Click);
            // 
            // labelREve
            // 
            this.labelREve.AutoSize = true;
            this.labelREve.Location = new System.Drawing.Point(7, 16);
            this.labelREve.Name = "labelREve";
            this.labelREve.Size = new System.Drawing.Size(176, 13);
            this.labelREve.TabIndex = 1014;
            this.labelREve.Text = "Aucun rapport d\'évènement n\'est lié";
            // 
            // buttonAjouterREve
            // 
            this.buttonAjouterREve.Location = new System.Drawing.Point(6, 32);
            this.buttonAjouterREve.Name = "buttonAjouterREve";
            this.buttonAjouterREve.Size = new System.Drawing.Size(25, 23);
            this.buttonAjouterREve.TabIndex = 1013;
            this.buttonAjouterREve.Text = "+";
            this.buttonAjouterREve.UseVisualStyleBackColor = true;
            this.buttonAjouterREve.Click += new System.EventHandler(this.buttonAjouterREve_Click);
            // 
            // buttonSupprimerREve
            // 
            this.buttonSupprimerREve.Location = new System.Drawing.Point(37, 32);
            this.buttonSupprimerREve.Name = "buttonSupprimerREve";
            this.buttonSupprimerREve.Size = new System.Drawing.Size(25, 23);
            this.buttonSupprimerREve.TabIndex = 1012;
            this.buttonSupprimerREve.Text = "-";
            this.buttonSupprimerREve.UseVisualStyleBackColor = true;
            this.buttonSupprimerREve.Click += new System.EventHandler(this.buttonSupprimerREve_Click);
            // 
            // buttonAfficherREve
            // 
            this.buttonAfficherREve.Location = new System.Drawing.Point(133, 32);
            this.buttonAfficherREve.Name = "buttonAfficherREve";
            this.buttonAfficherREve.Size = new System.Drawing.Size(61, 23);
            this.buttonAfficherREve.TabIndex = 1011;
            this.buttonAfficherREve.Text = "Afficher";
            this.buttonAfficherREve.UseVisualStyleBackColor = true;
            this.buttonAfficherREve.Click += new System.EventHandler(this.buttonAfficherREve_Click);
            // 
            // buttonModifDest
            // 
            this.buttonModifDest.Enabled = false;
            this.buttonModifDest.Location = new System.Drawing.Point(68, 32);
            this.buttonModifDest.Name = "buttonModifDest";
            this.buttonModifDest.Size = new System.Drawing.Size(59, 23);
            this.buttonModifDest.TabIndex = 1015;
            this.buttonModifDest.Text = "Modifier";
            this.buttonModifDest.UseVisualStyleBackColor = true;
            this.buttonModifDest.Click += new System.EventHandler(this.buttonDestination_Click);
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Location = new System.Drawing.Point(7, 16);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(111, 13);
            this.labelDestination.TabIndex = 1016;
            this.labelDestination.Text = "Destination par défaut";
            // 
            // checkBoxEtiquete
            // 
            this.checkBoxEtiquete.AutoSize = true;
            this.checkBoxEtiquete.Location = new System.Drawing.Point(600, 380);
            this.checkBoxEtiquete.Name = "checkBoxEtiquete";
            this.checkBoxEtiquete.Size = new System.Drawing.Size(65, 17);
            this.checkBoxEtiquete.TabIndex = 1015;
            this.checkBoxEtiquete.Text = "Étiqueté";
            this.checkBoxEtiquete.UseVisualStyleBackColor = true;
            // 
            // buttonModifierREnq
            // 
            this.buttonModifierREnq.Location = new System.Drawing.Point(72, 35);
            this.buttonModifierREnq.Name = "buttonModifierREnq";
            this.buttonModifierREnq.Size = new System.Drawing.Size(59, 23);
            this.buttonModifierREnq.TabIndex = 1015;
            this.buttonModifierREnq.Text = "Modifier";
            this.buttonModifierREnq.UseVisualStyleBackColor = true;
            this.buttonModifierREnq.Click += new System.EventHandler(this.buttonModifierREnq_Click);
            // 
            // buttonModifierRAcc
            // 
            this.buttonModifierRAcc.Location = new System.Drawing.Point(72, 32);
            this.buttonModifierRAcc.Name = "buttonModifierRAcc";
            this.buttonModifierRAcc.Size = new System.Drawing.Size(59, 23);
            this.buttonModifierRAcc.TabIndex = 1016;
            this.buttonModifierRAcc.Text = "Modifier";
            this.buttonModifierRAcc.UseVisualStyleBackColor = true;
            this.buttonModifierRAcc.Click += new System.EventHandler(this.buttonModifierRAcc_Click);
            // 
            // buttonModifierREve
            // 
            this.buttonModifierREve.Location = new System.Drawing.Point(68, 32);
            this.buttonModifierREve.Name = "buttonModifierREve";
            this.buttonModifierREve.Size = new System.Drawing.Size(59, 23);
            this.buttonModifierREve.TabIndex = 1017;
            this.buttonModifierREve.Text = "Modifier";
            this.buttonModifierREve.UseVisualStyleBackColor = true;
            this.buttonModifierREve.Click += new System.EventHandler(this.buttonModifierREve_Click);
            // 
            // groupBoxRAcc
            // 
            this.groupBoxRAcc.Controls.Add(this.buttonModifierRAcc);
            this.groupBoxRAcc.Controls.Add(this.buttonAfficherRAcc);
            this.groupBoxRAcc.Controls.Add(this.buttonSupprimerRAcc);
            this.groupBoxRAcc.Controls.Add(this.buttonAjouterRAcc);
            this.groupBoxRAcc.Controls.Add(this.labelRAcc);
            this.groupBoxRAcc.Location = new System.Drawing.Point(42, 268);
            this.groupBoxRAcc.Name = "groupBoxRAcc";
            this.groupBoxRAcc.Size = new System.Drawing.Size(227, 61);
            this.groupBoxRAcc.TabIndex = 1018;
            this.groupBoxRAcc.TabStop = false;
            this.groupBoxRAcc.Text = "Rapport d\'accident :";
            // 
            // groupBoxREve
            // 
            this.groupBoxREve.Controls.Add(this.buttonModifierREve);
            this.groupBoxREve.Controls.Add(this.buttonAfficherREve);
            this.groupBoxREve.Controls.Add(this.buttonAjouterREve);
            this.groupBoxREve.Controls.Add(this.buttonSupprimerREve);
            this.groupBoxREve.Controls.Add(this.labelREve);
            this.groupBoxREve.Location = new System.Drawing.Point(347, 268);
            this.groupBoxREve.Name = "groupBoxREve";
            this.groupBoxREve.Size = new System.Drawing.Size(227, 61);
            this.groupBoxREve.TabIndex = 1019;
            this.groupBoxREve.TabStop = false;
            this.groupBoxREve.Text = "Rapport d\'évènement :";
            // 
            // groupBoxREnq
            // 
            this.groupBoxREnq.Controls.Add(this.buttonModifierREnq);
            this.groupBoxREnq.Controls.Add(this.buttonAfficherREnq);
            this.groupBoxREnq.Controls.Add(this.buttonAjouterREnq);
            this.groupBoxREnq.Controls.Add(this.buttonSupprimerREnq);
            this.groupBoxREnq.Controls.Add(this.labelREnq);
            this.groupBoxREnq.Location = new System.Drawing.Point(42, 335);
            this.groupBoxREnq.Name = "groupBoxREnq";
            this.groupBoxREnq.Size = new System.Drawing.Size(227, 64);
            this.groupBoxREnq.TabIndex = 1020;
            this.groupBoxREnq.TabStop = false;
            this.groupBoxREnq.Text = "Rapport d\'enquête :";
            // 
            // buttonRetirerDest
            // 
            this.buttonRetirerDest.Enabled = false;
            this.buttonRetirerDest.Location = new System.Drawing.Point(37, 32);
            this.buttonRetirerDest.Name = "buttonRetirerDest";
            this.buttonRetirerDest.Size = new System.Drawing.Size(25, 23);
            this.buttonRetirerDest.TabIndex = 1021;
            this.buttonRetirerDest.Text = "-";
            this.buttonRetirerDest.UseVisualStyleBackColor = true;
            this.buttonRetirerDest.Click += new System.EventHandler(this.buttonRetirerDest_Click);
            // 
            // buttonAjouterDest
            // 
            this.buttonAjouterDest.Location = new System.Drawing.Point(6, 32);
            this.buttonAjouterDest.Name = "buttonAjouterDest";
            this.buttonAjouterDest.Size = new System.Drawing.Size(25, 23);
            this.buttonAjouterDest.TabIndex = 1022;
            this.buttonAjouterDest.Text = "+";
            this.buttonAjouterDest.UseVisualStyleBackColor = true;
            this.buttonAjouterDest.Click += new System.EventHandler(this.buttonAjouterDest_Click);
            // 
            // buttonHistorique
            // 
            this.buttonHistorique.Location = new System.Drawing.Point(133, 31);
            this.buttonHistorique.Name = "buttonHistorique";
            this.buttonHistorique.Size = new System.Drawing.Size(62, 23);
            this.buttonHistorique.TabIndex = 1023;
            this.buttonHistorique.Text = "Historique";
            this.buttonHistorique.UseVisualStyleBackColor = true;
            this.buttonHistorique.Click += new System.EventHandler(this.buttonHistorique_Click);
            // 
            // groupBoxDestination
            // 
            this.groupBoxDestination.Controls.Add(this.buttonAjouterDest);
            this.groupBoxDestination.Controls.Add(this.buttonHistorique);
            this.groupBoxDestination.Controls.Add(this.labelDestination);
            this.groupBoxDestination.Controls.Add(this.buttonRetirerDest);
            this.groupBoxDestination.Controls.Add(this.buttonModifDest);
            this.groupBoxDestination.Location = new System.Drawing.Point(347, 338);
            this.groupBoxDestination.Name = "groupBoxDestination";
            this.groupBoxDestination.Size = new System.Drawing.Size(227, 61);
            this.groupBoxDestination.TabIndex = 1024;
            this.groupBoxDestination.TabStop = false;
            this.groupBoxDestination.Text = "Destination :";
            // 
            // DlgAjoutDossier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 448);
            this.Controls.Add(this.groupBoxDestination);
            this.Controls.Add(this.groupBoxREnq);
            this.Controls.Add(this.groupBoxREve);
            this.Controls.Add(this.groupBoxRAcc);
            this.Controls.Add(this.checkBoxEtiquete);
            this.Controls.Add(this.buttonAjouterVehicule);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listViewVehicules);
            this.Controls.Add(this.buttonAjouterPersonne);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listViewPersonnes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxStatut);
            this.Name = "DlgAjoutDossier";
            this.Text = "Ajout d\'un dossier";
            this.Controls.SetChildIndex(this.comboBoxStatut, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.listViewPersonnes, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.buttonAjouterPersonne, 0);
            this.Controls.SetChildIndex(this.listViewVehicules, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.buttonAjouterVehicule, 0);
            this.Controls.SetChildIndex(this.checkBoxEtiquete, 0);
            this.Controls.SetChildIndex(this.groupBoxRAcc, 0);
            this.Controls.SetChildIndex(this.groupBoxREve, 0);
            this.Controls.SetChildIndex(this.groupBoxREnq, 0);
            this.Controls.SetChildIndex(this.groupBoxDestination, 0);
            this.groupBoxRAcc.ResumeLayout(false);
            this.groupBoxRAcc.PerformLayout();
            this.groupBoxREve.ResumeLayout(false);
            this.groupBoxREve.PerformLayout();
            this.groupBoxREnq.ResumeLayout(false);
            this.groupBoxREnq.PerformLayout();
            this.groupBoxDestination.ResumeLayout(false);
            this.groupBoxDestination.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxStatut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewPersonnes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAjouterPersonne;
        private System.Windows.Forms.Button buttonAjouterVehicule;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listViewVehicules;
        private System.Windows.Forms.ColumnHeader colNom;
        private System.Windows.Forms.ColumnHeader colPrénom;
        private System.Windows.Forms.ColumnHeader colMarque;
        private System.Windows.Forms.ColumnHeader colModele;
        private System.Windows.Forms.ColumnHeader colAnnee;
        private System.Windows.Forms.Button buttonAfficherREnq;
        private System.Windows.Forms.Button buttonSupprimerREnq;
        private System.Windows.Forms.Button buttonAjouterREnq;
        private System.Windows.Forms.Label labelREnq;
        private System.Windows.Forms.Label labelRAcc;
        private System.Windows.Forms.Button buttonAjouterRAcc;
        private System.Windows.Forms.Button buttonSupprimerRAcc;
        private System.Windows.Forms.Button buttonAfficherRAcc;
        private System.Windows.Forms.Label labelREve;
        private System.Windows.Forms.Button buttonAjouterREve;
        private System.Windows.Forms.Button buttonSupprimerREve;
        private System.Windows.Forms.Button buttonAfficherREve;
        private System.Windows.Forms.Button buttonModifDest;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.CheckBox checkBoxEtiquete;
        private System.Windows.Forms.Button buttonModifierREnq;
        private System.Windows.Forms.Button buttonModifierRAcc;
        private System.Windows.Forms.Button buttonModifierREve;
        private System.Windows.Forms.GroupBox groupBoxRAcc;
        private System.Windows.Forms.GroupBox groupBoxREve;
        private System.Windows.Forms.GroupBox groupBoxREnq;
        private System.Windows.Forms.Button buttonRetirerDest;
        private System.Windows.Forms.Button buttonAjouterDest;
        private System.Windows.Forms.Button buttonHistorique;
        private System.Windows.Forms.GroupBox groupBoxDestination;
    }
}
namespace GestionEnquetes
{
    partial class FormPrincipale
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierMotDePasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.déconexionToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dossierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewDossier = new System.Windows.Forms.DataGridView();
            this.colNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMatricule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStatut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDossierOuvertSeulement = new System.Windows.Forms.Button();
            this.buttonDossierBECSeulement = new System.Windows.Forms.Button();
            this.buttonEtiquete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMesDossier = new System.Windows.Forms.Button();
            this.buttonTousLesDossiers = new System.Windows.Forms.Button();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxLegendDestination = new System.Windows.Forms.GroupBox();
            this.labelARC = new System.Windows.Forms.Label();
            this.labelATT = new System.Windows.Forms.Label();
            this.labelBEC = new System.Windows.Forms.Label();
            this.labelRED = new System.Windows.Forms.Label();
            this.labelREV = new System.Windows.Forms.Label();
            this.labelSD = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDossier)).BeginInit();
            this.groupBoxLegendDestination.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.compteToolStripMenuItem,
            this.dossierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(535, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierMotDePasseToolStripMenuItem,
            this.déconexionToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // modifierMotDePasseToolStripMenuItem
            // 
            this.modifierMotDePasseToolStripMenuItem.Name = "modifierMotDePasseToolStripMenuItem";
            this.modifierMotDePasseToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.modifierMotDePasseToolStripMenuItem.Text = "Modifier Mot De passe";
            this.modifierMotDePasseToolStripMenuItem.Click += new System.EventHandler(this.modifierMotDePasseToolStripMenuItem_Click);
            // 
            // déconexionToolStripMenuItem
            // 
            this.déconexionToolStripMenuItem.Name = "déconexionToolStripMenuItem";
            this.déconexionToolStripMenuItem.Size = new System.Drawing.Size(190, 6);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // compteToolStripMenuItem
            // 
            this.compteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afficherToolStripMenuItem,
            this.ajouterToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.compteToolStripMenuItem.Name = "compteToolStripMenuItem";
            this.compteToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.compteToolStripMenuItem.Text = "Compte";
            // 
            // afficherToolStripMenuItem
            // 
            this.afficherToolStripMenuItem.Name = "afficherToolStripMenuItem";
            this.afficherToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.afficherToolStripMenuItem.Text = "Afficher";
            this.afficherToolStripMenuItem.Click += new System.EventHandler(this.afficherCompteToolStripMenuItem_Click);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterCompteToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierCompteToolStripMenuItem_Click);
            // 
            // dossierToolStripMenuItem
            // 
            this.dossierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem1});
            this.dossierToolStripMenuItem.Name = "dossierToolStripMenuItem";
            this.dossierToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.dossierToolStripMenuItem.Text = "Dossier";
            // 
            // ajouterToolStripMenuItem1
            // 
            this.ajouterToolStripMenuItem1.Name = "ajouterToolStripMenuItem1";
            this.ajouterToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.ajouterToolStripMenuItem1.Text = "Ajouter";
            this.ajouterToolStripMenuItem1.Click += new System.EventHandler(this.ajouterToolStripMenuItem1_Click);
            // 
            // dataGridViewDossier
            // 
            this.dataGridViewDossier.AllowUserToAddRows = false;
            this.dataGridViewDossier.AllowUserToDeleteRows = false;
            this.dataGridViewDossier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDossier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDossier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumero,
            this.colMatricule,
            this.ColStatut});
            this.dataGridViewDossier.Location = new System.Drawing.Point(13, 66);
            this.dataGridViewDossier.Name = "dataGridViewDossier";
            this.dataGridViewDossier.ReadOnly = true;
            this.dataGridViewDossier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDossier.Size = new System.Drawing.Size(510, 480);
            this.dataGridViewDossier.TabIndex = 1;
            this.dataGridViewDossier.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDossier_CellContentDoubleClick);
            this.dataGridViewDossier.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewDossier_RowsAdded);
            // 
            // colNumero
            // 
            this.colNumero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colNumero.HeaderText = "Numéro";
            this.colNumero.Name = "colNumero";
            this.colNumero.ReadOnly = true;
            this.colNumero.Width = 69;
            // 
            // colMatricule
            // 
            this.colMatricule.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMatricule.HeaderText = "Matricule";
            this.colMatricule.Name = "colMatricule";
            this.colMatricule.ReadOnly = true;
            // 
            // ColStatut
            // 
            this.ColStatut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColStatut.HeaderText = "Statut";
            this.ColStatut.Name = "ColStatut";
            this.ColStatut.ReadOnly = true;
            // 
            // buttonDossierOuvertSeulement
            // 
            this.buttonDossierOuvertSeulement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDossierOuvertSeulement.Location = new System.Drawing.Point(247, 27);
            this.buttonDossierOuvertSeulement.Name = "buttonDossierOuvertSeulement";
            this.buttonDossierOuvertSeulement.Size = new System.Drawing.Size(51, 23);
            this.buttonDossierOuvertSeulement.TabIndex = 2;
            this.buttonDossierOuvertSeulement.Text = "Ouvert";
            this.buttonDossierOuvertSeulement.UseVisualStyleBackColor = true;
            this.buttonDossierOuvertSeulement.Click += new System.EventHandler(this.buttonDossierOuvertSeulement_Click);
            // 
            // buttonDossierBECSeulement
            // 
            this.buttonDossierBECSeulement.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonDossierBECSeulement.Location = new System.Drawing.Point(367, 27);
            this.buttonDossierBECSeulement.Name = "buttonDossierBECSeulement";
            this.buttonDossierBECSeulement.Size = new System.Drawing.Size(40, 23);
            this.buttonDossierBECSeulement.TabIndex = 3;
            this.buttonDossierBECSeulement.Text = "BEC";
            this.buttonDossierBECSeulement.UseVisualStyleBackColor = true;
            this.buttonDossierBECSeulement.Click += new System.EventHandler(this.buttonDossierBECSeulement_Click);
            // 
            // buttonEtiquete
            // 
            this.buttonEtiquete.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonEtiquete.Location = new System.Drawing.Point(304, 27);
            this.buttonEtiquete.Name = "buttonEtiquete";
            this.buttonEtiquete.Size = new System.Drawing.Size(57, 23);
            this.buttonEtiquete.TabIndex = 4;
            this.buttonEtiquete.Text = "Étiqueté";
            this.buttonEtiquete.UseVisualStyleBackColor = true;
            this.buttonEtiquete.Click += new System.EventHandler(this.buttonEtiquete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filtrer pour avoir seulement :";
            // 
            // buttonMesDossier
            // 
            this.buttonMesDossier.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonMesDossier.Location = new System.Drawing.Point(157, 27);
            this.buttonMesDossier.Name = "buttonMesDossier";
            this.buttonMesDossier.Size = new System.Drawing.Size(83, 23);
            this.buttonMesDossier.TabIndex = 6;
            this.buttonMesDossier.Text = "Mes dossiers";
            this.buttonMesDossier.UseVisualStyleBackColor = true;
            this.buttonMesDossier.Click += new System.EventHandler(this.buttonMesDossier_Click);
            // 
            // buttonTousLesDossiers
            // 
            this.buttonTousLesDossiers.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonTousLesDossiers.Location = new System.Drawing.Point(413, 27);
            this.buttonTousLesDossiers.Name = "buttonTousLesDossiers";
            this.buttonTousLesDossiers.Size = new System.Drawing.Size(43, 23);
            this.buttonTousLesDossiers.TabIndex = 7;
            this.buttonTousLesDossiers.Text = "Tous";
            this.buttonTousLesDossiers.UseVisualStyleBackColor = true;
            this.buttonTousLesDossiers.Click += new System.EventHandler(this.buttonTousLesDossiers_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // groupBoxLegendDestination
            // 
            this.groupBoxLegendDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxLegendDestination.Controls.Add(this.labelSD);
            this.groupBoxLegendDestination.Controls.Add(this.labelREV);
            this.groupBoxLegendDestination.Controls.Add(this.labelRED);
            this.groupBoxLegendDestination.Controls.Add(this.labelBEC);
            this.groupBoxLegendDestination.Controls.Add(this.labelATT);
            this.groupBoxLegendDestination.Controls.Add(this.labelARC);
            this.groupBoxLegendDestination.Location = new System.Drawing.Point(15, 552);
            this.groupBoxLegendDestination.Name = "groupBoxLegendDestination";
            this.groupBoxLegendDestination.Size = new System.Drawing.Size(225, 45);
            this.groupBoxLegendDestination.TabIndex = 8;
            this.groupBoxLegendDestination.TabStop = false;
            this.groupBoxLegendDestination.Text = "Destination codes";
            // 
            // labelARC
            // 
            this.labelARC.AutoSize = true;
            this.labelARC.Location = new System.Drawing.Point(7, 20);
            this.labelARC.Name = "labelARC";
            this.labelARC.Size = new System.Drawing.Size(29, 13);
            this.labelARC.TabIndex = 0;
            this.labelARC.Text = "ARC";
            // 
            // labelATT
            // 
            this.labelATT.AutoSize = true;
            this.labelATT.Location = new System.Drawing.Point(42, 20);
            this.labelATT.Name = "labelATT";
            this.labelATT.Size = new System.Drawing.Size(28, 13);
            this.labelATT.TabIndex = 1;
            this.labelATT.Text = "ATT";
            // 
            // labelBEC
            // 
            this.labelBEC.AutoSize = true;
            this.labelBEC.Location = new System.Drawing.Point(76, 20);
            this.labelBEC.Name = "labelBEC";
            this.labelBEC.Size = new System.Drawing.Size(28, 13);
            this.labelBEC.TabIndex = 2;
            this.labelBEC.Text = "BEC";
            // 
            // labelRED
            // 
            this.labelRED.AutoSize = true;
            this.labelRED.Location = new System.Drawing.Point(110, 20);
            this.labelRED.Name = "labelRED";
            this.labelRED.Size = new System.Drawing.Size(30, 13);
            this.labelRED.TabIndex = 3;
            this.labelRED.Text = "RED";
            // 
            // labelREV
            // 
            this.labelREV.AutoSize = true;
            this.labelREV.Location = new System.Drawing.Point(146, 20);
            this.labelREV.Name = "labelREV";
            this.labelREV.Size = new System.Drawing.Size(29, 13);
            this.labelREV.TabIndex = 4;
            this.labelREV.Text = "REV";
            // 
            // labelSD
            // 
            this.labelSD.AutoSize = true;
            this.labelSD.Location = new System.Drawing.Point(181, 20);
            this.labelSD.Name = "labelSD";
            this.labelSD.Size = new System.Drawing.Size(22, 13);
            this.labelSD.TabIndex = 5;
            this.labelSD.Text = "SD";
            // 
            // FormPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 609);
            this.Controls.Add(this.groupBoxLegendDestination);
            this.Controls.Add(this.buttonTousLesDossiers);
            this.Controls.Add(this.buttonMesDossier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEtiquete);
            this.Controls.Add(this.buttonDossierBECSeulement);
            this.Controls.Add(this.buttonDossierOuvertSeulement);
            this.Controls.Add(this.dataGridViewDossier);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipale";
            this.Text = "FormPrincipale";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPrincipale_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDossier)).EndInit();
            this.groupBoxLegendDestination.ResumeLayout(false);
            this.groupBoxLegendDestination.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dossierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewDossier;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatricule;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStatut;
        private System.Windows.Forms.Button buttonDossierOuvertSeulement;
        private System.Windows.Forms.Button buttonDossierBECSeulement;
        private System.Windows.Forms.Button buttonEtiquete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMesDossier;
        private System.Windows.Forms.ToolStripMenuItem modifierMotDePasseToolStripMenuItem;
        private System.Windows.Forms.Button buttonTousLesDossiers;
        private System.Windows.Forms.ToolStripSeparator déconexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxLegendDestination;
        private System.Windows.Forms.Label labelARC;
        private System.Windows.Forms.Label labelRED;
        private System.Windows.Forms.Label labelBEC;
        private System.Windows.Forms.Label labelATT;
        private System.Windows.Forms.Label labelREV;
        private System.Windows.Forms.Label labelSD;
    }
}
namespace GestionEnquetes
{
    partial class DlgHistorique
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
            this.dataGridViewDest = new System.Windows.Forms.DataGridView();
            this.ColDateHeur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCodeDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRemarque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMatricule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDest)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDest
            // 
            this.dataGridViewDest.AllowUserToAddRows = false;
            this.dataGridViewDest.AllowUserToDeleteRows = false;
            this.dataGridViewDest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColDateHeur,
            this.ColCodeDestination,
            this.ColRemarque,
            this.ColNumero,
            this.ColMatricule});
            this.dataGridViewDest.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewDest.Name = "dataGridViewDest";
            this.dataGridViewDest.ReadOnly = true;
            this.dataGridViewDest.Size = new System.Drawing.Size(674, 301);
            this.dataGridViewDest.TabIndex = 0;
            // 
            // ColDateHeur
            // 
            this.ColDateHeur.HeaderText = "Heure de transfer";
            this.ColDateHeur.Name = "ColDateHeur";
            this.ColDateHeur.ReadOnly = true;
            // 
            // ColCodeDestination
            // 
            this.ColCodeDestination.HeaderText = "Code de destination";
            this.ColCodeDestination.Name = "ColCodeDestination";
            this.ColCodeDestination.ReadOnly = true;
            // 
            // ColRemarque
            // 
            this.ColRemarque.HeaderText = "Remarques";
            this.ColRemarque.Name = "ColRemarque";
            this.ColRemarque.ReadOnly = true;
            // 
            // ColNumero
            // 
            this.ColNumero.HeaderText = "No. Dossier";
            this.ColNumero.Name = "ColNumero";
            this.ColNumero.ReadOnly = true;
            // 
            // ColMatricule
            // 
            this.ColMatricule.HeaderText = "Matricule";
            this.ColMatricule.Name = "ColMatricule";
            this.ColMatricule.ReadOnly = true;
            // 
            // DlgHistorique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 326);
            this.Controls.Add(this.dataGridViewDest);
            this.Name = "DlgHistorique";
            this.Text = "DlgHistorique";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDest;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDateHeur;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodeDestination;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRemarque;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMatricule;
    }
}
namespace GestionEnquetes
{
    partial class DlgDestination
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
            this.textBoxRemarque = new System.Windows.Forms.TextBox();
            this.labelRemarque = new System.Windows.Forms.Label();
            this.comboBoxDestination = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMatricule = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxRemarque
            // 
            this.textBoxRemarque.Location = new System.Drawing.Point(13, 28);
            this.textBoxRemarque.Multiline = true;
            this.textBoxRemarque.Name = "textBoxRemarque";
            this.textBoxRemarque.Size = new System.Drawing.Size(404, 184);
            this.textBoxRemarque.TabIndex = 0;
            // 
            // labelRemarque
            // 
            this.labelRemarque.AutoSize = true;
            this.labelRemarque.Location = new System.Drawing.Point(13, 9);
            this.labelRemarque.Name = "labelRemarque";
            this.labelRemarque.Size = new System.Drawing.Size(61, 13);
            this.labelRemarque.TabIndex = 1;
            this.labelRemarque.Text = "Remaques ";
            // 
            // comboBoxDestination
            // 
            this.comboBoxDestination.FormattingEnabled = true;
            this.comboBoxDestination.Location = new System.Drawing.Point(88, 218);
            this.comboBoxDestination.Name = "comboBoxDestination";
            this.comboBoxDestination.Size = new System.Drawing.Size(78, 21);
            this.comboBoxDestination.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Destination : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Matricule : ";
            // 
            // textBoxMatricule
            // 
            this.textBoxMatricule.Location = new System.Drawing.Point(264, 218);
            this.textBoxMatricule.Name = "textBoxMatricule";
            this.textBoxMatricule.Size = new System.Drawing.Size(153, 20);
            this.textBoxMatricule.TabIndex = 5;
            // 
            // DlgDestination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 294);
            this.Controls.Add(this.textBoxMatricule);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxDestination);
            this.Controls.Add(this.labelRemarque);
            this.Controls.Add(this.textBoxRemarque);
            this.Name = "DlgDestination";
            this.Text = "Assignation de destination";
            this.Controls.SetChildIndex(this.textBoxRemarque, 0);
            this.Controls.SetChildIndex(this.labelRemarque, 0);
            this.Controls.SetChildIndex(this.comboBoxDestination, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.textBoxMatricule, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRemarque;
        private System.Windows.Forms.Label labelRemarque;
        private System.Windows.Forms.ComboBox comboBoxDestination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMatricule;
    }
}
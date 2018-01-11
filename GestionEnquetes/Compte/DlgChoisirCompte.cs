using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilStJ;

namespace GestionEnquetes
{
    public partial class DlgChoisirCompte : DialogueOkAnnuler
    {
        /// <summary>
        /// Constructeur du DlgChoisirCompte
        /// </summary>
        public DlgChoisirCompte()
        {
            InitializeComponent();
            InitialiserLesControles();
        }

        /// <summary>
        /// Méthode d'initialisation des controles du Dlg
        /// </summary>
        private void InitialiserLesControles()
        {
            BoutonOK.Enabled = false;
            List<Compte> ComptesDisponibles;
            ComptesDisponibles = RequetesSQL.ListeTousLesComptes().ToList();

            foreach (Compte compte in ComptesDisponibles)
            {
                string texte = String.Concat(compte.Matricule + " " + compte.Nom + " " + compte.Prenom + " " + compte.Grade);
                listBoxTousLesComptes.Items.Add(new PaireIS(compte.Matricule, texte));
            }
        }

        protected override bool ChampsValides()
        {
            if (RequetesSQL.SQLLireCompte(textBoxCompteId.Text) != null)
                return true;
            return false;
        }

        public Compte Extraire() 
            => RequetesSQL.SQLLireCompte(textBoxCompteId.Text == "" ? listBoxTousLesComptes.SelectedItem.GetHashCode().ToString() : textBoxCompteId.Text);
        

        private void listBoxTousLesComptes_SelectedIndexChanged(object sender, EventArgs e)
        {   if (listBoxTousLesComptes.SelectedIndex != -1)
            {
                BoutonOK.Enabled = true;
                textBoxCompteId.Text = listBoxTousLesComptes.SelectedItem.GetHashCode().ToString();
            }
        }

        private void listBoxTousLesComptes_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxTousLesComptes.SelectedIndex != -1)
                ClicSurOK();
        }

        private void textBoxCompteId_TextChanged(object sender, EventArgs e)
        {
            BoutonOK.Enabled = IsDigitsOnly(textBoxCompteId.Text) && RequetesSQL.SQLLireCompte(textBoxCompteId.Text) != null;
        }

        private bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
    }
}

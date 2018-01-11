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
    public partial class DlgAjoutPersonne : DialogueOkAnnuler
    {
        private Personne m_personne;
        private TypeDeSaisie m_typeDeSaisie;
        public DlgAjoutPersonne(TypeDeSaisie p_opération, Personne p_personne)
        {
            InitializeComponent();
            InitialiserComboBoxCode();
            m_personne = p_personne;
            m_typeDeSaisie = p_opération;

            if (m_typeDeSaisie == TypeDeSaisie.Modification)
            {
                RemplirPourModification();
            }
            if(m_typeDeSaisie == TypeDeSaisie.Affichage)
            {
                RemplirPourAffichage();
            }
        }

        private void RemplirPourAffichage()
        {
            RemplirPourModification();
            textBoxNom.Enabled = false;
            textBoxPrenom.Enabled = false;
            dateTimePickerNaissance.Enabled = false;
            textBoxAdresse.Enabled = false;
            comboBoxCode.Enabled = false;
        }

        private void RemplirPourModification()
        {
            textBoxNom.Text = m_personne.Nom;
            textBoxPrenom.Text = m_personne.Prenom;
            dateTimePickerNaissance.Value = m_personne.DateNaissance;
            textBoxAdresse.Text = m_personne.Adresse;
            comboBoxCode.SelectedItem = m_personne.CodePersonne;
        }

        public void InitialiserComboBoxCode()
        {
            comboBoxCode.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (CodePersonne code in Enum.GetValues(typeof(CodePersonne)))
                comboBoxCode.Items.Add(code);

            comboBoxCode.SelectedIndex = 0;
        }

        protected override bool ChampsValides()
        {
            string nom = StringNonVide(textBoxNom, "Nom");
            string prénom = StringNonVide(textBoxPrenom, "Prénom");

            DateTime dateNaissance = dateTimePickerNaissance.Value.Date;

            if (dateNaissance >= DateTime.Today)
            {
                MB.Avertir("La date de naissance est supérieur à la date d'aujourd'hui.");
                return false;
            }

            string adresse = StringNonVide(textBoxAdresse, "Adresse");
            CodePersonne codePersonne = (CodePersonne)comboBoxCode.SelectedItem;
            bool estAjout = m_typeDeSaisie == TypeDeSaisie.Ajout;
            m_personne = new Personne(estAjout ? Document.Instance.NumProchainePersonne() : m_personne.Numero, nom, prénom, dateNaissance, adresse, codePersonne);
            if (estAjout || m_typeDeSaisie == TypeDeSaisie.Modification)
            {
                RequetesSQL.SQLEnregistrerPersonne(m_personne);
            }
            return true;
        }

        /// <summary>
        /// Extrait la personne créer dans le form.
        /// </summary>
        /// <returns></returns>
        public Personne Extraire()
            => m_personne;
    }
}

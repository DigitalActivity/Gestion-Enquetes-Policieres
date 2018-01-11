using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilStJ;

namespace GestionEnquetes
{
    /// <summary>
    /// Classe de dialogue servant à crée, afficher, modifier ou supprimer un rapport d'évènement.
    /// </summary>
    public partial class DlgRapportEvenement : DialogueOkAnnuler
    {
        RapportEvenement m_rapportEvenement; // Rapport d'évènement en cours de création / affichage / modification / suppression

        /// <summary>
        /// Constructeur du dialogue de rapport d'évènement.
        /// </summary>
        /// <param name="p_typeDeSaisie">Ajout, Affichage, Modification ou Suppression.</param>
        /// <param name="p_rapportEvenement">Rapport à modifier, afficher ou supprimer</param>
        public DlgRapportEvenement(TypeDeSaisie p_typeDeSaisie = TypeDeSaisie.Ajout, RapportEvenement p_rapportEvenement = null)
        {
            TypeDeSaisie = p_typeDeSaisie;
            InitializeComponent();
            textBoxRemarques.AcceptsReturn = true;
            m_rapportEvenement = p_rapportEvenement;
            Province.AjouterChoixDeProvince(comboBoxProvince);
            AjouterChoixDeCodeDeNature();
            InitialiserDatePicker();
            m_rapportEvenement = p_rapportEvenement;
            RemplirLesControles();

            if (TypeDeSaisie == TypeDeSaisie.Affichage || TypeDeSaisie == TypeDeSaisie.Suppression)
                DesactiverTousLesChamps();
        }

        /// <summary>
        /// Change les textes des boutons selon le mode de saisie.
        /// Si un rapport existe déjà, ses informations sont chargées dans les champs de saisie.
        /// </summary>
        private void RemplirLesControles()
        {
            switch (TypeDeSaisie)
            {
                case TypeDeSaisie.Affichage:
                    BoutonOK.Visible = false;
                    BoutonAnnuler.Text = "Fermer"; break;
                case TypeDeSaisie.Ajout:
                    BoutonOK.Text = "Ajouter";
                    textBoxPays.Text = "Canada"; break;
                case TypeDeSaisie.Modification:
                    BoutonOK.Text = "Modifier"; break;
                case TypeDeSaisie.Suppression:
                    BoutonOK.Text = "Supprimer"; break;
            }

            if (m_rapportEvenement != null)
            {
                comboBoxCodeDeNature.SelectedIndex = CodeDeNature.TousLesCodesDeNature.IndexOf(m_rapportEvenement.CodeDeNature);
                dateTimePicker.Value = m_rapportEvenement.DateEtHeure;
                textBoxNoCivique.Text = m_rapportEvenement.Adresse.NoCivique;
                textBoxRue.Text = m_rapportEvenement.Adresse.Rue;
                textBoxCodePostal.Text = m_rapportEvenement.Adresse.Zip;
                textBoxVille.Text = m_rapportEvenement.Adresse.Ville;
                comboBoxProvince.Text = m_rapportEvenement.Adresse.Etat;
                textBoxPays.Text = m_rapportEvenement.Adresse.Pays;
                textBoxRemarques.Text = m_rapportEvenement.Remarques;
            }
        }

        /// <summary>
        /// Ajoute les choix de codes de nature dans le dropdown dun code de nature du rapport.
        /// </summary>
        private void AjouterChoixDeCodeDeNature()
        {
            comboBoxCodeDeNature.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (CodeDeNature codeDeNature in CodeDeNature.TousLesCodesDeNature)
                comboBoxCodeDeNature.Items.Add(codeDeNature);

            comboBoxCodeDeNature.SelectedIndex = 0;
        }

        /// <summary>
        /// Initialise le DatePicker à la date actuelle.
        /// </summary>
        private void InitialiserDatePicker()
        {
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "d MMMM yyyy H:mm";
            dateTimePicker.Value = DateTime.Now;
        }

        /// <summary>
        /// Désactive tous les champs de saisie, pour interdire les modifications.
        /// </summary>
        private void DesactiverTousLesChamps()
        {
            comboBoxCodeDeNature.Enabled = false;
            dateTimePicker.Enabled = false;
            textBoxNoCivique.Enabled = false;
            textBoxRue.Enabled = false;
            textBoxCodePostal.Enabled = false;
            textBoxVille.Enabled = false;
            comboBoxProvince.Enabled = false;
            textBoxPays.Enabled = false;
            textBoxRemarques.Enabled = false;
        }

        /// <summary>
        /// Vérifie la validité des informations entrées dans les champs de saisie.
        /// </summary>
        /// <returns>true si les informations sont valides, false sinon.</returns>
        protected override bool ChampsValides()
        {
            if (!CodeDeNature.TousLesCodesDeNature.Contains((CodeDeNature)comboBoxCodeDeNature.SelectedItem))
            {
                MB.Avertir("Le code de nature sélectionné n'existe pas.");
                return false;
            }

            if (dateTimePicker.Value > DateTime.Now)
            {
                MB.Avertir("La date et heure doit être inférieur à la date et heure actuelle.");
                return false;
            }

            try
            {
                DateTime dateEtHeure = dateTimePicker.Value;
                CodeDeNature codeDeNature = (CodeDeNature)comboBoxCodeDeNature.SelectedItem;
                string noCivique = StringNonVide(textBoxNoCivique, "numéro civique");
                string rue = StringNonVide(textBoxRue, "rue");
                string codePostal = StringNonVide(textBoxCodePostal, "code postal").Trim().ToUpper();
                Regex regexCodePostal = new Regex("^[A-Z][0-9][A-Z][ ]?[0-9][A-Z][0-9]$");

                if (!regexCodePostal.IsMatch(codePostal))
                {
                    MB.Avertir("Le code postal doit avoir le format suivant « A1A1A1 » ou « A1A 1A1 ».");
                    return false;
                }

                string ville = StringNonVide(textBoxVille, "ville");
                string province = StringNonVide(comboBoxProvince, "province");
                string pays = StringNonVide(textBoxPays, "pays");
                Adresse adresse = new Adresse(rue, ville, province, codePostal, pays, noCivique);
                string remarques = textBoxRemarques.Text.Trim();    // peut être vide
                m_rapportEvenement = new RapportEvenement(codeDeNature, dateEtHeure, adresse, remarques);

                return true;
            }
            catch (ErreurExtraction)
            {
                // L'utilisateur n'a pas bien rempli le formulaire.
                return false;
            }
        }

        /// <summary>
        /// Extrait le rapport en cours.
        /// </summary>
        /// <returns>Le rapport travaillé dans le dialogue.</returns>
        public RapportEvenement Extraire() => m_rapportEvenement;
    }
}
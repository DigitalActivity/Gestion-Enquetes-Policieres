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
    /// <summary>
    /// Classe de dialogue de création, affichage, modification et suppression d'un rapport d'enquête.
    /// </summary>
    public partial class DlgRapportEnquete : UtilStJ.DialogueOkAnnuler
    {
        RapportEnquete m_rapportEnquete; // Rapport en cours de création, affichage, modification ou suppression.
        TypeDeSaisie m_typeSaisie; // Type de saisie de la boîte de dialogue.

        /// <summary>
        /// Constructeur du dialogue de rapport d'enquête.
        /// </summary>
        /// <param name="p_typeSaisie">Ajout, Affichage, Modification ou Suppression.</param>
        /// <param name="p_rapportEnquete">Rapport à afficher, supprimer ou modifier.</param>
        public DlgRapportEnquete(TypeDeSaisie p_typeSaisie = TypeDeSaisie.Ajout, RapportEnquete p_rapportEnquete = null)
        {
            InitializeComponent();
            m_typeSaisie = p_typeSaisie;
            m_rapportEnquete = p_rapportEnquete;
            RemplirLesControles();
            labelMatricule.Text = LoggedUser.compte.Matricule.ToString();
        }

        /// <summary>
        /// Change les textes des boutons selon le mode de saisie.
        /// Si un rapport existe déjà, ses informations sont chargées dans les champs de saisie.
        /// </summary>
        private void RemplirLesControles()
        {
            switch (m_typeSaisie)
            {
                case TypeDeSaisie.Affichage:
                    BoutonOK.Visible = false;
                    BoutonAnnuler.Text = "Fermer";
                    labelAuteur.Text = "Écrit par :";
                    Text = "Affichage - Rapport d'Enquête";
                    labelMdP.Visible = false;
                    textBoxPassword.Visible = false;
                    TextBoxRemarques.Enabled = false;
                    break;
                case TypeDeSaisie.Ajout:
                    BoutonOK.Text = "Ajouter";
                    break;
                case TypeDeSaisie.Modification:
                    BoutonOK.Text = "Modifier";
                    Text = "Modification - Rapport d'Enquête";
                    break;
                case TypeDeSaisie.Suppression:
                    BoutonOK.Text = "Supprimer";
                    Text = "Suppression - Rapport d'Enquête";
                    TextBoxRemarques.Enabled = false;
                    break;
            }

            if (m_rapportEnquete != null)
            {
                TextBoxRemarques.Text = m_rapportEnquete.Contenu;
                labelMatricule.Text = m_rapportEnquete.Matricule.Matricule.ToString();
            }
        }

        /// <summary>
        /// Vérifie la validité des informations entrées dans les champs de saisie.
        /// </summary>
        /// <returns>true si les informations sont valides, false sinon.</returns>
        protected override bool ChampsValides()
        {
            string passHashed = Hashage.Encrypter(textBoxPassword.Text, null, HashType.Sha256);
            labelErreur.Visible = false;

            if (TextBoxRemarques.Text == "")
            {
                labelErreur.Text = "Erreur - Le champ de remarques de peut être vide.";
                labelErreur.Visible = true;
                return false;
            }

            if (LoggedUser.compte == null)
            {
                labelErreur.Text = "Erreur - Vous devez être connecté pour effectuer cette action.";
                labelErreur.Visible = true;
                return false;
            }

            if (LoggedUser.compte.Grade != Grade.Détective)
            {
                labelErreur.Text = "Erreur - Seul un détective peut effectuer cette action.";
                labelErreur.Visible = true;
                return false;
            }
            if (!Hashage.HashValide(textBoxPassword.Text, LoggedUser.compte.HashPass, HashType.Sha256))
            {
                labelErreur.Text = "Erreur - Le mot de passe saisi ne correspond pas au matricule.";
                labelErreur.Visible = true;
                return false;
            }
            m_rapportEnquete = new RapportEnquete(TextBoxRemarques.Text, LoggedUser.compte);


            if (m_typeSaisie == TypeDeSaisie.Suppression)
                return MB.ConfirmerOuiNon("Voulez-vous vraiment supprimer définitivement ce rapport d'enquête?");
            else if (m_typeSaisie == TypeDeSaisie.Modification)
                return MB.ConfirmerOuiNon("Voulez-vous vraiment rendre ces modifications permanentes?");
            else return true;
        }


        /// <summary>
        /// Extrait le rapport en cours.
        /// </summary>
        /// <returns>Le rapport travaillé dans le dialogue.</returns>
        public RapportEnquete Extraire() => m_rapportEnquete;

    }
}

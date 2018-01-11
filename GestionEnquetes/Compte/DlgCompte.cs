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

/**
 * Les champs du dialogue compte
    groupBoxAjouterCompte;  // tous les champs du formulaire
    groupBoxInfoLogin;      // Les champs du login
    textBoxPassword;
    textBoxPassword2;
    checkBoxResetPassword;
    comboBoxGrade;
    textBoxMatricule;
    textBoxNom;
    textBoxPrenom;
    dateTimePickerNaissance;
    textBoxEmail;          
    textBoxTelephone;            
    textBoxEtat;
    textBoxVille;
    textBoxAdresse;
    textBoxCodePostal;
 */

namespace GestionEnquetes
{
    public partial class DlgCompte : DialogueOkAnnuler
    {
        const int AGE_MIN_COMPTE = 12; // Pour eviter (ex naissance : 2015)
        const int AGE_MAX_COMPTE = 130; // Pour eviter (ex naissance : 1880)
        protected Compte compte { get; set; }
        private TypeDeSaisie typeSaisie;
        public Compte Extraire()
            => compte;

        /// <summary>
        /// Ce constructeur est pour l'éditeur visuel seulement, 
        ///  il ne devrait pas être utilisé autrement.
        /// </summary>
        public DlgCompte()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructeur DlgCompte
        /// </summary>
        /// <param name="p_typeSaisie">type d'operation</param>
        /// <param name="p_grade">grade de l'utilisateur</param>
        /// /// <param name="p_compte">Compte à traiter (normalement null pour les ajouts)</param>
        public DlgCompte(TypeDeSaisie p_typeSaisie, Grade p_grade, Compte p_compte = null)
        {
            InitializeComponent();
            if (p_compte == null && (p_typeSaisie == TypeDeSaisie.Modification ||
                p_typeSaisie == TypeDeSaisie.Affichage))
                return;

            compte = p_compte;
            typeSaisie = p_typeSaisie;
            

            // Remplir comboBoxGrade avec les grades possibles
            foreach (Grade grade in Enum.GetValues(typeof(Grade)))
                comboBoxGrade.Items.Add(grade.ToString());

            if (compte != null)
                InitialiserLesChamps();
            else
                textBoxMatricule.Text = Document.Instance.NumProchainCompteSansAugmenter().ToString();

            if (p_typeSaisie != TypeDeSaisie.Ajout && p_typeSaisie != TypeDeSaisie.Modification)
                ActiverLectureSeule(groupBoxSaisieCompte.Controls);

            // Activer les champs mot de passe au besoin pour la modification
            checkBoxEnableEditPass.Visible = p_typeSaisie == TypeDeSaisie.Modification;
            checkBoxEnableEditPass.Enabled = true;
            groupBoxInfoLogin.Enabled = checkBoxEnableEditPass.Checked || p_typeSaisie == TypeDeSaisie.Ajout;
        }

        private void InitialiserLesChamps()
        {
            // Grade du compte traité
            comboBoxGrade.SelectedIndex = (int)compte.Grade;
            // Info Contact
            textBoxTelephone.Text = compte.Telephone;
            textBoxEmail.Text = compte.Email;
            // Info personnels
            textBoxMatricule.Text = compte.Matricule.ToString();
            textBoxNom.Text = compte.Nom;
            textBoxPrenom.Text = compte.Prenom;
            dateTimePickerNaissance.Value = compte.Naissance;
            // Info Adresse
            textBoxAdresse.Text = compte.Adrss.Rue;
            textBoxVille.Text = compte.Adrss.Ville;
            textBoxEtat.Text = compte.Adrss.Etat;
            textBoxCodePostal.Text = compte.Adrss.Zip;
        }

        protected override bool ChampsValides()
        {
            // Valider les champs
            string nom = StringNonVide(textBoxNom, "Nom");
            string prenom = StringNonVide(textBoxPrenom, "Prénom");
            DateTime naissance = dateTimePickerNaissance.Value;
            if (naissance.Year < DateTime.Today.Year - AGE_MAX_COMPTE ||
                naissance.Year > DateTime.Today.Year - AGE_MIN_COMPTE)
            {
                MB.Avertir("L\'age de l\'utilisateur est invalide.");
                ActiveControl = dateTimePickerNaissance;
                return false;
            }
            // Adresse
            string rue = StringNonVide(textBoxAdresse, "Adresse");
            string ville = StringNonVide(textBoxVille, "Ville");
            string etat = StringNonVide(textBoxEtat, "Etat");
            string codePostal = StringNonVide(textBoxCodePostal, "Zip");
            Adresse adresse = new Adresse(rue, ville, etat, codePostal);
            // Contact
            string tel = StringNonVide(textBoxTelephone, "Telephone");
            if (!Utilitaires.IsValidePhone(textBoxTelephone.Text))
            {
                MB.Avertir("Telephone invalide.");
                return false;
            }
            string email = StringNonVide(textBoxEmail, "Email");
            if (!Utilitaires.IsValidEmail(textBoxEmail.Text))
            {
                MB.Avertir("Email invalide.");
                return false;
            }
            // Grade, matricule
            Grade grade;
            if (Enum.IsDefined(typeof(Grade), comboBoxGrade.SelectedIndex))
            {
                grade = (Grade)comboBoxGrade.SelectedIndex;
            }
            else
            {
                MB.Avertir("Le Grade assigné est invalide.");
                ActiveControl = comboBoxGrade;
                return false;
            }
            int matricule = Int32AvecMinimum(textBoxMatricule,1, "Matricule");
            // Password
            string mdpHash;
            if (checkBoxEnableEditPass.Checked || typeSaisie == TypeDeSaisie.Ajout)
            {
                StringNonVide(textBoxPassword, "mot de passe");
                if (!textBoxPassword.Text.Equals(textBoxPassword2.Text))
                {
                    MB.Avertir("Les champs mot de passe ne correspondent pas");
                    return false;
                }
                mdpHash = Hashage.Encrypter(textBoxPassword.Text);
            }
            else
            {
                mdpHash = compte.HashPass; // ne pas changer le mot de passe, si le champs n'est pas modifé
            }
            // Finir la validation
            return FinirValidation(prenom, nom, matricule, naissance,
                                    adresse, tel, email,
                                    grade, mdpHash);
        }

        /// <summary>
        /// Set Read Only
        /// </summary>
        private void ActiverLectureSeule(Control.ControlCollection controlCollection)
        {
            if (controlCollection == null)
                return;
            foreach (DateTimePicker r in controlCollection.OfType<DateTimePicker>())
                r.Enabled = false;
            foreach (RadioButton r in controlCollection.OfType<RadioButton>())
                r.Enabled = false;
            foreach (ComboBox c in controlCollection.OfType<ComboBox>())
                c.Enabled = false;
            foreach (TextBoxBase c in controlCollection.OfType<TextBoxBase>())
                c.ReadOnly = true;
        }

        /// <summary>
        /// Activer ou Desactier la modification du mot de passe
        /// </summary>
        private void checkBoxEnableEditPass_CheckedChanged(object sender, EventArgs e)
            => groupBoxInfoLogin.Enabled = checkBoxEnableEditPass.Checked;

        // Pour Template Method ChampsValides, Doit être définie dans la classe dérivée
        public virtual bool FinirValidation(string p_prenom, string p_nom, int p_matricule, DateTime p_naissance,
                                            Adresse p_adresse, string p_tel, string p_email,
                                            Grade p_grade, string p_mdpHash)
        {
            throw new NotImplementedException(); // Doit être définie dans la classe dérivée (devait être
        }                                        //  abstraite mais on ne peut pas pour l'éditeur visuel)
    }
}

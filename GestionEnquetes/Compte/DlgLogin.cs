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
    public enum TypeOperation { Login, Reset }

    public partial class DlgLogin : DialogueOkAnnuler
    {
        private TypeOperation operation = TypeOperation.Login;

        protected DlgLogin()
        {
            InitializeComponent();
        }

        public DlgLogin(TypeOperation p_operation = TypeOperation.Login)
        {
            InitializeComponent();
            operation = p_operation;
            InitialiserLesChamps();
        }

        private void InitialiserLesChamps()
        {
            if (operation == TypeOperation.Reset)
            {
                groupBoxLogin.Text = "Reinitialiser le mot de passe";
                textBoxPassword.PasswordChar = '\0';
                linkLabelPassOublier.Visible = false;
                labelPassword.Text = "Email"; // au lieu de contenir un password, va contenir email
            }
        }

        protected override bool ChampsValides()
        {
            if (operation == TypeOperation.Login)
                return ValidationLogin();
            else
                return ValidationReset();
        }

        private bool ValidationLogin()
        {
            string user = StringNonVide(textBoxlogin, "Utilisateur");
            string passHashed = StringNonVide(textBoxPassword, "Mot de passe");
            Compte c = RequetesSQL.SQLLogin(user, textBoxPassword.Text);
            if (c == null)
            {
                MB.Avertir("Authentification rejetée");
                return false;
            }
            if (!Hashage.HashValide(textBoxPassword.Text, c.HashPass, HashType.Sha256))
            {
                MB.Avertir("Authentification rejetée");
                return false;
            }
            return LoggedUser.OuvrirSession(c.Matricule.ToString());
        }

        /// <summary>
        /// Reinitiliser un mot de passe oublié
        /// </summary>
        /// <returns>vrai si le changement à reusit</returns>
        /// 
        private bool ValidationReset()
        {
            string user = StringNonVide(textBoxlogin, "Login");
            string email = StringNonVide(textBoxPassword, "Email");
            string passeProvisoirhash;
            Compte c;
            int matricule = -1;
            // DONE: Verifier si user et email sont presents dans la bd
            matricule = RequetesSQL.ChercherCompteSelonEmail(email);
            c = RequetesSQL.SQLChercherCompteAvecMatricule(matricule);
            if (matricule != -1)
                if (c == null)
                    return false;

            // Envoyer un email avec un  mot de passe provisoire
            bool envoie = Utilitaires.sendResetMessage(textBoxPassword.Text, out passeProvisoirhash);
            if (envoie)
            {
                // DONE: ModifierLe hashDans la bd pour ce compte
                c.ModifierPasse(passeProvisoirhash);
                RequetesSQL.SupprimerCompte(c.Matricule.ToString());
                RequetesSQL.AjouterCompte(c);
                MB.Avertir("un message vous est envoyé !");
            }
            else MB.Avertir("Un problème est survenu");

            return envoie;
        }

        protected virtual bool FinirValidation()
        {
            return true;
        }

        private void linkLabelPassOublier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            => new DlgLogin(TypeOperation.Reset).ShowDialog();
    }
}

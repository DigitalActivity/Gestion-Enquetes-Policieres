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
    public partial class DlgResetPass : DialogueOkAnnuler
    {
        public DlgResetPass()
        {
            InitializeComponent();
        }

        protected override bool ChampsValides()
        {
            StringNonVide(textBoxPassword, "mot de passe actuel");

            if (!Hashage.HashValide(textBoxPassword.Text, LoggedUser.compte.HashPass, HashType.Sha256))
            {
                MB.Avertir("Mot de passe actuel est invalide");
                return false;
            }

            if (!textBoxNewPassword.Text.Equals(textBoxNewPassword2.Text))
            {
                MB.Avertir("Les champs nouveau mot de passe ne correspondent pas");
                return false;
            }
            string mdpHash = Hashage.Encrypter(textBoxNewPassword.Text);
            LoggedUser.compte.ModifierPasse(mdpHash);
            return RequetesSQL.UpdateCompte(LoggedUser.compte);
        }
    }
}

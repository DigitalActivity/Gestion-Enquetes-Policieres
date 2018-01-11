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

    public partial class DlgSaisieCompte : DlgCompte
    {
        TypeDeSaisie m_typeSaisie;
        Compte m_compte;
        /// <summary>
        /// Ce constructeur est pour l'éditeur visuel seulement, il ne devrait pas être utilisé autrement.
        /// </summary>
        protected DlgSaisieCompte()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructeur pour le dialogue Saisie Compte
        /// </summary>
        /// <param name="p_typeSaisie">type d'operation</param>
        /// <param name="p_grade">grade de l'utilisateur</param>
        public DlgSaisieCompte(TypeDeSaisie p_typeSaisie, Grade p_grade, Compte p_compte = null)
            : base(p_typeSaisie, p_grade, p_compte)
        {
            InitializeComponent();

            m_typeSaisie = p_typeSaisie;
            m_compte = p_compte;
            if (p_compte == null && (p_typeSaisie == TypeDeSaisie.Modification ||
                   p_typeSaisie == TypeDeSaisie.Affichage))
                this.Close();

            if (p_grade != Grade.Capitaine && (p_typeSaisie == TypeDeSaisie.Modification ||
                p_typeSaisie == TypeDeSaisie.Ajout))
            {
                MB.Avertir("Vous n\'etes pas autorisés à acceder à cette section");
                this.Close();
            }

            switch (p_typeSaisie)
            {
                case TypeDeSaisie.Ajout: Text = "Ajout d\'un nouveau compte utilisateur"; break;
                case TypeDeSaisie.Modification: Text = "Modification d\'un compte utilisateur"; break;
                case TypeDeSaisie.Affichage: Text = "Information sur le compte #" + p_compte.Matricule; break;
            }
        }

        /// <summary>
        /// Finir la validations des champs. Tous les champs de base sont validées dans BglCompte
        /// </summary>
        /// <returns>Vrai quand tous les champs sont valides</returns>
        public override bool FinirValidation(string p_prenom, string p_nom, int p_matricule, DateTime p_naissance,
                                            Adresse p_adresse, string p_tel, string p_email,
                                            Grade p_grade, string p_mdpHash)
        {
            compte = new Compte(p_prenom, p_nom, (m_typeSaisie == TypeDeSaisie.Affichage || m_typeSaisie == TypeDeSaisie.Modification) ? m_compte.Matricule : Document.Instance.NumProchainCompte(), p_naissance, p_adresse, p_tel, p_email,
                                p_grade, p_mdpHash);
            return true;
        }
    }
}

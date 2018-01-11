using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace GestionEnquetes
{
    /// <summary>
    /// Compte utilisateur, contient informations personnelles, matricule, login et mot de passe
    /// </summary>
    [Serializable]
    public class Compte
    {
        /// <summary>
        /// Constructeur Compte
        /// </summary>
        public Compte(string p_prenom, string p_nom, int p_matricule,
                      DateTime p_naissance, Adresse p_adresse,
                      string p_telephone, string p_email,
                      Grade p_grade, string p_hashpass64)
        {
            Nom = p_nom;
            Prenom = p_prenom;
            Matricule = p_matricule;
            Grade = p_grade;
            Naissance = p_naissance;
            Adrss = p_adresse;
            Telephone = p_telephone;
            Email = p_email;
            HashPass = p_hashpass64;
            noDossierImportants = new List<string>();
        }

        public int Matricule { get; }       //Matricule du compte. Identifiant primaire dans la BD
        public Grade Grade { get; }         //Grade du compte
        public string Nom { get; }          //Nom de la personne titulaire
        public string Prenom { get; }       //Prénom de la personne titulaire
        public DateTime Naissance { get; }  //Date de naissance du titulaire
        public Adresse Adrss { get; }       //Adresse du titulaire
        public string Telephone { get; }    //Telephone du titulaire
        public string Email { get; }        //Adresse courriel du titulaire
        public List<string> noDossierImportants { get; } //Liste des dossiers concidérer important pour l'utilisateur.
        public string HashPass { get; private set; }     //Hash du mot de passe de l'utilisateur.

        /// <summary>
        /// Setter du mot de passe du compte
        /// </summary>
        /// <param name="p_hashPass">nouveau mot de passe</param>
        public void ModifierPasse(string p_hashPass)
            => HashPass = p_hashPass;
    }

    // struct Adresse
    public struct Adresse
    {
        /// <summary>
        /// Constructeur de l'adresse
        /// </summary>
        public Adresse(string p_rue, string p_ville, string p_etat,
                       string p_zip, string p_pays = "Canada", string p_noCivique = "")
        {
            Rue = p_rue;
            Ville = p_ville;
            Etat = p_etat;
            Zip = p_zip;
            Pays = p_pays;
            NoCivique = p_noCivique;
        }

        public string NoCivique; //Numéro de la maison
        public string Rue;       //Le rue de l'adresse
        public string Ville;     //Ville de l'adresse
        public string Etat;      //État ou province de l'adresse
        public string Zip;       //Code zip ou code Postal
        public string Pays;      //Pays de l'adresse
    }



}

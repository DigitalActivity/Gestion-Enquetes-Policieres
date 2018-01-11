using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEnquetes
{
    //TODO: améliorer les enum, donner définition etc.
    public enum CodePersonne { AVU, CIT, CTV, DEM, DET, DIS, ENT, EVA, MDT, PLA, PLV, PRE, PVH, SUS, TEM, VIC }

    public class Personne
    {
        public int Numero { get; private set; }
        public string Nom { get; private set; }
        public string Prenom { get; private set; }
        public DateTime DateNaissance { get; private set; }
        public string Adresse { get; private set; }
        public CodePersonne CodePersonne { get; private set; }

        public Personne(int p_numero, string p_nom, string p_prenom,
            DateTime p_dateNaissance, string p_adresse, CodePersonne p_codePersonne)
        {
            Numero = p_numero; // Ajout du numéro avec la bd?
            Nom = p_nom;
            Prenom = p_prenom;
            DateNaissance = p_dateNaissance;
            Adresse = p_adresse;
            CodePersonne = p_codePersonne;
        }

        public string getNomComplet()
        {
            return Prenom + " " + Nom;
        }
    }
}

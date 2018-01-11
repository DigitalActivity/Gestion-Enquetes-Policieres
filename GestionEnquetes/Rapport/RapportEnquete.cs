using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEnquetes
{
    /// <summary>
    /// Classe d'un rapport d'enquête.
    /// </summary>
    public class RapportEnquete
    {
        /// <summary>
        /// Constructeur du rapport d'enquête.
        /// </summary>
        /// <param name="p_contenu">Texte écrit par le policier.</param>
        /// <param name="p_matricule">Matricule du détective qui a écrit le rapport.</param>
        public RapportEnquete(string p_contenu, Compte p_matricule)
        {
            Matricule = p_matricule;
            Contenu = p_contenu;
        }


        /// <summary>
        /// Matricule du détective qui a écrit le rapport.
        /// </summary>
        public Compte Matricule { get; set; }

        /// <summary>
        /// Texte écrit par le policier.
        /// </summary>
        public string Contenu { get; set; }
    }
}

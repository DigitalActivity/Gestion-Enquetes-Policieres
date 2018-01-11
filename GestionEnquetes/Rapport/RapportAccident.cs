using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEnquetes
{
    /// <summary>
    /// Classe d'un  rapport d'accident.
    /// </summary>
    public class RapportAccident
    {
        /// <summary>
        /// Constructeur d'un rapport d'accident.
        /// </summary>
        /// <param name="p_numero">Numéro du dossier lié.</param>
        /// <param name="p_vehiculesImpliques">Liste des véhicules impliqués.</param>
        /// <param name="p_adresse">Adresse de l'accident.</param>
        /// <param name="p_dateEtHeure">Date et heure de l'accident</param>
        /// <param name="p_remarques">Remarques du policier sur les lieux.</param>
        public RapportAccident(int p_numero, List<Vehicule> p_vehiculesImpliques, Adresse p_adresse, DateTime p_dateEtHeure, string p_remarques)
        {
            NoRapport = p_numero;
            VehiculesImpliques = p_vehiculesImpliques;
            Adresse = p_adresse;
            DateEtHeure = p_dateEtHeure;
            Remarques = p_remarques;
        }

        /// <summary>
        /// Numéro du rapport.
        /// </summary>
        public int NoRapport { get; private set; }

        /// <summary>
        /// Liste des véhicules impliqués. Peut être null.
        /// </summary>
        public List<Vehicule> VehiculesImpliques { get; private set; } = new List<Vehicule>();

        /// <summary>
        /// Adresse de l'accident.
        /// </summary>
        public Adresse Adresse { get; private set; }

        /// <summary>
        /// Date et heure de l'accident.
        /// </summary>
        public DateTime DateEtHeure { get; private set; }

        /// <summary>
        /// Remarques du policier sur les lieux.
        /// </summary>
        public string Remarques { get; private set; }
    }
}
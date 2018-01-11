using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilStJ;

namespace GestionEnquetes
{
    // Grades des Utilisateurs
    [Serializable]
    public enum Grade { Patrouilleur = 0, Lieutenant = 1, Détective = 2, Capitaine = 3}

    public class Document
    {
        public const string PREFIXE_POSTE = "STJ";
        private const string NomFichierDonnees = "../../GestionEnquetesPolicieres.accdb";
        private string strAccessConn = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + NomFichierDonnees;
        private static Document m_docUnique = new Document();
        public static Document Instance => m_docUnique;

        bool m_docModifié = false;
        public int NumProchainCompte()
            => RequetesSQL.SQLLireNumeroCompte();

        public int NumProchainVehicule()
            => RequetesSQL.SQLLireNumeroVehicule();

        public int NumProchainePersonne()
            => RequetesSQL.SQLLireNumeroPersonne();

        public int NumProchainDossier()
            => RequetesSQL.SQLLireNumeroDossier();

        public int NumProchainCompteSansAugmenter()
            => RequetesSQL.numeroCompteSansIncrementer();

        public int NumProchainRapport()
            => RequetesSQL.SQLLireNumeroRapport();

        private Document()
        {
            try
            {
                RequetesSQL.Connecterbd(strAccessConn);
            }
            catch
            {
                MB.AvertirCritique("La lecture de « {0} » a échoué.\n" +
                                "Le programme va s'arrêter.\n",
                                NomFichierDonnees);

                Environment.Exit(0);  // Permet d'arrêter le programme directement.
            }
        }

        /// <summary>
        /// Termine l'accès aux données et s'assure qu'elles sont bien enregistrées (un message est affichée
        /// si ce n'est pas le cas).
        /// </summary>
        public void Fermer()
        {
            RequetesSQL.FermerBD(); // Deconnecter a la base de données}
        }
    }
}

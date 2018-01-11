using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilStJ;

namespace GestionEnquetes
{
    /// <summary>
    /// Utilisateur actuellement connecté
    /// </summary>
    public static class LoggedUser
    {
        public static Compte compte { get; private set; }
        public static bool OuvrirSession(string p_matricule)
        {
            try
            {
                compte = RequetesSQL.SQLLireCompte(p_matricule);
                return true;
            }
            catch
            {

                return false;
            }
        }

        public static void FermerSession()
            => compte = null;


    }
}

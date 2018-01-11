using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilStJ;

namespace GestionEnquetes
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Document conn = Document.Instance;
            // Authentification
            Connexion();
        }

        /// <summary>
        /// Connecter la base des données
        /// </summary>
        public static void Connexion()
        {
            DlgLogin d = new DlgLogin(TypeOperation.Login);
            d.ShowDialog();

            if (d.DialogResult == DialogResult.OK)
            {
                // Ouvrir form principal
                Application.Run(new FormPrincipale());
            }
        }
    }
}

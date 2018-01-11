using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEnquetes
{
    /// <summary>
    /// Classe d'un code de nature.
    /// </summary>
    public class CodeDeNature
    {
        /// <summary>
        /// Constructeur d'un code de nature.
        /// </summary>
        /// <param name="p_code">Indice du code de nature.</param>
        /// <param name="p_description">Description du code de nature.</param>
        public CodeDeNature(int p_code, string p_description)
        {
            Code = p_code;
            Description = p_description;
        }

        /// <summary>
        /// Constructeur d'un code de nature.
        /// </summary>
        /// <param name="p_code">Indice du code de nature.</param>
        public CodeDeNature(int p_code)
        {
            Code = p_code;
            Description = (CodeDeNature.TousLesCodesDeNature[p_code - 1].Description);
        }

        /// <summary>
        /// Indice du code de nature.
        /// </summary>
        public int Code { get; private set; }

        /// <summary>
        /// Description du code de nature.
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// Liste des codes de nature prédéterminés et utilisés par le client.
        /// </summary>
        public static readonly List<CodeDeNature> TousLesCodesDeNature = new List<CodeDeNature>
        {
            new CodeDeNature(01, "Crime contre la personne"),
            new CodeDeNature(02, "Crime contre la propriété"),
            new CodeDeNature(03, "Code criminel"),
            new CodeDeNature(04, "Lois sur les stupéfiants"),
            new CodeDeNature(05, "Aliments et drogues"),
            new CodeDeNature(06, "Autres lois fédérales"),
            new CodeDeNature(07, "Autre lois provinciales"),
            new CodeDeNature(08, "Règlements municipaux"),
            new CodeDeNature(09, "Circulations"),
            new CodeDeNature(10, "Alarmes"),
            new CodeDeNature(11, "Enquêtes"),
            new CodeDeNature(12, "Autre catégories")
        };

        /// <summary>
        /// Retourne le code de nature correspondant à l'indice donné.
        /// </summary>
        /// <param name="p_numero"></param>
        /// <returns>Code de nature correspondant à l'indice donné.</returns>
        public static CodeDeNature getCodeNature(int p_numero)
        {
            return TousLesCodesDeNature.Find(n => n.Code == p_numero);
        }

        /// <summary>
        /// Override de la méthode ToString() retournant la description du code de nature.
        /// </summary>
        /// <returns>Description du code d'évènement spécifié.</returns>
        public override string ToString() => $"{Code.ToString("D2")} {Description}";
    }

    /// <summary>
    /// Classe d'un rapport d'évènement.
    /// </summary>
    public class RapportEvenement
    {
        /// <summary>
        /// Constructeur d'un rapport d'évènement.
        /// </summary>
        /// <param name="p_codeDeNature">Code de nature du rapport.</param>
        /// <param name="p_dateEtHeure">Date et heure de l'évènement.</param>
        /// <param name="p_adresse">Adresse de l'évènement.</param>
        /// <param name="p_remarques">Remarques du policier répondant.</param>
        public RapportEvenement(CodeDeNature p_codeDeNature, DateTime p_dateEtHeure, Adresse p_adresse, string p_remarques)
        {
            CodeDeNature = p_codeDeNature;
            DateEtHeure = p_dateEtHeure;
            Adresse = p_adresse;
            Remarques = p_remarques;
        }

        /// <summary>
        /// Code de nature du rapport.</param>
        /// </summary>
        public CodeDeNature CodeDeNature { get; private set; }

        /// <summary>
        /// Date et heure de l'évènement.</param>
        /// </summary>
        public DateTime DateEtHeure { get; private set; }

        /// <summary>
        /// Adresse de l'évènement.</param>
        /// </summary>
        public Adresse Adresse { get; private set; }

        /// <summary>
        /// Remarques du policier répondant.</param>
        /// </summary>
        public string Remarques { get; private set; }
    }
}
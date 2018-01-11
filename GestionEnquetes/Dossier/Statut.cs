using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEnquetes
{
    public enum CodeStatut
    {
        _1,
        _2,
        A,
        B,
        C,
        F,
        H,
        I,
        Z
    }

    public class Statut
    {
        public string Numero { get; private set; } //numéro de dossier
        public DateTime DateHeure { get; private set; }
        public CodeStatut CodeStatut { get; private set; }
        public int Matricule { get; private set; }

        public Statut(string p_numero, DateTime p_dateHeure, CodeStatut p_codeStatut, int p_matricule)
        {
            Numero = p_numero;
            DateHeure = p_dateHeure;
            CodeStatut = p_codeStatut;
            Matricule = p_matricule;
        }
    }
}

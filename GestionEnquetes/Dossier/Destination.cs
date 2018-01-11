using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEnquetes
{
    public enum CodeDestination
    {
        RED,
        REV,
        BEC,
        SD,
        ATT,
        ARC
    }
    public class Destination
    {
        public DateTime HeureTransfer { get; private set; }
        public CodeDestination CodeDestination { get; private set; }
        public string Remarque { get; private set; }
        public string NumeroDossier { get; private set; }
        public int? MatriculePolicier { get; private set; }

        public Destination(DateTime p_heureTransfer, CodeDestination p_codeDestination, string p_remarque, string p_numeroDossier, int? p_matriculeDossier)
        {
            HeureTransfer = p_heureTransfer;
            CodeDestination = p_codeDestination;
            Remarque = p_remarque;
            NumeroDossier = p_numeroDossier;
            MatriculePolicier = p_matriculeDossier;
        }
    }
}

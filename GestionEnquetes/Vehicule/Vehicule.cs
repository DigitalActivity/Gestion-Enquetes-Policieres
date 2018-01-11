using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEnquetes
{
    // TODO : ajouter précision sur enum comme sur code personnes.
    public enum CodeVehicule { VDP, VIN, VOB, VOL, VRE, VRL, VRM, VSU }
    public class Vehicule
    {
        public int NoVehicule { get; private set; }
        public string Marque { get; private set; }
        public string Modele { get; private set; }
        public int Annee { get; private set; }
        public CodeVehicule CodeVehicule { get; private set; }
        public Personne Proprietaire { get; private set; }

        public Vehicule(int p_noVehicule, string p_marque, string p_modele,
            int p_annee,CodeVehicule p_codeVehicule, Personne p_proprietaire)
        {
            NoVehicule = p_noVehicule;
            Marque = p_marque;
            Modele = p_modele;
            Annee = p_annee;
            CodeVehicule = p_codeVehicule;
            Proprietaire = p_proprietaire;
        }

        public string getTitre()
        {
            return Marque + " " + Modele + " " + Annee;
        }

        public override bool Equals(object obj)
        {
            var item = obj as Vehicule;

            if (item.NoVehicule == this.NoVehicule)
                return true;

            return false;
        }
    }
}

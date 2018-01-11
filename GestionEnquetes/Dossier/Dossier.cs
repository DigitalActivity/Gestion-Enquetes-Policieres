using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEnquetes
{
    public class Dossier
    {
        public string Numero { get; private set; }
        public Statut Statut { get; private set; }
        public List<Vehicule> Vehicules { get; private set; }
        public List<Personne> Personnes { get; private set; }
        public RapportAccident RapportAccident { get; private set; }
        public RapportEvenement RapportEvenement { get; private set; }
        public RapportEnquete RapportEnquete { get; private set; }
        public Destination Destination { get; private set; }

        public Dossier(string p_numero, Statut p_statut,RapportAccident p_rapportAccident, RapportEvenement p_rapportEvenement,RapportEnquete p_rapportEnquete,Destination p_destination, List<Vehicule> p_vehicule, List<Personne> p_personnes)
        {
            Numero = p_numero;
            Statut = p_statut;
            RapportAccident = p_rapportAccident;
            RapportEvenement = p_rapportEvenement;
            RapportEnquete = p_rapportEnquete;
            Destination = p_destination;
            Vehicules = p_vehicule;
            Personnes = p_personnes;
        }

        public Dossier()
        {
            Numero = null;
            Statut = null;
            RapportAccident = null;
            RapportEvenement = null;
            RapportEnquete = null;
            Destination = null;
            Vehicules = new List<Vehicule>();
            Personnes = new List<Personne>();
        }

        public void SetRapportEvenement(RapportEvenement p_rapportEvenement)
        {
            RapportEvenement = p_rapportEvenement;
        }

        public void SetRapportAccident(RapportAccident p_rapportAccident)
        {
            RapportAccident = p_rapportAccident;
        }

        public void SetRapportEnquete(RapportEnquete p_rapportEnquete)
        {
            RapportEnquete = p_rapportEnquete;
        }


        public void SetDestination(Destination p_destination)
        {
            Destination = p_destination;
        }

        public void setPersonnes(List<Personne> p_personnes)
        {
            Personnes = p_personnes;
        }

        public List<Destination> getHistoriqueDestination()
        {
            return RequetesSQL.SQLChercherListeDestinationNoDossier(Numero);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GestionEnquetes;
using System.Collections.Generic;

namespace GestionEquetes.Tests
{
    [TestClass]
    public class TestDossier
    {
        [TestMethod]
        public void TestCreationDossier()
        {
            List<Personne> listePersonne = new List<Personne>();
            Personne personne = new Personne(1, "Jean", "Pagé", new DateTime(1997,1,24), "114 Marie Curie", CodePersonne.AVU);
            Personne personne2 = new Personne(2, "Bob", "Tourmaline", new DateTime(1995, 03, 05), "234 Chalifoux", CodePersonne.DEM);
            listePersonne.Add(personne);
            listePersonne.Add(personne2);

            List<Vehicule> listeVehicule = new List<Vehicule>();
            listeVehicule.Add(new Vehicule(1, "Honda", "Civic", 1997, CodeVehicule.VDP, personne));

            RapportEnquete rapportEnquete = new RapportEnquete(1, "Le chat appartenais à la locataire de l'immeuble A123");
            RapportEvenement rapportEvenement = new RapportEvenement(1, CodeNature._01, "114 marie curie", new DateTime(2016, 2, 23, 12, 32, 22), "Aucune chose à précisé");
            RapportAccident rapportAccident = new RapportAccident(1, listeVehicule, "114 Marie curie", new DateTime(1999,10,12,1,23,44),"Grave blessé sur place et un chat écrasé par une auto.");
            Dossier dossier = new Dossier("ASD123", StatutDossier.A, rapportAccident, rapportEvenement,rapportEnquete, CodeDestination.ATT, listeVehicule, listePersonne);
        }
    }
}

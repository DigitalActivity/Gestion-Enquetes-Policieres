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
            Adresse adresse = new Adresse("Marie Curie", "Saint-Jean-sur-Richelieu", "QC", "J2W3C3");

            Compte compte = new Compte("Louis", "Lesage", 1111, new DateTime(1999, 4, 23), adresse, "5146609246", "louis.lesage28@hotmail.com", Grade.Capitaine, Hashage.Encrypter("bonjour"));

            List<Personne> listePersonne = new List<Personne>();
            Personne personne = new Personne(1, "Jean", "Pagé", new DateTime(1997, 1, 24), "114 Marie Curie", CodePersonne.AVU);
            Personne personne2 = new Personne(2, "Bob", "Tourmaline", new DateTime(1995, 03, 05), "234 Chalifoux", CodePersonne.DEM);
            listePersonne.Add(personne);
            listePersonne.Add(personne2);

            List<Vehicule> listeVehicule = new List<Vehicule>();
            listeVehicule.Add(new Vehicule(1, "Honda", "Civic", 1997, CodeVehicule.VDP, personne));

            RapportEnquete rapportEnquete = new RapportEnquete("1 Le chat appartenais à la locataire de l'immeuble A123", compte);
            RapportEvenement rapportEvenement = new RapportEvenement(CodeDeNature.TousLesCodesDeNature[0], new DateTime(2016, 2, 23, 12, 32, 22), adresse, "Aucune chose à précisé");
            RapportAccident rapportAccident = new RapportAccident(1, listeVehicule, adresse, new DateTime(1999, 10, 12, 1, 23, 44), "Grave blessé sur place et un chat écrasé par une auto.");
            Statut statut = new Statut("ASD123", DateTime.Now, CodeStatut.A, compte.Matricule);
            Destination destination = new Destination(DateTime.Now, CodeDestination.ATT, " nothing ", "ASD123", compte.Matricule);
            Dossier dossier = new Dossier("ASD123", statut, rapportAccident, rapportEvenement, rapportEnquete, destination, listeVehicule, listePersonne);


            Assert.AreEqual(listePersonne, dossier.Personnes);
            Assert.AreEqual(listeVehicule, dossier.Vehicules);
            Assert.AreEqual(rapportEnquete, dossier.RapportEnquete);
            Assert.AreEqual(rapportEvenement, dossier.RapportEvenement);
            Assert.AreEqual(rapportAccident, dossier.RapportAccident);
            Assert.AreEqual(statut, dossier.Statut);
            Assert.AreEqual(destination, dossier.Destination);
        }
    }
}

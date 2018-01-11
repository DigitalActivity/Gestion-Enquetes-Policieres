using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GestionEnquetes;
using System.Collections.Generic;

namespace GestionEquetes.Tests
{
    [TestClass]
    public class TestRapportAccident
    {
        [TestMethod]
        public void TestCreationRapportAccident()
        {
            Personne personne = new Personne(1, "Jean", "Pagé", new DateTime(1997, 1, 24), "114 Marie Curie", CodePersonne.AVU);

            List<Vehicule> listeVehicule = new List<Vehicule>();
            listeVehicule.Add(new Vehicule(1, "Honda", "Civic", 1997, CodeVehicule.VDP, personne));
            Adresse adresse = new Adresse("Marie Curie", "Saint-Jean-sur-Richelieu", "QC", "J2W3C3");
            RapportAccident rapportAccident = new RapportAccident(1, listeVehicule, adresse, new DateTime(1999, 10, 12, 1, 23, 44), "Grave blessé sur place et un chat écrasé par une auto.");

            Assert.AreEqual(1, rapportAccident.NoRapport);
            Assert.AreEqual(listeVehicule, rapportAccident.VehiculesImpliques);
            Assert.AreEqual(adresse, rapportAccident.Adresse);
            Assert.AreEqual(new DateTime(1999, 10, 12, 1, 23, 44), rapportAccident.DateEtHeure);
            Assert.AreEqual("Grave blessé sur place et un chat écrasé par une auto.", rapportAccident.Remarques);
        }
    }
}

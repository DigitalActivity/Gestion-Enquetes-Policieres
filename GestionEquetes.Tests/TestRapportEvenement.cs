using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GestionEnquetes;

namespace GestionEquetes.Tests
{
    [TestClass]
    public class TestRapportEvenement
    {
        [TestMethod]
        public void TestCreationRapportEvenement()
        {
            Adresse adresse = new Adresse("Marie Curie", "Saint-Jean-sur-Richelieu", "QC", "J2W3C3");
            RapportEvenement rapportEvenement = new RapportEvenement(CodeDeNature.getCodeNature(1), new DateTime(2016, 2, 23, 12, 32, 22), adresse, "Aucune chose à précisé");

            Assert.AreEqual(CodeDeNature.getCodeNature(1), rapportEvenement.CodeDeNature);
            Assert.AreEqual(adresse, rapportEvenement.Adresse);
            Assert.AreEqual(new DateTime(2016, 2, 23, 12, 32, 22), rapportEvenement.DateEtHeure);
            Assert.AreEqual("Aucune chose à précisé", rapportEvenement.Remarques);
        }
    }
}

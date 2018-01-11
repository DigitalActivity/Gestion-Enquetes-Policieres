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
            RapportEvenement rapportEvenement = new RapportEvenement(1, CodeNature._01, "114 marie curie", new DateTime(2016, 2, 23, 12, 32, 22), "Aucune chose à précisé");

            Assert.AreEqual(1, rapportEvenement.Numero);
            Assert.AreEqual(CodeNature._01, rapportEvenement.CodeNature);
            Assert.AreEqual("114 marie curie", rapportEvenement.Endroit);
            Assert.AreEqual(new DateTime(2016, 2, 23, 12, 32, 22), rapportEvenement.DateHeure);
            Assert.AreEqual("Aucune chose à précisé", rapportEvenement.Remarque);
        }
    }
}

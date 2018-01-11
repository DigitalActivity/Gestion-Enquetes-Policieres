using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GestionEnquetes;

namespace GestionEquetes.Tests
{
    [TestClass]
    public class TestPersonne
    {
        [TestMethod]
        public void TestCreationPersonne()
        {
            Personne personne = new Personne(1, "Pagé", "Jean", new DateTime(1980, 1, 2), "114 Marie Curie", CodePersonne.AVU);

            Assert.AreEqual(1, personne.Numero);
            Assert.AreEqual("Pagé", personne.Nom);
            Assert.AreEqual("Jean", personne.Prenom);
            Assert.AreEqual(new DateTime(1980, 1, 2), personne.DateNaissance);
            Assert.AreEqual("114 Marie Curie", personne.Adresse);
            Assert.AreEqual(CodePersonne.AVU, personne.CodePersonne);
        }
    }
}

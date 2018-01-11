using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GestionEnquetes;

namespace GestionEquetes.Tests
{
    [TestClass]
    public class TestVehicule
    {
        [TestMethod]
        public void TestCreationVehicule()
        {
            Personne personne = new Personne(1, "Jean", "Pagé", DateTime.Today, "114 Marie Curie", CodePersonne.AVU);
            Vehicule vehicule = new Vehicule(1, "Honda", "Civic", 1997, CodeVehicule.VDP, personne);
            Vehicule vehicule2 = new Vehicule(1, "Honda", "Civic", 1997, CodeVehicule.VDP, personne);

            Assert.AreEqual(1, vehicule.NoVehicule);
            Assert.AreEqual("Honda", vehicule.Marque);
            Assert.AreEqual("Civic", vehicule.Modele);
            Assert.AreEqual(1997, vehicule.Annee);
            Assert.AreEqual(CodeVehicule.VDP, vehicule.CodeVehicule);
            Assert.AreEqual(personne, vehicule.Proprietaire);

            Assert.AreEqual(vehicule, vehicule2);
            Assert.AreEqual(vehicule2, vehicule);
            Assert.AreNotEqual(vehicule, null);

            Vehicule vehicule3 = vehicule2;
            Assert.AreEqual(vehicule, vehicule3);
        }
    }
}

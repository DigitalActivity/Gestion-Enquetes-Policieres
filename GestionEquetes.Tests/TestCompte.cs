using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GestionEnquetes;
using System.Collections.Generic;

namespace GestionEquetes.Tests
{
    [TestClass]
    public class TestCompte
    {
        [TestMethod]
        public void TestCreationCompte()
        {

            Adresse adresse = new Adresse("114 Marie Curie", "Saint-Jean-sur-Richelieu", "Quebec", "J2W3C3", "Canada");
            Compte compte = new Compte("Louis", "Lesage", 1111, new DateTime(1999, 4, 23), adresse, "5146609246", "louis.lesage28@hotmail.com" , Grade.Capitaine, Hashage.Encrypter("bonjour"));
            Assert.AreEqual("Louis",compte.Prenom);
            Assert.AreEqual("Lesage", compte.Nom);
            Assert.AreEqual(1111, compte.Matricule);
            Assert.AreEqual(new DateTime(1999, 4, 23), compte.Naissance);      
            Assert.AreEqual(adresse, compte.Adrss);      
            Assert.AreEqual("5146609246", compte.Telephone);
            Assert.AreEqual("louis.lesage28@hotmail.com", compte.Email);
            Assert.AreEqual(Grade.Capitaine, compte.Grade);
            //Assert.AreEqual(Hashage.Encrypter("bonjour"), compte.HashPass); // ne va pas être egale. mais le checksum oui
        }
    }
}

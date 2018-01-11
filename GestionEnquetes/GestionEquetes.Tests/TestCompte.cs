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
            Compte compte = new Compte("Louis", "Lesage", "LL123", new DateTime(1999, 4, 23), new Adresse(114, "Marie Curie", "Saint-Jean-sur-Richelieu", "Quebec", "J2W3C3", "Canada"), new List<string>() { "5146609246" }, new List<string>() { "louis.lesage28@hotmail.com" }, Grade.Capitaine, Hashage.Encrypter("bonjour"));


            Assert.AreEqual("Louis",compte.Prenom);
            Assert.AreEqual("Lesage", compte.Nom);
            Assert.AreEqual("LL123", compte.Matricule);
            Assert.AreEqual(new DateTime(1999, 4, 23), compte.Naissance);      
            Assert.AreEqual(new Adresse(114, "Marie Curie", "Saint-Jean-sur-Richelieu", "Quebec", "J2W3C3", "Canada"), compte.Adrs);      
            Assert.AreEqual(new List<string>() { "5146609246" }, compte.Numero);
            Assert.AreEqual(new List<string>() { "louis.lesage28@hotmail.com" }, compte.Email);
            Assert.AreEqual(Grade.Capitaine, compte.Grad);
            Assert.AreEqual(Hashage.Encrypter("bonjour"), compte.HashPass);
        }
    }
}

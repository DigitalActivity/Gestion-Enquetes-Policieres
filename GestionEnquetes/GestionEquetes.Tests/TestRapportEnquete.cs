using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GestionEnquetes;
using System.Collections.Generic;

namespace GestionEquetes.Tests
{
    [TestClass]
    public class TestRapportEnquete
    {
        [TestMethod]
        public void TestCreationRapportEnquete()
        {
            Compte compte = new Compte("Louis", "Lesage", "LL123", new DateTime(1999, 4, 23), new Adresse(114,"Marie Curie","Saint-Jean-sur-Richelieu","Quebec","J2W3C3","Canada"), new List<string>() { "5146609246" }, new List<string>() { "louis.lesage28@hotmail.com" }, Grade.Capitaine, Hashage.Encrypter("bonjour"));
            RapportEnquete rapportEnquete = new RapportEnquete(compte,"Le rapport d'enquête est long et remplie de moments hardu.");

            Assert.AreEqual("Le rapport d'enquête est long et remplie de moments hardu.", rapportEnquete.Contenu);
            Assert.AreEqual(compte, rapportEnquete.Matricule);
        }
    }
}

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
            Compte compte = new Compte("Louis", "Lesage", 1111, new DateTime(1999, 4, 23), new Adresse("114 Marie Curie", "Saint-Jean-sur-Richelieu","Quebec","J2W3C3","Canada"), "5146609246", "louis.lesage28@hotmail.com", Grade.Capitaine, Hashage.Encrypter("bonjour"));
            RapportEnquete rapportEnquete = new RapportEnquete("Le rapport d'enquête est long et remplie de moments hardu.",compte);

            Assert.AreEqual("Le rapport d'enquête est long et remplie de moments hardu.", rapportEnquete.Contenu);
            Assert.AreEqual(compte, rapportEnquete.Matricule);
        }
    }
}

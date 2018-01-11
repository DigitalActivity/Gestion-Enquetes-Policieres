using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GestionEnquetes;

namespace GestionEquetes.Tests
{
    [TestClass]
    public class TestStatut
    {
        [TestMethod]
        public void TestCreationStatut()
        {
            string no = "no";
            CodeStatut code = CodeStatut.A;
            DateTime date = new DateTime(1999, 10, 12, 1, 23, 44);
            int matricule = 1111;
            Statut statut = new Statut(no, date, code, matricule);

            Assert.AreEqual(no, statut.Numero);
            Assert.AreEqual(code, statut.CodeStatut);
            Assert.AreEqual(matricule, statut.Matricule);
            Assert.AreEqual(date, statut.DateHeure);
        }
    }
}

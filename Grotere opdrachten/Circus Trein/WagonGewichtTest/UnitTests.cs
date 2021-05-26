using Circus_trein;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace WagonGewichtTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void Dier_Wordggegeten_True_HerbivoorWordGegeten()
        {
            Herbivoor dierH = new Herbivoor(Herbivoor.Groottes.Gemiddeld);
            Carnivoor dierC = new Carnivoor(Carnivoor.Groottes.Gemiddeld);
            List<Dier> anderDier = new List<Dier> { dierC };

            var result = dierH.WordGegeten(anderDier);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Trein_DierToevoegen_True_2GrootteHerbivorenPassen()
        {
            Herbivoor dier1 = new Herbivoor(Herbivoor.Groottes.Groot);
            Herbivoor dier2 = new Herbivoor(Herbivoor.Groottes.Groot);

            List<Dier> dieren = new List<Dier> { dier1, dier2 };

            Trein trein = new Trein(dieren);
            trein.DierToevoegen(dieren, 10);

            Assert.AreEqual(10, trein.TotaalGewicht);
        }

        [TestMethod]
        public void Aanmaak_MaakDier_True_AantalDieren()
        {
            Aanmaak aanmaak = new Aanmaak();
            List<Dier> dieren = aanmaak.MaakDier(5, 5);

            Assert.AreEqual(5, dieren.Count);
        }

        [TestMethod]
        public void Dier_EetAnderen_True_CarnivoorKanEten()
        {
            Carnivoor dierC = new Carnivoor(Dier.Groottes.Groot);
            Herbivoor dierH = new Herbivoor(Dier.Groottes.Klein);

            List<Dier> anderDier = new List<Dier> { dierH };

            var result = dierC.EetAnderen(anderDier);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Trein_WagonLaden_True_KanWagonLaden()
        {
            Herbivoor dier1 = new Herbivoor(Dier.Groottes.Klein);
            Herbivoor dier2 = new Herbivoor(Dier.Groottes.Gemiddeld);
            
            List<Dier> dieren = new List<Dier> { dier1, dier2 };
            Trein trein = new Trein(dieren);

            trein.WagonLaden();

            Assert.AreEqual(1, trein.Wagons.Count);
        }
    }
}

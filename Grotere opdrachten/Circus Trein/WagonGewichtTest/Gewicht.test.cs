using Circus_Trein;
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
            List<Dier> anderdier = new List<Dier> { dierC };

            var result = dierH.WordGegeten(anderdier);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Wagon_DierToevoegen_True_2GrootteHerbivorenPassen()
        {
            Herbivoor dier1 = new Herbivoor(Herbivoor.Groottes.Groot);
            Herbivoor dier2 = new Herbivoor(Herbivoor.Groottes.Groot);

            List<Dier> dieren = new List<Dier> { dier1, dier2 };

            Wagon wagon = new Wagon();
            wagon.DierToevoegen(dieren);

            Assert.AreEqual(10, wagon.TotaalGewicht);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bataille_Navale;

namespace Bataille_Navale_Test
{
    [TestClass]
    public class GrilleTest
    {
        [TestMethod]
        public void accessGrille()
        {
            Grille gr = new Grille(3,3);
            //int x = 0;
            //int[] array = {5,6,1};
            //CollectionAssert.AreEqual(gr.checkParams(5,6,1920,1080),array);

        }

        [TestMethod]
        public void accessGrille2()
        {
            Grille gr = new Grille(3, 3);
            Case c = gr.recupCase(2, 1);
            Assert.IsNotNull(c);

        }
    }
}

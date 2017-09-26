using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CodeFightUnitTests
{
    [TestClass()]
    public class adjacentElementsProductClassUnitTests
    {
        adjacentElementsProductClass ae = new adjacentElementsProductClass();
        [TestMethod()]
        public void adjacentElementsProductTest1()
        {
            int[] inputArray = new int[] { 3, 6, (-2), (-5), 7, 3 };
            Assert.AreEqual(21, ae.adjacentElementsProduct(inputArray));
        }
        [TestMethod()]
        public void adjacentElementsProductTest2()
        {
            int[] inputArray = new int[] { -1, -2 };
            Assert.AreEqual(2, ae.adjacentElementsProduct(inputArray));
        }
        [TestMethod()]
        public void adjacentElementsProductTest3()
        {
            int[] inputArray = new int[] { 5, 1, 2, 3, 1, 4 };
            Assert.AreEqual(6, ae.adjacentElementsProduct(inputArray));
        }

        [TestMethod()]
        public void adjacentElementsProductTest4()
        {
            int[] inputArray = new int[] { 1, 2, 3, 0 };
            Assert.AreEqual(6, ae.adjacentElementsProduct(inputArray));
        }
        [TestMethod()]
        public void adjacentElementsProductTest5()
        {
            int[] inputArray = new int[] { 9, 5, 10, 2, 24, -1, -48 };
            Assert.AreEqual(50, ae.adjacentElementsProduct(inputArray));
        }

        [TestMethod()]
        public void adjacentElementsProductTest6()
        {
            int[] inputArray = new int[] { 5, 6, -4, 2, 3, 2, -23 };
            Assert.AreEqual(30, ae.adjacentElementsProduct(inputArray));
        }

        [TestMethod()]
        public void adjacentElementsProductTest7()
        {
            int[] inputArray = new int[] { 4, 1, 2, 3, 1, 5 };
            Assert.AreEqual(6, ae.adjacentElementsProduct(inputArray));
        }

        [TestMethod()]
        public void adjacentElementsProductTest8()
        {
            int[] inputArray = new int[] { -23, 4, -3, 8, -12 };
            Assert.AreEqual(-12, ae.adjacentElementsProduct(inputArray));
        }

        [TestMethod()]
        public void adjacentElementsProductTest9()
        {
            int[] inputArray = new int[] { 1, 0, 1, 0, 1000 };
            Assert.AreEqual(0, ae.adjacentElementsProduct(inputArray));
        }





    }
}
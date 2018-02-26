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
    public class AlmostIncreasingSequenceUnitTests
    {
        AlmostIncreasingSequence ais = new AlmostIncreasingSequence();
        [TestMethod()]
        public void almostIncreasingSequenceTest()
        {
            int[] testArray = new int[] { 1, 3, 2, 1 };
            Assert.IsFalse(ais.almostIncreasingSequence(testArray));
        }
        [TestMethod()]
        public void almostIncreasingSequenceTest2()
        {
            int[] testArray = new int[] { 1, 3, 2 };
            Assert.IsTrue(ais.almostIncreasingSequence(testArray));
        }
        [TestMethod()]
        public void almostIncreasingSequenceTest3()
        {
            int[] testArray = new int[] { 1, 4, 10, 4, 2 };
            Assert.IsFalse(ais.almostIncreasingSequence(testArray));
        }
        [TestMethod()]
        public void almostIncreasingSequenceTest4()
        {
            int[] testArray = new int[] { 10, 1, 2, 3, 4, 5 };
            Assert.IsTrue(ais.almostIncreasingSequence(testArray));
        }
        [TestMethod()]
        public void almostIncreasingSequenceTest5()
        {
            int[] testArray = new int[] { 3, 5, 67, 98, 3 };
            Assert.IsTrue(ais.almostIncreasingSequence(testArray));
        }
        [TestMethod()]
        public void almostIncreasingSequenceTest6()
        {
            int[] testArray = new int[] { 1, 2, 3, 4, 3, 6 };
            Assert.IsTrue(ais.almostIncreasingSequence(testArray));
        }
        [TestMethod()]
        public void almostIncreasingSequenceTest7()
        {
            int[] testArray = new int[] { 1, 1 };
            Assert.IsTrue(ais.almostIncreasingSequence(testArray));
        }
        [TestMethod()]
        public void almostIncreasingSequenceTest8()
        {
            int[] testArray = new int[] { 1, 2, 3, 4, 5, 3, 5, 6 };
            Assert.IsFalse(ais.almostIncreasingSequence(testArray));
        }
    }
}
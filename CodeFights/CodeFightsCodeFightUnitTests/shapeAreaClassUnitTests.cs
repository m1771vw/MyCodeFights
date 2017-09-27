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
    public class shapeAreaClassUnitTests
    {
        shapeAreaClass sa = new shapeAreaClass();
        [TestMethod()]
        public void shapeAreaTest1()
        {
            Assert.AreEqual(5, sa.shapeArea(2));
        }

        [TestMethod()]
        public void shapeAreaTest2()
        {
            Assert.AreEqual(13, sa.shapeArea(3));
        }

        [TestMethod()]
        public void shapeAreaTest3()
        {
            Assert.AreEqual(1, sa.shapeArea(1));
        }

        [TestMethod()]
        public void shapeAreaTest4()
        {
            Assert.AreEqual(25, sa.shapeArea(4));
        }

        [TestMethod()]
        public void shapeAreaTest5()
        {
            Assert.AreEqual(41, sa.shapeArea(5));
        }

    }
}
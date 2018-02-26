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
    public class makeArrayConsecutive2ClassUnitTests
    {
        makeArrayConsecutive2Class mac = new makeArrayConsecutive2Class();
        [TestMethod()]
        public void makeArrayConsecutive2Test()
        {

        }
        [TestMethod()]
        public void testSortArray()
        {
            
            int[] testArray = new int[] { 6, 4, 2, 1, 8 };
            int[] goodArray = new int[] { 1, 2, 4, 6, 8 };
            Assert.IsTrue(mac.sortArray(testArray, testArray.Length).SequenceEqual(goodArray));
            
        }
        [TestMethod()]
        public void testMakeArrayConsective2Test1()
        {
            int[] testArray = new int[] { 6, 2, 3, 8 };
            Assert.AreEqual(mac.makeArrayConsecutive2(testArray), 3);
        }
        [TestMethod()]
        public void testMakeArrayConsective2Test2()
        {
            int[] testArray = new int[] { 0, 3 };
            Assert.AreEqual(mac.makeArrayConsecutive2(testArray), 2);
        }
        [TestMethod()]
        public void testMakeArrayConsective2Test3()
        {
            int[] testArray = new int[] { 5, 4, 6 };
            Assert.AreEqual(mac.makeArrayConsecutive2(testArray), 0);
        }
        [TestMethod()]
        public void testMakeArrayConsective2Test4()
        {
            int[] testArray = new int[] { 6, 3 };
            Assert.AreEqual(mac.makeArrayConsecutive2(testArray), 2);
        }
    }
}
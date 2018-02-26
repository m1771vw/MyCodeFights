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
    public class AllLongestStringsClassUnitTests
    {
        AllLongestStringsClass alsc = new AllLongestStringsClass();
        [TestMethod()]
        public void allLongestStringsTest()
        {
            string[] testArray = new string[] { "aba", "aa", "ad", "vcd", "aba" };
            string[] expected = new string[] { "aba", "vcd", "aba" };

            Assert.IsTrue(expected.SequenceEqual(alsc.allLongestStrings(testArray)));
        }
        [TestMethod()]
        public void allLongestStringsTest2()
        {
            string[] testArray = new string[] { "aa" };
            string[] expected = new string[] { "aa" };

            Assert.IsTrue(expected.SequenceEqual(alsc.allLongestStrings(testArray)));
        }
        [TestMethod()]
        public void allLongestStringsTest3()
        {
            string[] testArray = new string[] { "abc", "eeee", "abcd", "dcd" };
            string[] expected = new string[] { "eeee", "abcd" };

            Assert.IsTrue(expected.SequenceEqual(alsc.allLongestStrings(testArray)));
        }
        [TestMethod()]
        public void allLongestStringsTest4()
        {
            string[] testArray = new string[] { "a", "abc", "cbd", "zzzzzz", "a", "abcdef", "asasa", "aaaaaa" };
            string[] expected = new string[] { "zzzzzz", "abcdef", "aaaaaa" };

            Assert.IsTrue(expected.SequenceEqual(alsc.allLongestStrings(testArray)));
        }
    }
}
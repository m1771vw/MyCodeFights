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
    public class checkPalindromeUnitTests
    {
        checkPalindromeClass cp = new checkPalindromeClass();
        [TestMethod()]
        public void checkPalindromeTest1()
        {
            Assert.IsTrue(cp.checkPalindrome("aabaa"));
        }

        [TestMethod()]
        public void checkPalindromeTest2()
        {
            Assert.IsFalse(cp.checkPalindrome("abac"));
        }

        [TestMethod()]
        public void checkPalindromeTest3()
        {
            Assert.IsTrue(cp.checkPalindrome("a"));
        }

        [TestMethod()]
        public void checkPalindromeTest4()
        {
            Assert.IsFalse(cp.checkPalindrome("az"));
        }

        [TestMethod()]
        public void checkPalindromeTest5()
        {
            Assert.IsTrue(cp.checkPalindrome("abacaba"));
        }
        [TestMethod()]
        public void checkPalindromeTest6()
        {
            Assert.IsTrue(cp.checkPalindrome("z"));
        }
        [TestMethod()]
        public void checkPalindromeTest7()
        {
            Assert.IsFalse(cp.checkPalindrome("aaabaaaa"));
        }
        [TestMethod()]
        public void checkPalindromeTest8()
        {
            Assert.IsFalse(cp.checkPalindrome("zzzazzazz"));
        }
        [TestMethod()]
        public void checkPalindromeTest9()
        {
            Assert.IsTrue(cp.checkPalindrome("hlbeeykoqqqqokyeeblh"));
        }
        [TestMethod()]
        public void checkPalindromeTest10()
        {
            Assert.IsTrue(cp.checkPalindrome("hlbeeykoqqqokyeeblh"));
        }


    }
}
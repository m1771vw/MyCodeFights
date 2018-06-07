using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.Tests
{
    [TestClass()]
    public class ReverseParenthesesTests
    {
        ReverseParentheses rp = new ReverseParentheses();
        [TestMethod()]
        public void reverseParenthesesFunctionTest1()
        {
            string s1 = "a(bc)de";
            Assert.AreEqual("acbde", rp.reverseParenthesesFunction(s1));
        }
        [TestMethod()]
        public void reverseParenthesesFunctionTest2()
        {
            string s1 = "a(bcdefghijkl(mno)p)p";
            Assert.AreEqual("apmnolkjihgfedcbq", rp.reverseParenthesesFunction(s1));
        }
    }
}
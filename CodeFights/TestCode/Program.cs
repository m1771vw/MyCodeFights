using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "a(bc)de";
            ReverseParentheses rp = new ReverseParentheses();
            rp.reverseParenthesesFunction(s1);
            
            //Console.WriteLine(alsc.allLongestStrings(testArray));
            Console.ReadKey();
        }
    }
}

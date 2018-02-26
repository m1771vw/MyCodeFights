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
            string[] testArray = new string[] { "aba", "aa", "ad", "vcd", "aba" };
            string[] expected = new string[] { "aba", "vcd", "aba" };
            AllLongestStringsClass alsc = new AllLongestStringsClass();
            
            //Console.WriteLine(alsc.allLongestStrings(testArray));



            Console.ReadKey();
        }
    }
}

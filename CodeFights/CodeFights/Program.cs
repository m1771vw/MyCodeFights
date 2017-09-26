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
            checkPalindromeClass jb = new checkPalindromeClass();

            Console.WriteLine("Is racecar a palindrome? " + jb.checkPalindrome("racecar"));
            Console.WriteLine("Is chocolate a palindrome? " + jb.checkPalindrome("chocolate"));
            


            Console.ReadKey();
        }
    }
}

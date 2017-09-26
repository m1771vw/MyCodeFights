using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights
{
    public class checkPalindromeClass
    {
        // "aabaa"
        public bool checkPalindrome(string inputString)
        {
            int i = 0;
            if (inputString.Length % 2 == 0)
            {
                if (inputString[inputString.Length / 2-1] != inputString[inputString.Length / 2])
                    return false;
                else return true;
            }
        
            while (i < inputString.Length / 2)
            {
                if (inputString[i] != inputString[inputString.Length - 1 - i])
                    return false;
                i++;

            }
            return true;
        }
    }
}

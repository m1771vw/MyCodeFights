using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights
{
    public class AllLongestStringsClass
    {
        public object allLongestStrings2(string[] inputArray)
        {
            return inputArray.Where(s => s.Length == inputArray.Max(i => i.Length));
        }
        public string[] allLongestStrings(string[] inputArray)
        {
            var longestString = 0;
            List<string> testList = new List<string>();
            
            for (int i = 0; i < inputArray.Length; i++)
            {
                if(inputArray[i].Length > longestString)
                {
                    longestString = inputArray[i].Length;
                    testList.Clear();
                }
                if(inputArray[i].Length == longestString)
                {
                    testList.Add(inputArray[i]);
                }
            }

            return testList.ToArray();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights
{
    public class adjacentElementsProductClass
    {
        //[3, 6, -2, -5, 7, 3]
        // return 21
        public int adjacentElementsProduct(int[] inputArray)
        {
            int tempBig = -100000000;
            for(int i = 0; i < inputArray.Length-1; i++)
            {
                if(inputArray[i]*inputArray[i+1] >= tempBig)
                {
                    tempBig = inputArray[i] * inputArray[i + 1];
                }
            }

            return tempBig;
        }
    }
}

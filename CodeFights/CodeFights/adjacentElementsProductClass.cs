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
            int tempBig = inputArray[0] * inputArray[1]; 
            for(int i = 1; i < inputArray.Length-1; i++)
            {
                int tempProduct = inputArray[i] * inputArray[i + 1];
                if(tempBig <= tempProduct)
                {
                    tempBig = tempProduct;
                }
            }

            return tempBig;
        }


    }
}

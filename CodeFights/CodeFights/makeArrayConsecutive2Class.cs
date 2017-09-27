using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights
{
    public class makeArrayConsecutive2Class
    {
        //Find min and max of array
        // Search each number and see if array has it
        public int makeArrayConsecutive2(int[] statues)
        {
            int tempBig = 0;
            int tempSmall = 0;
            int[] tempArray = new int[] { };

            for(int i = 0; i < statues.Length-1; i++)
            {
                if(statues[i] > statues[i+1])
                {
                    tempBig = statues[i];
                    tempSmall = statues[i + 1];
                    statues[i] = tempSmall;
                    statues[i + 1] = tempBig;
                }
                
            }
            statues.ToList().ForEach(Console.WriteLine);
            return 0;
        }
    }
}

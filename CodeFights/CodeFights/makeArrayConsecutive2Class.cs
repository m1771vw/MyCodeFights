using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights
{
    public class makeArrayConsecutive2Class
    {
        // Find min and max of array
        // Search each number and see if array has it
        /*
         * For statues = [6, 2, 3, 8], the output should be
            makeArrayConsecutive2(statues) = 3
         */
        public int makeArrayConsecutive2(int[] statues)
        {
      
            int numbersMissing = 0;
            statues = sortArray(statues, statues.Length);
            for (int i = 0; i < statues.Length-1; i++)
            {
                if(statues[i+1] - statues[i] != 1)
                {
                    numbersMissing++;
                }
            }
            statues.ToList().ForEach(Console.WriteLine);
            Console.WriteLine(numbersMissing);
            return numbersMissing;
        }

        public int[] sortArray(int[] statues, int arrayLength)
        {
            int temp = 0;
            for (int i = 0; i < statues.Length-1; i++)
            {
                //[2, 3, 7, 4, 10]
                if (statues[i] > statues[i + 1])
                {
                    temp = statues[i];
                    statues[i] = statues[i + 1];
                    statues[i + 1] = temp;
                }
                
            }
            return statues;
        }
    }
}

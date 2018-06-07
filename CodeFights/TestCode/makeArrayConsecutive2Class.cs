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
                    numbersMissing += ((statues[i+1] - statues[i] - 1));
                }
            }
            statues.ToList().ForEach(Console.WriteLine);
            Console.WriteLine(numbersMissing);
            return numbersMissing;
        }

        public int[] sortArray(int[] statues, int arrayLength)
        {
            int temp = 0;
            for (int i = 0; i < statues.Length; i++)
            {
                for (int j = 0; j < statues.Length-i-1; j++)
                {
                    if (statues[j] > statues[j + 1])
                    {
                        temp = statues[j];
                        statues[j] = statues[j + 1];
                        statues[j + 1] = temp;
                    }
                }
                //[2, 3, 7, 4, 10]
                
                
            }
            return statues;
        }
    }
}

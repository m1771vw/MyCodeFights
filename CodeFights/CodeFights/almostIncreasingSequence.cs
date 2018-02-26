using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights
{
    public class AlmostIncreasingSequence
    {
        public bool almostIncreasingSequence(int[] sequence)
        {
            var badnum = 0;
            for (int i = 0; i < sequence.Length-1; i++)
            {
                if (sequence[i] >= sequence[i + 1])
                {
                    badnum++;
                }
                if(i+2 < sequence.Length && sequence[i] >= sequence[i + 2])
                {
                    badnum++;
                }
            }
            return badnum <= 2;
        }
        public bool almostIncreasingSequence2(int[] sequence)
        {
            bool inSequence = false;
            int[] tempArray = new int[] { };
            for (int i = 0; i < sequence.Length-1; i++)
            {
                if(sequence[i+1] - sequence[i] < 0)
                {
                    var sList = sequence.ToList();
                    sList.RemoveAt(i);
                    tempArray = sList.ToArray();
                    for (int j = 0; j < tempArray.Length - 1; j++)
                    {
                        if (tempArray[j + 1] - tempArray[j] > 0)
                        {
                            inSequence = true;
                        }
                        else
                        {
                            inSequence = false;
                            break;
                        }
                    }

                    if(inSequence == false)
                    {
                        sList = sequence.ToList();
                        sList.RemoveAt(i + 1);
                        tempArray = sList.ToArray();
                        for (int j = 0; j < tempArray.Length - 1; j++)
                        {
                            if (tempArray[j + 1] - tempArray[j] > 0)
                            {
                                inSequence = true;
                            }
                            else
                            {
                                inSequence = false;
                                break;
                            }
                        }
                    }
                    
                }
                if(sequence[i+1] - sequence[i] == 0 && sequence.Length == 2)
                {
                    inSequence = true;
                }
            }
            return inSequence;
        }
    }
}

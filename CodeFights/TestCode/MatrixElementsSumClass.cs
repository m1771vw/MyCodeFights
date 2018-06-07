using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights
{
    public class MatrixElementsSumClass
    {
        public int matrixElementsSum(int [][] matrix)
        {
            var totalCount = 0;
            for (int y = 0; y < matrix[0].Length; y++)
            {
                for (int x = 0; x < matrix.Length; x++)
                {
                    if (matrix[x][y] == 0) break;
                    else totalCount += matrix[x][y];
                }
            }
            return totalCount;
        }
        public int matrixElementsSum2(int[][] matrix)
        {
            
            var totalCounter = 0;
            for (int x = 0; x < matrix.Length; x++)
            {
                for (int y = 0; y < matrix[x].Length; y++)
                {
                    Console.WriteLine(@"Checking Matrix[" + x + "][" + y + "] : " + matrix[x][y]);
                    if (matrix[x][y] == 0)
                    {
                        for (int i = x; i < matrix.Length; i++)
                        {
                            Console.WriteLine(@"Found Matrix[" + i + "][" + y + "]: " + matrix[i][y]);
                            matrix[i][y] = 0;
                            Console.WriteLine(@"Changed Matrix["+i+"]["+y+"]: " + matrix[i][y]);
                        }
                    }
                    else
                    {
                        totalCounter += matrix[x][y];
                    }
                }
            }
            return totalCounter;
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CodeFightUnitTests
{
    [TestClass()]
    public class MatrixElementsSumClassUnitTests
    {
        MatrixElementsSumClass mes = new MatrixElementsSumClass();
        [TestMethod()]
        public void matrixElementsSumTest()
        {
            int[][] testArray = new int[][]
            {
                new int[] {0, 1, 1, 2 },
                new int[] {0, 5, 0, 0 },
                new int[] {2, 0, 3, 3 }
            };
            
            Assert.AreEqual(mes.matrixElementsSum(testArray), 9);
        }
        [TestMethod()]
        public void matrixElementsSumTest2()
        {
            int[][] testArray = new int[][]
            {
                new int[] {1, 1, 1, 0 },
                new int[] {0, 5, 0, 1 },
                new int[] {2, 1, 3, 10 }
            };

            Assert.AreEqual(mes.matrixElementsSum(testArray), 9);
        }
        [TestMethod()]
        public void matrixElementsSumTest3()
        {
            int[][] testArray = new int[][]
            {
                new int[] {1, 1, 1 },
                new int[] {2, 2, 2 },
                new int[] {3, 3, 3 }
            };

            Assert.AreEqual(mes.matrixElementsSum(testArray), 18);
        }
        [TestMethod()]
        public void matrixElementsSumTest4()
        {
            int[][] testArray = new int[][]
            {
                new int[] {0}

            };

            Assert.AreEqual(mes.matrixElementsSum(testArray), 0);
        }
    }
}
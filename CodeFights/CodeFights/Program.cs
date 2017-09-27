using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights
{
    class Program
    {
        static void Main(string[] args)
        {
            makeArrayConsecutive2Class arrayClass = new makeArrayConsecutive2Class();
            int[] testArray = new int[] { 6, 2, 3, 8 };
            arrayClass.makeArrayConsecutive2(testArray);




            Console.ReadKey();
        }
    }
}

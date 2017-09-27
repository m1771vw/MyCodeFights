using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights
{
    public class shapeAreaClass
    {
        // n = 2, area is 5
        // n = 3, area is 13
        // n = 4, area is 25
        // n = 5, area is 41
        public int oldShapeArea(int n)
        {
            if (n == 1)
                return 1;
            return (n * 4 - 4) + oldShapeArea(n - 1);
        }

        public int shapeArea(int n)
        {
            return n * n + (n - 1) * (n - 1);
        }

    }
}

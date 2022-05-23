using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeo
{
    public class Hardcoded
    {
        private double[,] arr;

        public Hardcoded()
        {
            arr = new double[3, 3]
            {
                { 2, 7, 1 }, { 3, -2, 8 }, {1, 5, 3}
            };
        }

        public void printArr()
        {
            Console.WriteLine(arr);
        }
    }
}

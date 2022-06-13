using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeo
{
    public class Hardcoded
    {
        public double[,] arrA { get; set; } = new double[3, 3];
        public double[,] arrB { get; set; } = new double[3, 3];

        public void calcInputs(double[,] arrC)
        {
            for(int i = 0; i<arrC.GetLength(0);i++)
            {
                for(int j = 0; j<arrC.GetLength(1);j++)
                {
                    if(i == j)
                    {
                        arrA[i, j] = 1;
                    }
                }
            }

            arrA[0, 1] = 0;
            arrA[0, 2] = 0;
            arrA[1, 2] = 0;

            arrB[1, 0] = 0;
            arrB[2, 0] = 0;
            arrB[2, 1] = 0;

            arrB[0, 0] = arrC[0, 0];
            arrB[0, 1] = arrC[0, 1];
            arrB[0, 2] = arrC[0, 2];

            arrA[1, 0] = (Math.Round((arrC[1, 0] / arrB[0, 0]) * 100) / 100);
            arrB[1, 1] = (Math.Round((arrC[1, 1] - arrA[1, 0] * arrB[0, 1]) * 100) / 100);
            arrB[1, 2] = (Math.Round((arrC[1, 2] - arrA[1, 0] * arrB[0, 2]) * 100) / 100);

            arrA[2, 0] = (Math.Round((arrC[2, 0] / arrB[0, 0]) * 100) / 100);
            arrA[2, 1] = (Math.Round((arrC[2, 1] - arrA[2, 0] * arrB[0, 1]) / arrB[1, 1] * 100) / 100);
            arrB[2, 2] = (Math.Round((arrC[2, 2] - arrA[2, 0] * arrB[0, 2] - arrA[2, 1] * arrB[1, 2]) * 100) / 100);
        }

        public void printArr(double[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}

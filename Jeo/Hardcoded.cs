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
            arrB[0, 0] = arrC[0, 0];
            arrB[0, 1] = arrC[0, 1];
            arrB[0, 2] = arrC[0, 2];

            arrA[1, 0] = arrC[1, 0] / arrB[0, 0];
            arrB[1, 1] = arrC[1, 1] - arrA[1, 0] * arrB[0, 1];
            arrB[1, 2] = arrC[1, 2] - arrA[1, 0] * arrB[0, 2];

            arrA[2, 0] = arrC[2, 0] / arrB[0, 0];
            arrA[2, 1] = (arrC[2, 1] - arrA[2, 0] * arrB[0, 1]) / arrB[1, 1];
            arrB[2, 2] = arrC[2, 2] - arrA[2, 0] * arrB[0, 2] - arrA[2, 1] * arrB[1, 2];
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

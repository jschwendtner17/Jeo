using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeo
{
    public class Hardcoded
    {
        public double[,] arrA { get; set; } = new double[4, 4];
        public double[,] arrB { get; set; } = new double[4, 4];

        public void calcInputs(double[,] arrC)
        {
            //diagonal
            Console.WriteLine("Diagonal");
            for (int i = 0; i < arrC.GetLength(0); i++)
            {
                arrA[i, i] = 1;
                Console.WriteLine($"arrA[{i},{i}] = 1");
            }
            Console.WriteLine();

            //top right corner
            Console.WriteLine("Top Right Corner");
            int x = 1;
            for (int i = 0; i < arrC.GetLength(0); i++)
            {
                for(int j = x; j < arrC.GetLength(1); j++)
                {
                    arrA[i,j] = 0;
                    Console.WriteLine($"arrA[{i},{j}] = 0");
                }
                x += 1;
            }
            Console.WriteLine();

            //bottom left corner
            Console.WriteLine("Bottom left corner");
            int y = 1;
            for (int i = 1; i < arrC.GetLength(0); i++)
            {
                for (int j = 0; j < y; j++)
                {
                    arrB[i, j] = 0;
                    Console.WriteLine($"arrB[{i},{j}] = 0");
                }
                y += 1;
            }
            Console.WriteLine();

            for (int i = 0; i < arrC.GetLength(1); i++)
            {
                arrB[0, i] = arrC[0, i];
            }

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

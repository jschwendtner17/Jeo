using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeo
{
    public class Hardcoded
    {
        public double[,] arrA { get; set; }
        public double[,] arrB { get; set; }
        public Hardcoded(int x)
        {
            arrA = new double[x, x];
            arrB = new double[x, x];
        }


        public void calcInputs(double[,] arrC)
        {
            //A diagonal
            Console.WriteLine("Diagonal");
            for (int i = 0; i < arrC.GetLength(0); i++)
            {
                arrA[i, i] = 1;
                Console.WriteLine($"arrA[{i},{i}] = 1");
            }
            Console.WriteLine();

            //A top right corner
            Console.WriteLine("Top Right Corner");
            int x = 1;
            for (int i = 0; i < arrC.GetLength(0); i++)
            {
                for (int j = x; j < arrC.GetLength(1); j++)
                {
                    arrA[i, j] = 0;
                    Console.WriteLine($"arrA[{i},{j}] = 0");
                }
                x += 1;
            }
            Console.WriteLine();

            //B bottom left corner
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

            //B first row
            for (int i = 0; i < arrC.GetLength(1); i++)
            {
                arrB[0, i] = arrC[0, i];
            }

            //A second row
            arrA[1, 0] = (Math.Round((arrC[1, 0] / arrB[0, 0]) * 100) / 100);

            //B second row
            for (int i = 1; i < arrC.GetLength(0); i++)
            {
                arrB[1, i] = (Math.Round((arrC[1, i] - arrA[1, 0] * arrB[0, i]) * 100) / 100);
            }

            //A 1st and 2nd column, B third row
            for (int i = 2; i < arrC.GetLength(0); i++)
            {
                arrA[i, 0] = (Math.Round((arrC[i, 0] / arrB[0, 0]) * 100) / 100);
                arrA[i, 1] = (Math.Round((arrC[i, 1] - arrA[i, 0] * arrB[0, 1]) / arrB[1, 1] * 100) / 100);
                arrB[2, i] = (Math.Round((arrC[2, i] - arrA[i, 0] * arrB[0, i] - arrA[i, 1] * arrB[1, i]) * 100) / 100);
            }
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

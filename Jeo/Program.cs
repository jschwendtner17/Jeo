using Jeo;

Hardcoded h = new Hardcoded();

const int MATRIX_ROWS = 3;
const int MATRIX_COLUMNS = 3;

double[,] arrC = new double[MATRIX_ROWS, MATRIX_COLUMNS];

for (int i = 0; i < MATRIX_ROWS; i++)
{
    for (int j = 0; j < MATRIX_COLUMNS; j++)
    {
        double input;
        Console.Write("Enter value for ({0},{1}): ", i, j);
        while (!double.TryParse(Console.ReadLine(), out input))
        {
            Console.Write("Enter correct value for ({0},{1}): ", i, j);
        }
        arrC[i, j] = input;
    }
}

h.calcInputs(arrC);

Console.WriteLine("C");
Console.WriteLine("--------------------");
h.printArr(arrC);
Console.WriteLine("--------------------");

Console.WriteLine();
Console.WriteLine("A");
Console.WriteLine("--------------------");
h.printArr(h.arrA);
Console.WriteLine("--------------------");

Console.WriteLine();
Console.WriteLine("B");
Console.WriteLine("--------------------");
h.printArr(h.arrB);
Console.WriteLine("--------------------");
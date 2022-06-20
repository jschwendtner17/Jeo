using Jeo;

Hardcoded h = new Hardcoded();

//const int MATRIX_ROWS_COLUMNS = 3;

//double[,] arrC = new double[MATRIX_ROWS_COLUMNS, MATRIX_ROWS_COLUMNS];

//for (int i = 0; i < MATRIX_ROWS_COLUMNS; i++)
//{
//    for (int j = 0; j < MATRIX_ROWS_COLUMNS; j++)
//    {
//        double input;
//        Console.Write("Enter value for ({0},{1}): ", i, j);
//        while (!double.TryParse(Console.ReadLine(), out input))
//        {
//            Console.Write("Enter correct value for ({0},{1}): ", i, j);
//        }
//        arrC[i, j] = input;
//    }
//}

double[,] arrC = new double[,] { { 2, 7, 1 }, { 3, -2, 8 }, { 1, 5, 3 } };

Console.WriteLine("C");
Console.WriteLine("--------------------");
h.printArr(arrC);
Console.WriteLine("--------------------");

h.calcInputs(arrC);

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
using Jeo;

//Console.WriteLine("X eingebn");
//int MATRIX_ROWS_COLUMNS = Int32.Parse(Console.ReadLine());

//Hardcoded h = new Hardcoded(MATRIX_ROWS_COLUMNS);
Hardcoded h = new Hardcoded(4);

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

double[,] arrC = new double[,] { { 2, 7, 1, 2 }, { 3, -2, 8, 2 }, { 1, 5, 3, 2 }, { 2, 2, 2, 2 } };

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
using Jeo;

Hardcoded h = new Hardcoded();

var arrC = new double[3, 3]
    {
        { 2, 7, 1 }, { 3, -2, 8 }, {1, 5, 3}
    };

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
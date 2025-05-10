using System;

class Program
{
    static void Main()
    {
        Console.Write("Длина стола a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Ширина стола b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Длина прямоугольника c: ");
        int c = int.Parse(Console.ReadLine());
        Console.Write("Ширина прямоугольника d: ");
        int d = int.Parse(Console.ReadLine());

        int alongLong = (a / c) * (b / d);
        int alongShort = (a / d) * (b / c);

        if (alongLong > alongShort)
            Console.WriteLine("Больше при размещении вдоль длинной стороны стола.");
        else if (alongLong < alongShort)
            Console.WriteLine("Больше при размещении вдоль короткой стороны стола.");
        else
            Console.WriteLine("В обоих случаях — одинаково.");
    }
}

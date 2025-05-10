using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Первый прямоугольник:");
        Console.Write("x1 = "); double x1 = double.Parse(Console.ReadLine());
        Console.Write("y1 = "); double y1 = double.Parse(Console.ReadLine());
        Console.Write("w1 = "); double w1 = double.Parse(Console.ReadLine());
        Console.Write("h1 = "); double h1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Второй прямоугольник:");
        Console.Write("x2 = "); double x2 = double.Parse(Console.ReadLine());
        Console.Write("y2 = "); double y2 = double.Parse(Console.ReadLine());
        Console.Write("w2 = "); double w2 = double.Parse(Console.ReadLine());
        Console.Write("h2 = "); double h2 = double.Parse(Console.ReadLine());

        double r1x2 = x1 + w1, r1y2 = y1 + h1;
        double r2x2 = x2 + w2, r2y2 = y2 + h2;

        bool firstInSecond = x1 >= x2 && y1 >= y2 && r1x2 <= r2x2 && r1y2 <= r2y2;
        bool secondInFirst = x2 >= x1 && y2 >= y1 && r2x2 <= r1x2 && r2y2 <= r1y2;
        bool intersect = !(r1x2 < x2 || r2x2 < x1 || r1y2 < y2 || r2y2 < y1);

        Console.WriteLine($"Первый внутри второго: {firstInSecond}");
        Console.WriteLine($"Второй внутри первого: {secondInFirst}");
        Console.WriteLine($"Есть пересечение: {intersect}");
    }
}

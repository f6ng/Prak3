using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите x (в радианах): ");
        double x = double.Parse(Console.ReadLine());
        double y = x > 0 ? Math.Sin(x) : Math.Cos(x);
        Console.WriteLine($"y = {y}");
    }
}

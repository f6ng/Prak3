using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите A: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Введите B: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Введите C: ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("Введите D: ");
        double d = double.Parse(Console.ReadLine());

        double max = a;
        if (b > max) max = b;
        if (c > max) max = c;
        if (d > max) max = d;

        double min = a;
        if (b < min) min = b;
        if (c < min) min = c;
        if (d < min) min = d;

        Console.WriteLine($"Наибольшее число: {max}");
        Console.WriteLine($"Наименьшее число: {min}");
    }
}

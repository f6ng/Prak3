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

        double max = a;
        if (b > max) max = b;
        if (c > max) max = c;

        double min = a;
        if (b < min) min = b;
        if (c < min) min = c;

        Console.WriteLine($"Наибольшее число: {max}");
        Console.WriteLine($"Наименьшее число: {min}");
    }
}

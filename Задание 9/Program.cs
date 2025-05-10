using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");
        double b = double.Parse(Console.ReadLine());

        double max = Math.Max(a, b);
        double min = Math.Min(a, b);
        Console.WriteLine($"Максимальное значение: {max}");
        Console.WriteLine($"Минимальное значение: {min}");
    }
}

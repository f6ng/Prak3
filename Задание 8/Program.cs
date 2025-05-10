using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");
        double b = double.Parse(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine($"Большее число: {a}");
            Console.WriteLine($"Меньшее число: {b}");
        }
        else
        {
            Console.WriteLine($"Большее число: {b}");
            Console.WriteLine($"Меньшее число: {a}");
        }
    }
}

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите скорость в км/ч: ");
        double kmh = double.Parse(Console.ReadLine());
        Console.Write("Введите скорость в м/с: ");
        double ms = double.Parse(Console.ReadLine());

        double msFromKmh = kmh * 1000 / 3600;

        if (msFromKmh > ms)
            Console.WriteLine("Скорость в км/ч больше.");
        else if (msFromKmh < ms)
            Console.WriteLine("Скорость в м/с больше.");
        else
            Console.WriteLine("Скорости равны.");
    }
}

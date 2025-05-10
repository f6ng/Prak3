using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите расстояние в километрах: ");
        double km = double.Parse(Console.ReadLine());
        Console.Write("Введите расстояние в футах: ");
        double ft = double.Parse(Console.ReadLine());

        double mFromKm = km * 1000;
        double mFromFt = ft * 0.305;

        if (mFromKm < mFromFt)
            Console.WriteLine("Километровое расстояние меньше.");
        else if (mFromKm > mFromFt)
            Console.WriteLine("Расстояние в футах меньше.");
        else
            Console.WriteLine("Расстояния равны.");
    }
}

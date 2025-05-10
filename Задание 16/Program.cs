using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите число b: ");
        int b = int.Parse(Console.ReadLine());

        bool aDividesB = b % a == 0;
        bool bDividesA = a % b == 0;

        Console.WriteLine($"a является делителем b: {aDividesB}");
        Console.WriteLine($"b является делителем a: {bDividesA}");
    }
}

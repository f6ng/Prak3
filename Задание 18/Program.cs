using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите год: ");
        int year = int.Parse(Console.ReadLine());
        bool isLeap = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        Console.WriteLine(isLeap ? "Високосный год" : "Невисокосный год");
    }
}

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите k (1–365): ");
        int k = int.Parse(Console.ReadLine());

        // a) 1 января — понедельник
        int wd1 = (k - 1) % 7 + 1;  // 1=пн, …, 6=сб, 7=вс
        Console.WriteLine(wd1 >= 6 ? "Выходной" : "Рабочий");

        // b) вводим, каким днем недели был 1 января (1=пн,…,7=вс)
        Console.Write("Введите d (день недели для 1 января, 1–7): ");
        int d = int.Parse(Console.ReadLine());
        int wd2 = (d - 1 + (k - 1)) % 7 + 1;
        Console.WriteLine(wd2 >= 6 ? "Выходной" : "Рабочий");
    }
}

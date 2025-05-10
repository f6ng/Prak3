using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите месяц (1–12) и день (1–31) через пробел: ");
        var p = Console.ReadLine().Split();
        int m = int.Parse(p[0]), d = int.Parse(p[1]);
        int[] dm = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        // предыдущая
        int pm = d > 1 ? m : m - 1;
        int pd = d > 1 ? d - 1 : dm[m - 2];
        // следующая
        int nm = d < dm[m - 1] ? m : m + 1;
        int nd = d < dm[m - 1] ? d + 1 : 1;

        Console.WriteLine($"Предыдущая дата: {pd}.{pm}");
        Console.WriteLine($"Следующая дата: {nd}.{nm}");

        Console.WriteLine("Нажмите любую клавишу...");
        Console.ReadKey();
    }
}

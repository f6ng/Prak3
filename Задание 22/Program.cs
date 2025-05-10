using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите месяц m (1–12): ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Введите число n: ");
        int n = int.Parse(Console.ReadLine());

        int[] daysInMonth = {
            31,28,31,30,31,30,31,31,30,31,30,31
        };

        // предыдущий день
        int pm = m, pn = n - 1;
        if (pn == 0)
        {
            pm = m - 1;
            pn = daysInMonth[pm - 1];
        }

        // следующий день
        int nm = m, nn = n + 1;
        if (nn > daysInMonth[m - 1])
        {
            nn = 1;
            nm = m + 1;
        }

        Console.WriteLine($"Предыдущая дата: {pn}.{pm}");
        Console.WriteLine($"Следующая дата:  {nn}.{nm}");
    }
}

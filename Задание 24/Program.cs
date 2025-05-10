using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите номер масти (1–4): ");
        if (!int.TryParse(Console.ReadLine(), out int m) || m < 1 || m > 4)
        {
            Console.WriteLine("Ошибка: масть должна быть от 1 до 4.");
            return;
        }

        Console.Write("Введите достоинство карты (6–14): ");
        if (!int.TryParse(Console.ReadLine(), out int k) || k < 6 || k > 14)
        {
            Console.WriteLine("Ошибка: достоинство должно быть от 6 до 14.");
            return;
        }

        // Массивы соответствий мастей и достоинств
        string[] suits = { "пик", "треф", "бубен", "червей" };
        string[] ranks = {
            "Шестерка", "Семерка", "Восьмерка", "Девятка", "Десятка",
            "Валет", "Дама", "Король", "Туз"
        };

        // Вывод полного названия карты
        Console.WriteLine($"{ranks[k - 6]} {suits[m - 1]}");
    }
}

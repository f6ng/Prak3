using System;

class Program
{
    static void Main()
    {
        Console.Write("Сколько месяцев прошло с начала 1990 года (n): ");
        if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
        {
            var names = new[]
            {
                "январь","февраль","март","апрель","май","июнь",
                "июль","август","сентябрь","октябрь","ноябрь","декабрь"
            };
            // 1 января 1990 + n месяцев + 2 дня
            var dt = new DateTime(1990, 1, 1).AddMonths(n).AddDays(2);
            Console.WriteLine($"Название месяца: {names[dt.Month - 1]}");
        }
        else
        {
            Console.WriteLine("Ошибка: введите неотрицательное целое число.");
        }
    }
}

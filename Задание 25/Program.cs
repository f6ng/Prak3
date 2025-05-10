using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите k (1–365) и d (1–7) через пробел (для пункта а) d можно не указывать): ");
        var parts = Console.ReadLine()?.Split();
        if (parts == null
            || parts.Length < 1
            || !int.TryParse(parts[0], out int k) || k < 1 || k > 365
            || (parts.Length > 1 && (!int.TryParse(parts[1], out int d) || d < 1 || d > 7)))
        {
            Console.WriteLine("Ошибка ввода.");
            return;
        }

        // День недели 1=понедельник,…,7=воскресенье
        int dVal = parts.Length > 1 ? int.Parse(parts[1]) : 1;
        var days = new[]
        {
            "понедельник", "вторник", "среда",
            "четверг",    "пятница", "суббота", "воскресенье"
        };

        // а) если 1 января — понедельник (d=1)
        Console.WriteLine($"a) {days[(k - 1) % 7]}");

        // б) если 1 января — d-й день недели
        Console.WriteLine($"б) {days[((dVal - 1) + (k - 1)) % 7]}");
    }
}

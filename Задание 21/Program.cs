using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество полных месяцев n с начала 1990 года: ");
        int n = int.Parse(Console.ReadLine());
        // Январь — месяц 1, февраль 2, …, декабрь 12
        int month = (1 + n) % 12;
        if (month == 0) month = 12;

        string[] names = {
            "Январь","Февраль","Март","Апрель","Май","Июнь",
            "Июль","Август","Сентябрь","Октябрь","Ноябрь","Декабрь"
        };
        Console.WriteLine($"Название месяца: {names[month - 1]}");
    }
}

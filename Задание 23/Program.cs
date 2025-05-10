using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите порядковый номер карты (6–14): ");
        if (!int.TryParse(Console.ReadLine(), out int k) || k < 6 || k > 14)
        {
            Console.WriteLine("Ошибка: введите целое число от 6 до 14.");
            return;
        }

        string rank;
        switch (k)
        {
            case 6:
                rank = "шестерка";
                break;
            case 7:
                rank = "семерка";
                break;
            case 8:
                rank = "восьмерка";
                break;
            case 9:
                rank = "девятка";
                break;
            case 10:
                rank = "десятка";
                break;
            case 11:
                rank = "валет";
                break;
            case 12:
                rank = "дама";
                break;
            case 13:
                rank = "король";
                break;
            case 14:
                rank = "туз";
                break;
            default:
                // Этот блок никогда не выполнится из-за проверки выше
                rank = "неизвестная карта";
                break;
        }

        Console.WriteLine($"Достоинство карты: {rank}");
    }
}

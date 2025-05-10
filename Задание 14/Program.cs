using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число: ");
        int n = int.Parse(Console.ReadLine());
        int last = n % 10;
        bool endsEven = last % 2 == 0;
        bool endsOdd = last % 2 != 0;

        Console.WriteLine($"Заканчивается четной цифрой: {endsEven}");
        Console.WriteLine($"Заканчивается нечетной цифрой: {endsOdd}");
    }
}

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите целое число A: ");
        int A = int.Parse(Console.ReadLine());
        bool condA1 = A % 2 == 0 || A % 3 == 0;
        Console.WriteLine($"A кратно 2 или 3: {condA1}");
        bool condA2 = A % 3 != 0 && A % 10 == 0;
        Console.WriteLine($"A не кратно 3 и оканчивается нулем: {condA2}");

        Console.Write("Введите целое число N: ");
        int N = int.Parse(Console.ReadLine());
        bool condN1 = N % 5 == 0 || N % 7 == 0;
        Console.WriteLine($"N кратно 5 или 7: {condN1}");
        bool condN2 = N % 4 == 0 && N % 10 != 0;
        Console.WriteLine($"N кратно 4 и не оканчивается нулем: {condN2}");
    }
}

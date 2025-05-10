using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("A\tB\tA && B\tA || B\t!A");
        bool[] vals = { false, true };
        foreach (bool A in vals)
        {
            foreach (bool B in vals)
            {
                Console.WriteLine($"{A}\t{B}\t{(A && B)}\t{(A || B)}\t{(!A)}");
            }
        }
    }
}

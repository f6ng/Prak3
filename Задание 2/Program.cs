using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("A\tB\t!(!A && !B) && A\t!(!A || !B) || A\t!(!A || !B) && B");
        bool[] vals = { false, true };
        foreach (bool A in vals)
            foreach (bool B in vals)
            {
                bool expr1 = !(!A && !B) && A;
                bool expr2 = !(!A || !B) || A;
                bool expr3 = !(!A || !B) && B;
                Console.WriteLine($"{A}\t{B}\t{expr1}\t\t{expr2}\t\t{expr3}");
            }
    }
}

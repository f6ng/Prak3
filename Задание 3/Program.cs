using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("A\tB\tC\t1\t2\t3\t4\t5\t6");
        bool[] vals = { false, true };
        foreach (bool A in vals)
            foreach (bool B in vals)
                foreach (bool C in vals)
                {
                    bool e1 = !(A || (!B && C));
                    bool e2 = A && !((B && A) || !C);
                    bool e3 = !(!A || (B && C));
                    bool e4 = e1 || C;
                    bool e5 = !((A && !B) || C) && B;
                    bool e6 = e3 || A;
                    Console.WriteLine($"{A}\t{B}\t{C}\t{e1}\t{e2}\t{e3}\t{e4}\t{e5}\t{e6}");
                }
    }
}

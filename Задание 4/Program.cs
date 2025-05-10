using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("X\tY\tX||Y\tX&&Y\tX->Y\tX==Y");
        bool[] vals = { false, true };
        foreach (bool X in vals)
            foreach (bool Y in vals)
            {
                bool or = X || Y;
                bool and = X && Y;
                bool impl = !X || Y;   // X → Y
                bool eq = X == Y;    // X ≡ Y
                Console.WriteLine($"{X}\t{Y}\t{or}\t{and}\t{impl}\t{eq}");
            }
    }
}

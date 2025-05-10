using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("X\tY\tZ\ta\tb\tc\tg\td\te\tzh\tz");
        bool[] v = { false, true };
        foreach (bool X in v)
            foreach (bool Y in v)
                foreach (bool Z in v)
                {
                    bool a = !(X || Y) || (Y == X);                       // (X ∨ Y) → (Y ≡ X)
                    bool b = (X || Y) == (Y && X);                       // (X ∨ Y) ≡ (Y ∧ X)
                    bool c = (X && Y) || (!Y || X);                      // (X ∧ Y) ∨ (Y → X)
                    bool g = !(X == Y) || Y;                             // (X ≡ Y) → Y
                    bool d = !(X || Y) || (Z == X);                      // (X ∨ Y) → (Z ≡ X)
                    bool e = (X == (Z || Y)) || ((!X || Z) && (!Y || X)); // (X ≡ (Z ∨ Y)) ∨ ((X→Z) ∧ (Y→X))
                    bool zh = !Y || (Z == X);                             // Y → (Z ≡ X)
                    bool z = X == (!Y || Z);                            // X ≡ (Y → Z)
                    Console.WriteLine($"{X}\t{Y}\t{Z}\t{a}\t{b}\t{c}\t{g}\t{d}\t{e}\t{zh}\t{z}");
                }
    }
}

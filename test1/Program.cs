namespace Задание_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Таблица истинности для базовых операций:");
            Console.WriteLine("| A     | B     | A && B | A || B | !A    |");
            Console.WriteLine("|-------|-------|--------|--------|-------|");

            bool[] values = { false, true };
            foreach (bool a in values)
            {
                foreach (bool b in values)
                {
                    Console.WriteLine($"| {a,-5} | {b,-5} | {a && b,-6} | {a || b,-6} | {!a,-5} |");
                }
            }

            Console.WriteLine("\nВычисление сложных логических выражений:");

            Console.Write("Введите значение A (true/false): ");
            bool A = bool.Parse(Console.ReadLine());

            Console.Write("Введите значение B (true/false): ");
            bool B = bool.Parse(Console.ReadLine());


            bool resultA = !(!A && !B) && A;
            bool resultB = !(!A || !B) || A;
            bool resultC = !(!A || !B) && B;


            Console.WriteLine($"\na) не (не {A} и не {B}) и {A} = {resultA}");
            Console.WriteLine($"б) не (не {A} или не {B}) или {A} = {resultB}");
            Console.WriteLine($"в) не (не {A} или не {B}) и {B} = {resultC}");


            Console.WriteLine("\nТаблица истинности для всех выражений:");
            Console.WriteLine("| A     | B     | Выражение a | Выражение б | Выражение в |");
            Console.WriteLine("|-------|-------|-------------|-------------|-------------|");

            foreach (bool a in values)
            {
                foreach (bool b in values)
                {
                    bool ra = !(!a && !b) && a;
                    bool rb = !(!a || !b) || a;
                    bool rc = !(!a || !b) && b;

                    Console.WriteLine($"| {a,-5} | {b,-5} | {ra,-11} | {rb,-11} | {rc,-11} |");
                }
            }
        }
    }
}
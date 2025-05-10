namespace задание_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите число b: ");
            int b = int.Parse(Console.ReadLine());


            if (a == 0 || b == 0)
            {
                Console.WriteLine("Ошибка: числа не должны быть равны нулю!");
                return;
            }


            bool isADivisorOfB = b % a == 0;
            Console.WriteLine($"а) {a} является делителем {b}: {isADivisorOfB}");


            bool isBDivisorOfA = a % b == 0;
            Console.WriteLine($"б) {b} является делителем {a}: {isBDivisorOfA}");

        }
    }
}

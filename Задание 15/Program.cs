using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите радиус круга R: ");
        double R = double.Parse(Console.ReadLine());
        Console.Write("Введите сторону квадрата a: ");
        double a = double.Parse(Console.ReadLine());

        double areaCircle = Math.PI * R * R;
        double areaSquare = a * a;

        if (areaCircle > areaSquare)
            Console.WriteLine("Площадь круга больше.");
        else if (areaCircle < areaSquare)
            Console.WriteLine("Площадь квадрата больше.");
        else
            Console.WriteLine("Площади равны.");
    }
}

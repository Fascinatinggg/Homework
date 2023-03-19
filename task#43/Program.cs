/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)*/

static double CalculateD(double k1, double k2)
{
    return k1 * (-1) * k2;
}

static (double, double) CalculateCoefficients(double b1, double k1, double b2, double k2)
{
    double d1 = b1 * (-1) - b2 * (-1) * k1 / k2;
    double d2 = k1 * (-1) * b2 - k2 * (-1) * b1;
    double e1 = k1 * (-1);
    double e2 = k2 * (-1);
    double a1 = (-1);
    double a2 = (-1) * k2 / k1;
    double f1 = b1 * (-1);
    double f2 = b2 * (-1);

    double D = CalculateD(k1, k2);

    double x = (d1 * e2 - d2 * e1) / D;
    double y = (a1 * f2 - a2 * f1) / D;

    return (x, y);
}

static void Main(string[] args)
{
    Console.Write("Enter b1: ");
    double b1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter k1: ");
    double k1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter b2: ");
    double b2 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter k2: ");
    double k2 = Convert.ToDouble(Console.ReadLine());

    double D = CalculateD(k1, k2);

    if (D == 0)
    {
        Console.WriteLine("No solution");
    }
    else
    {
        var (x, y) = CalculateCoefficients(b1, k1, b2, k2);
        Console.WriteLine($"({x}; {y})");
    }
}

/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/

void Data()
{
    Console.Write("Enter the number = ");
    int a = Convert.ToInt32(Console.ReadLine());

    int result = Calculating(a);
    Console.WriteLine($"Result = {result}");
}

int Calculating(int a)
{
    int sum = 0;
    while (a > 0)
    {
        sum += a % 10;
        a /= 10;
    }
    return sum;
}

Data();
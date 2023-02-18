// Задача 10: Напишите программу, которая принимает на вход трёхзначное
// число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Enter number ");

int n = Convert.ToInt32(Console.ReadLine());
if (n >= 100 && n <= 999)
{
    n = n / 10;
    Console.WriteLine(n);
    n = n % 10;
    Console.WriteLine(n);
}

else
{
    Console.Write("Wrong number, enter 3-digit number");
}



/*Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом. Через строку решать нельзя.

14212 -> нет

12821 -> да

23432 -> да*/

Console.Write("Enter the number = ");
int n = Convert.ToInt32(Console.ReadLine());

while (n <= 9999 || n >= 100000)
{
    Console.Write("Wrong data, enter 5 digit number = ");
    n = Convert.ToInt32(Console.ReadLine());
}

int x = n;
int y = 0;

while (n > 0)
{
    int u = n % 10;
    y = y * 10 + u;
    n /= 10;
}

if (x == y)
{
    Console.WriteLine($"Yes, number {x} is palindrome");
}
else
{
    Console.WriteLine($"No, number {x} isn't palindrome");
}

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//  и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Enter number = "); //просим ввести число
int n = int.Parse(Console.ReadLine()); //вводим

int a = 1, b = 2, c = 3, d = 4, e = 5, f = 6, g = 7; //вводим переменные, для них будем создавать условия

if ( n == 6 || n == 7) //создаём условие, "||" в с# "or" 
{
    Console.WriteLine($"{n} - Yes");
}
else if (n == 1 || n == 2 ||n == 3 || n == 4 || n == 5)
{
    Console.WriteLine($"{n} - No");
}
else 
{
    Console.WriteLine ("Entered wrong number. Please enter a day from 1 to 7");
}
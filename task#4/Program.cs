//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

int a, b, c;

Console.Write ("Enter number a = ");
a = int.Parse(Console.ReadLine ());
Console.Write ("Enter number b = "); 
b = int.Parse(Console.ReadLine ()); 
Console.Write ("Enter number c = ");
c = int.Parse(Console.ReadLine ());

if ( a > b & a > c)
{
    Console.WriteLine ("Max = a");
}
if ( b > a & b > c)
{
    Console.WriteLine ("Max = b");
}
if ( c > a & c > b)
{
    Console.WriteLine ("Max = c");
}


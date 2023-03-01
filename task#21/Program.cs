/*Задача 21

Напишите программу, которая принимает на вход координаты
двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B(2, 1, -7), -> 15.84

A(7, -5, 0); B(1, -1, 9)-> 11.53*/

Console.WriteLine("Hello, enter coordinates below:");
Console.Write("Enter x1 coordinate = ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter x2 coordinate = ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter y1 coordinate = ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter y2 coordinate = ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter u1 coordinate = ");
int u1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter u2 coordinate = ");
int u2 = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(u2 - u1, 2));
Console.WriteLine($"The distance is = {distance}");

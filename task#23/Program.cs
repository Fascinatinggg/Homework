﻿/*Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.Write("Enter the number = ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (i <= n)
{
    int square = (int)Math.Pow(i, 2);
    Console.WriteLine(square);
    i++;
}

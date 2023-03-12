
/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 999);
}

void PrintArray(int[] array)
{
    foreach(var el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}

int FindEven(int[] array)
{
    int even = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            even++;
    if (even == 0)
            Console.WriteLine("No even digits in the array");
    return even;
}

int[] array = new int[12];
FillArray(array);
PrintArray(array);
FindEven(array);
int countEven = FindEven(array);
Console.WriteLine($"Even numbers in the array is = {countEven}");


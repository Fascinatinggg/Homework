/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6]-> 0*/

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-10, 100);
}

void PrintArray(int[] array)
{
    foreach (var el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}

int OddPositions(int[] array)
{
    int odd = 0;
    for (int i = 0; i < array.Length; i++)
        if (i % 2 != 0)
            odd += array[i];
    if (odd == 0)
        Console.WriteLine("No odd digits in the array");
    return odd;
}

int[] array = new int[5];
FillArray(array);
PrintArray(array);
OddPositions(array);
int OddSum = OddPositions(array);
Console.WriteLine($"Odd sum in the array is = {OddSum}");
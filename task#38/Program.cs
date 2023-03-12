/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 100);
}

void PrintArray(int[] array)
{
    foreach (var el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}

int FindDiff(int[] array)
{
    int max = array[0];
    int min = array[0];
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
        else if (array[i] < min)
            min = array[i];
    }
    sum = max - min;
    return sum;
}

int[] array = new int[5];
FillArray(array);
PrintArray(array);
FindDiff(array);
int diffsum = FindDiff(array);
Console.Write($"The difference between min and max = {diffsum}");
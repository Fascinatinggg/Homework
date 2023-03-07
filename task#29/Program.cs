/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33-> [6, 1, 33]
*/

void PrintArray(int[] array)
{
    Console.WriteLine(string.Join(" ", array));
}

int[] GenerateArray(int length)
{
    int[] array = new int[length];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 100);
    }

    return array;
}

PrintArray(GenerateArray(8));

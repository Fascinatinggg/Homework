/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3*/


int NumbersCount(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
        {
            count++;
        }
    }
    return count;
}

void ELementsCount()
{
    Console.Write("Enter the number of elements: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Enter number {i + 1}: ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
    int count = NumbersCount(numbers);
    Console.WriteLine(count);
}

ELementsCount();



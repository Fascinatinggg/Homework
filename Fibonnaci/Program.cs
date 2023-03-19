/*5.Задайте число.Составьте список чисел НегаФибоначчи, в
том числе для отрицательных индексов.

*Пример:*

-для k = 8 список будет выглядеть 
так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]*/

void PrintNegafibonacci(int n)
{
    int[] negafibonacci = new int[n];

    int sign = -1;
    for (int i = n - 1; i >= 0; i--)
    {
        negafibonacci[i] = sign * Fibonacci(Math.Abs(i) - 1);
        sign *= -1;
    }

    foreach (var el in negafibonacci)
    {
        Console.Write($"{el} ");
    }
}

int Fibonacci(int n)
{
    if (n == 0)
    {
        return 0;
    }
    else if (n == 1)
    {
        return 1;
    }
    else
    {
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}

Console.Write("Enter the number = ");
int n = Convert.ToInt32(Console.ReadLine());

PrintNegafibonacci(n);

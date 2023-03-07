/*Задача 25: Напишите цикл, который принимает на вход два числа 
(A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4-> 16*/

void DataReading()
{
    Console.Write("Enter the number A = ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the number B = ");
    int b = Convert.ToInt32(Console.ReadLine());

    double result = Calculating(a,b);
    Console.WriteLine($"Result = {result}");
}

double Calculating(int a, int b)
{
    double result = 1;
    for (int i = 0; i < b; i++)
    {
        result *= a;
    }
    return result;
}

DataReading();
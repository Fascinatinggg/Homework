﻿// В институте биоинформатики по офису передвигается робот. 
// Недавно студенты из группы программистов написали для него программу, по которой робот, когда заходит в комнату, 
// считает количество программистов в ней и произносит его вслух: "n программистов".
// Для того, чтобы это звучало правильно, для каждого n нужно использовать верное окончание слова.
// Напишите программу, считывающую с пользовательского ввода целое число n (неотрицательное), 
// выводящее это число в консоль вместе с правильным образом изменённым словом "программист", 
// для того, чтобы робот мог нормально общаться с людьми, например: 1 программист, 2 программиста, 5 программистов.
// В комнате может быть очень много программистов. Проверьте, что ваша программа правильно обработает все случаи,
// как минимум до 1000 человек.

Console.Write("Enter number = ");

int n = int.Parse(Console.ReadLine());
while (n <= 0)
{
    Console.Write("Wrong number, enter a positive value = ");
    n = int.Parse(Console.ReadLine());
}

if (n % 10 == 1)
{
    Console.WriteLine($"{n} программист");
}

else if (n % 10 == 2 || n % 10 == 3 || n % 10 == 4)
{
    Console.WriteLine($"{n} программиста");
}

else if (n % 10 == 0 || n % 10 == 5 || n % 10 == 6 || n % 10 == 7 || n % 10 == 8 || n % 10 == 9)
{
    Console.WriteLine($"{n} программистов");
}
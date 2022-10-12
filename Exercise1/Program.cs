/*
Задание №1.
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.Write("Введите первое число:");
int NumberOne = int.Parse(Console.ReadLine());
Console.Write("Введите второе число:");
int NumberTwo = int.Parse(Console.ReadLine());
if (NumberOne > NumberTwo)
    Console.Write($"max= {NumberOne} min= {NumberTwo}");
else
    Console.Write($"max= {NumberTwo} min= {NumberOne}");
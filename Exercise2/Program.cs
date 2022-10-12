/*
Задание 2
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.Write("Введите первое число:");
int NumberOne = int.Parse(Console.ReadLine());
Console.Write("Введите второе число:");
int NumberTwo = int.Parse(Console.ReadLine());
Console.Write("Введите третье число:");
int NumberThree = int.Parse(Console.ReadLine());
int max = 0;
if (NumberOne < NumberTwo)
    max = NumberTwo;
if (NumberTwo < NumberThree)
    max = NumberThree;
if (NumberOne < NumberThree)
    max = NumberThree;
else
    max = NumberOne;
Console.Write($"Максимальное число {max}");
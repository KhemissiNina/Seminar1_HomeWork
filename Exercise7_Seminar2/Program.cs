/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());
while (number>1000)
        number = number/10;
    if (number>99)
        Console.WriteLine(number=number%10);
else
    Console.WriteLine("Третьей цифры нет");
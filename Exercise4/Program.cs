/*
Задание 8
Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Write("Введите число:");
int Number=int.Parse(Console.ReadLine());
int cycle=2;
while (cycle < Number+1)
{
      Console.WriteLine(cycle);
      cycle=cycle+2;
}
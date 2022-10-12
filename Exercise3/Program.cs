/* Задание 3
Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два б
ез остатка).
4 -> да
-3 -> нет
7 -> нет
*/
Console.Write("Введите число:");
int Number= int.Parse(Console.ReadLine());
int ostatok = Number%2;
if (ostatok == 0)
   Console.WriteLine($"Число {Number} является четным");
else
   Console.WriteLine($"Число {Number} является нечетным");
/*
Проверить, делится ли первое число на второе без остатка
*/
Console.WriteLine("Введите первое число:");
int FirstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int SecondNumber = int.Parse(Console.ReadLine());
if (SecondNumber%FirstNumber!=0)
    Console.WriteLine($"Остаток от деления {SecondNumber} на {FirstNumber} равен: {SecondNumber%FirstNumber}");
else
    Console.WriteLine($"{SecondNumber} делится на {FirstNumber} без остатка");

//Напишите программу, которая на входе принимает два числа и проверяет, являетмя ли  второе число квадратом пераого	
Console.Write("Введите первое число:");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число:");
int number2 = int. Parse(Console.ReadLine());
if (number2==number1*number1) Console.WriteLine($"Второе число {number2} является квадратом первого числа {number1}");
else Console.WriteLine($"Второе число {number2} не является квадратом первого числа {number1}");

//Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
Console.Write("Введите число:");
int number = int.Parse(Console.ReadLine());
int count=number*(-1);
while (count<number)
{
    Console.WriteLine(count);
    count++;
}
Console.WriteLine(number);
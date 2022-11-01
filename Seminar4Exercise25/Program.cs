//Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Сделать в функции, сделать проверку на отрицательность.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
Console.Clear();
Console.Write("Введите число А: ");
int a = int.Parse(Console.ReadLine());
Console.Write($"Введите натуральное число B (степень, в которую будем возводить число {a}: )");
int b = int.Parse(Console.ReadLine());
//функция
void Stepen (int a, int b)
{
	if (b<0) {
		Console.Write("Отрицательные числа к натуральным не относятся");
	}
	else 
	Console.WriteLine($"{a}^{b} = " + Math.Pow(a, b));
}
Stepen (a,b);
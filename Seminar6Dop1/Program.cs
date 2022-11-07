//Дано действительное положительное число a и целое неотрицательное число n. Вычислите an не используя циклы, возведение в степень через ** и функцию math.pow(), а используя рекуррентное соотношение an=a⋅an-1.
//Решение оформите в виде функции power(a, n).

int Power(int a, int n)
{
    if (n == 0) return 1;
    return a * Power(a, n - 1);
}
Console.Clear();
Console.Write("Введите действительное положительное число: ");
int a = int.Parse(Console.ReadLine());
//int a=3;
Console.Write($"Введите целое неотрицательное число - степень в которую будем возводить число {a}: ");
int n = int.Parse(Console.ReadLine());

//int n=2;
Console.WriteLine($"{a} в степени {n} равно {Power(a, n)}");
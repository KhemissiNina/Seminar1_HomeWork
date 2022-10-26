// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8,27.
//5 -> 1, 8, 27, 64, 125
Console.Clear();
void Tri(int N)
{
    int i = 1;
    while (i <= N)
    {
        int K = i * i * i;
        Console.WriteLine($"{K} куб числа {i}");
        i++;
    }
}
Console.WriteLine("Введите число:");
int n = int.Parse(Console.ReadLine());
Tri(n);
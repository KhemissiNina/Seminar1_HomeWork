// Заполнить двумерный массив следующим образом. Вводится число n
Console.Clear();
Console.WriteLine("Ввeдите число столбцов и строк");
int number = int.Parse(Console.ReadLine());
int[,] array = new int[number, number];

for (int i = 0; i < number; i++)
{
    for (int j = 0; j < number; j++)
    {
        if (i >= j) array[i, j] = j + 1;
        else array[i, j] = i + 1;
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
//задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1 7 -> такого числа в массиве нет
//1 2 -> под данным номером стоит число 2

Console.Clear();
int[,] FillArray()
{
    Console.Write("Введите число строк массива: ");
    int stroka = int.Parse(Console.ReadLine());
    Console.Write("Введите число столбцов массива: ");
    int stolbec = int.Parse(Console.ReadLine());
    Console.Write("Введите диапазон случайных чисел от: ");
    int start = int.Parse(Console.ReadLine());
    Console.Write("                                 до: ");
    int stop = int.Parse(Console.ReadLine());
    int[,] array = new int[stroka, stolbec];

    for (int i = 0; i < stroka; i++)
    {
        for (int j = 0; j < stolbec; j++)
        {
            array[i, j] = new Random().Next(start, stop);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    return array;
}

void FoundNumber(int[,] array)
{
    Console.Write("Введите номер строки массива: ");
    int l = int.Parse(Console.ReadLine());
    Console.Write("Введите номер столбца массива: ");
    int k = int.Parse(Console.ReadLine());
    if (l > array.GetLength(0)-1 || k > array.GetLength(1)-1) Console.Write("Такого числа не существует");
    else
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (i == l && j == k)
                {
                    Console.Write($"Искомое число {array[i, j]}");
                }
            }
        }
}

FoundNumber(FillArray());
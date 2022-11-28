//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void MeanAriphmetic(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double summa = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            summa += array[i, j];
        }
        //double dlina=array.GetLength(0);
        // Console.WriteLine(dlina);
        //double meanNumber=summa/dlina;
        Console.WriteLine($"Среднеарифметическое чисел {j + 1} столбца равна {Math.Round(summa / array.GetLength(0), 1)}");
    }
}

MeanAriphmetic(FillArray());
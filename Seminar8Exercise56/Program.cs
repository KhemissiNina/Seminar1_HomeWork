//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
void FillList(List<List<double>> mylist)
{
    Console.Write("Введите число строк массива: ");
    int stroka = int.Parse(Console.ReadLine());
    Console.Write("Введите число столбцов массива: ");
    int stolbec = int.Parse(Console.ReadLine());
    Console.Write("Введите диапазон случайных чисел до: ");
    int stop = int.Parse(Console.ReadLine());
    for (int i = 0; i < stroka; i++)
    {
        mylist.Add(new List<double>());
        for (int j = 0; j < stolbec; j++)
        {
            mylist[i].Add(Math.Round(new Random().NextDouble() * stop));
        }
    }
}

void PrintList(List<List<double>> mylist)
{
    for (int i = 0; i < mylist.Count; i++)
    {
        for (int j = 0; j < mylist[i].Count; j++)
        {
            Console.Write(mylist[i][j] + " ");
        }
        Console.WriteLine();
    }
}


void SummaStrok(List<List<double>> mylist)
{
    double max = 0;
    for (int i = 0; i < mylist.Count; i++)
    {
        double sum = 0;
        for (int j = 0; j < mylist[i].Count; j++)
        {
            sum += mylist[i][j];
            if (sum > max) max = sum;
        }
        Console.WriteLine($"сумма {i + 1} строки равна {sum}");
    }

    int indexStroki = 0;
    double min = max;
    for (int i = 0; i < mylist.Count; i++)
    {
        double sum = 0;
        for (int j = 0; j < mylist[i].Count; j++)
        {
            sum += mylist[i][j];
        }
        if (sum < min)
        {
            min = sum;
            indexStroki = i;
        }
    }
    Console.WriteLine($"{indexStroki + 1} строка имеет наименьшую сумму {min}");


}

List<List<double>> numbers = new List<List<double>>();
FillList(numbers);
PrintList(numbers);
SummaStrok(numbers);
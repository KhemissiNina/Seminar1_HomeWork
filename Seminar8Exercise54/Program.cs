//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

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


void Perebor(List<List<double>> mylist)
{
    for (int i = 0; i < mylist.Count; i++)
    {
        for (int j = 0; j < mylist[i].Count; j++)
        {
            //List<int> list = new List<int>();
            mylist[i].Sort();
            mylist[i].Reverse();
        }
    }
}

List<List<double>> numbers = new List<List<double>>();
FillList(numbers);
PrintList(numbers);
Perebor(numbers);
Console.WriteLine();
PrintList(numbers);
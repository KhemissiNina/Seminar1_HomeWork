//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

Console.Clear();
int[,] FillArray(int[,] array)
{
    Console.Write("Введите диапазон случайных чисел от: ");
    int start = int.Parse(Console.ReadLine());
    Console.Write("                                 до: ");
    int stop = int.Parse(Console.ReadLine());

    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            array[i, j] = new Random().Next(start, stop);
            //Console.Write($"{array[i, j]} ");
        }
        // Console.WriteLine();
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            Console.Write("{0}\t", array[i, j]);
        }
        Console.WriteLine();
    }
}

int[,] SumArray(int[,] array1, int[,] array2)
//1-->0
//2-->1
{
    int[,] resultArray = {{(array1[0,0]*array2[0,0]+array1[0,1]*array2[1,0]),(array1[0,0]*array2[0,1]+array1[0,1]*array2[1,1])},
                          {(array1[1,0]*array2[0,0]+array1[1,1]*array2[1,0]),(array1[1,0]*array2[0,1]+array1[1,1]*array2[1,1])}};

    return resultArray;
}

int[,] array1 = new int[2, 2];
int[,] array2 = new int[2, 2];
Console.WriteLine("Первая матрица");
FillArray(array1);
PrintArray(array1);
Console.WriteLine("Вторая матрица");
FillArray(array2);
PrintArray(array2);
Console.WriteLine("Результирующая матрица");
PrintArray(SumArray(array1, array2));
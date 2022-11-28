//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

Console.Clear();
int[,] FillArray(int[,] array)
{
    int count = 0;

    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            array[i, j] = count + 1;
            count++;
        }
    }

    for (int i = 1; i < 4; i++)
    {
        for (int j = 3; j < 4; j++)
        {
            array[i, j] = count + 1;
            count++;
        }
    }

    for (int i = 3; i < 4; i++)
    {
        for (int j = 2; j >= 0; j--)
        {
            array[i, j] = count + 1;
            count++;
        }
    }

    for (int i = 2; i > 0; i--)
    {
        for (int j = 0; j < 1; j++)
        {
            array[i, j] = count + 1;
            count++;
        }
    }

    for (int i = 1; i < 2; i++)
    {
        for (int j = 1; j < 3; j++)
        {
            array[i, j] = count + 1;
            count++;
        }
    }

    for (int i = 2; i < 3; i++)
    {
        for (int j = 2; j >0; j--)
        {
            array[i, j] = count + 1;
            count++;
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            Console.Write("{0}\t", array[i, j]);
        }
        Console.WriteLine();
    }
}

int[,] array = new int[4, 4];
FillArray(array);
PrintArray(array);
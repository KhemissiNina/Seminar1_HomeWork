//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

//создаем  массив случайных чисел
int[] FillArray()
{
    Console.Write("Введите число элементов массива: ");
    int number = int.Parse(Console.ReadLine());
    int[] array = new int[number];

    for (int index = 0; index < number; index++)
    {
        array[index] = new Random().Next(100, 1000);
    }
    return array;
}

//печать массива
void PrintArray(int[] array)
{
    Console.WriteLine(String.Join(" ", array));
}

// счет четных
int Amount(int[] array2)
{
    int k = 0;
    for (int i = 0; i < array2.Length; i++)
    {
        if (array2[i] % 2 == 0) k++;
    }
    return k;
    }

//действия
Console.Clear();
int[] array = FillArray();
Console.Write("Массив: ");
PrintArray(array);
Console.WriteLine($"Количество четных элементов массива равно {Amount(array)} ");
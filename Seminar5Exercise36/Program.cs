//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

//создаем  массив случайных чисел
int[] FillArray()
{
    Console.Write("Введите число элементов массива: ");
    int number = int.Parse(Console.ReadLine());
    int[] array = new int[number];
    Console.Write("Введите диапазон случайных чисел от: ");
    int start = int.Parse(Console.ReadLine());
    Console.Write("                                 до: ");
    int stop = int.Parse(Console.ReadLine());
    for (int index = 0; index < number; index++)
    {
        array[index] = new Random().Next(start, stop);
    }
    return array;
}

//печать массива
void PrintArray(int[] array)
{
    Console.WriteLine(String.Join(" ", array));
}
//найдем сумму

int Summa(int[] array)
{
    int summa = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) summa = summa + array[i];
    }
    return summa;
}
//действия

Console.Clear();
int[] array = FillArray();
Console.Write("Начальный массив: ");
PrintArray(array);
int summa = Summa(array);
Console.WriteLine($"Сумма элементов массива, стоящих на нечетных позициях, равна: {summa} ");
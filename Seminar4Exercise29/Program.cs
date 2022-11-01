//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Элементы задаются рандомно (диапазон выбрать самостоятельно) Итоговый массив должен содержать в себе суммы цифр числа. Т.е. необходимо подсчитывать суммы цифр каждого числа и записывать их в новый массив.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 10]
//63, 12, 33, 36 -> [9, 3, 6, 9]


//массив случайных чисел
void FillArray(int[] array, int number, int start, int stop)
{
    for (int index = 0; index < number; index++)
    {
        array[index] = new Random().Next(start, stop);
    }
}
//печать массива
void PrintArray(int[] array1, int number)
{
    for (int i = 0; i < number; i++)
    {
        Console.Write($"{array1[i]} ");
    }
    Console.WriteLine();
}

//находим сумму цифр числа
void Summa(int[] array2, int number)
{
    for (int index = 0; index < number; index++)
    {
        int summa = 0;
        int a = array2[index];
        while (a > 0)
        {
            summa = summa + a % 10;
            a = a / 10;
        }
        Console.Write($"{summa} ");
    }
}

//действия
Console.Clear();
Console.Write("Введите число элементов массива: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Введите диапазон случайных чисел от: ");
int start = int.Parse(Console.ReadLine());
Console.Write("                                 до: ");
int stop = int.Parse(Console.ReadLine());

int[] array = new int[number];
FillArray(array, number, start, stop);
Console.Write("Начальный массив: ");
PrintArray(array, number);
Console.Write("Конечный  массив: ");
Summa(array, number);
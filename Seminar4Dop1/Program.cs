//Преобразовать массив так, чтобы сначала шли нулевые элементы, а затем все остальные.
//-1 -3 -1 -3 -1 0 -4 -2 -> 0 -3 -1 -3 -1 -1 -4 -2

//создаем  массив случайных чисел

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


void NewArray(int[] array2, int number)
{
    int[] newarray = new int[number];
    int[] newarray1 = new int[number];
    int j = 0;
    int i = 0;
    int k = 0;
    int l = 0;
    while (l < number)
    {
        if (array2[l] == 0)
        {
            newarray1[k] = array2[l];
            Console.Write($"{newarray1[k]} ");
        }
        l++;
        k++;
    }
    while (i < number)
    {
        if (array2[i] != 0)
        {
            newarray[j] = array2[i];
            Console.Write($"{newarray[j]} ");
        }
        i++;
        k++;
    }
    Console.WriteLine();
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
array[5] = 0;
//array[3]=0;
Console.Write("Начальный массив: ");
PrintArray(array, number);
Console.Write("Конечный  массив: ");
NewArray(array, number);
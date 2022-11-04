// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
double[] FillArray()
{
    Console.Write("Введите число элементов массива: ");
    int number = int.Parse(Console.ReadLine());
    double[] array = new double[number];
    //Console.Write("Введите диапазон случайных чисел от: ");
    //double start = double.Parse(Console.ReadLine());
    //Console.Write("                                 до: ");
    //double stop = double.Parse(Console.ReadLine());
    Random rand = new Random();
    for (int index = 0; index < number; index++)
    {
        array[index] = new Random().Next(0, 20);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.WriteLine(String.Join(" ", array));
}

Console.Clear();
double[] array = FillArray();
Console.Write("Начальный массив: ");
PrintArray(array);

//пробуем использование лист
List<double> numbers = new List<double>();
numbers.AddRange(array);
double max = numbers.Max();
double min = numbers.Min();
Console.WriteLine($"Максимальное число массива равно {max}");
Console.WriteLine($"Минимальное число массива равно {min}");
Console.WriteLine($"Разница между максимальнчм и минимальным числами массива равна {max - min}");
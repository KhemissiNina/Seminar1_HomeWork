//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. С помощью рекурсии!!!
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int SummaNumbers (int first, int finish)
{
    //int first=4;
    //int finish=7;
    if (finish==first) return finish;
    else
        return(first + SummaNumbers(first+1,finish));
}
Console.Clear();
Console.Write("Введите диапазон чисел от:");
int first=int.Parse(Console.ReadLine());
Console.Write("                       до:");
int finish=int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма числе в диапазоне от {first} до {finish} равна {SummaNumbers(first,finish)}");
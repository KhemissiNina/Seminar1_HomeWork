//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

Console.Clear();
void FillArrayDoubleNumbers()
{
Console.Write("Введите число строк массива: ");
int stroka = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int stolbec = int.Parse(Console.ReadLine());
//Console.Write("Введите диапазон случайных чисел от: ");
//double start = double.Parse(Console.ReadLine());
Console.Write("Введите диапазон случайных чисел до: ");
double stop = double.Parse(Console.ReadLine());
double [,] array = new double [stroka, stolbec];

for (int i=0; i<stroka;i++)
{
     for (int j=0; j<stolbec;j++)
     {
         array [i,j]=Math.Round((new Random().NextDouble()*stop),1);
         Console.Write($"{array [i,j]} ");
     }
     Console.WriteLine();
}
}
FillArrayDoubleNumbers();
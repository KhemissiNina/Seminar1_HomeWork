//Дополнительно
//Дан список некоторых целых чисел, найдите значение 20 в нем и, если оно присутствует, замените его на 200. Обновите список только при первом вхождении числа 20.
//[21, 53,20, 56, 45,20] -> [21, 53,200, 56, 45,20]

List<int> Twohundred = new List<int>() { 15, 32, 39, 43, 20, 64, 17, 20 };

void PrintArray(List<int> name)
{
    foreach (int i in Twohundred)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}
Console.Clear();
Console.Write("Начальный  массив: ");
PrintArray(Twohundred);
int index = Twohundred.IndexOf(20);
Twohundred[index] = 200;
Console.Write("Измененный массив: ");
PrintArray(Twohundred);
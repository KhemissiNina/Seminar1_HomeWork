// Создание массива из двух массивов. В итоговом массиве должны быть элементы первого и второго массив
Console.Clear();
int[] NewMassiv(int[] array1, int[] array2)
{
    int length1 = array1.Length;
    int length2 = array2.Length;
    int[] array = new int[length1 + length2];
    int i = 0;
    int j = 0;
    while (i < 3 )
    {
        array[i] = array1[j];
        //Console.WriteLine(array[i]);
        i++;
        j++;
    }
    int k=0;
    while (i < length1 + length2)
    {
        array[i] = array2[k];
        //Console.WriteLine(array[i]);
        i++;
        k++;
    }
    return array;
 }

void PrintArray(int[] array3)
{
    int newlength = array3.Length;
    int position = 0;
    while (position < newlength)
    {
        Console.Write($"{array3[position]} ");
        position++;
    }
}

int[] array1 = { 1, 2, 3 };
int[] array2 = { 4, 5, 6 };
Console.Write("Первый массив: ");
PrintArray(array1);
Console.WriteLine();
Console.Write("Второй массив: ");
PrintArray(array2);
int[] newarray = NewMassiv (array1, array2);
Console.WriteLine();
Console.Write("Итоговый массив: ");
PrintArray(newarray);
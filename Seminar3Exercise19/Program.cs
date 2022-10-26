int[] NewMassiv(int number)
{
    int[] array = new int[5];
    int i = 0;
    while (i < 5)
    {
        array[i] = number % 10;
        number = number / 10;
        i++;
    }
    return array;
}

Console.WriteLine("Введите пятизнаячное число:");
int number = int.Parse(Console.ReadLine());
int[] newarray = NewMassiv(number);
if (newarray[0] == newarray[4] && newarray[1] == newarray[3])
    Console.WriteLine("Число является палиндромом");
else Console.WriteLine("Число не является палиндром");
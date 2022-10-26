// №17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка
/*       
void part (int x,int y)
{
    if (x==0 || y==0) Console.WriteLine("Нарушение условия задачи");
    else if (x>0 && y>0) Console.WriteLine("Первая четверть");
    else if (x>0 && y<0) Console.WriteLine("Вторая четверть");
    else if (x<0 && y<0) Console.WriteLine("Третья четверть");
    else Console.WriteLine("Четвертая четверть");
}
Console.WriteLine("Введите значениеткоординаты Х:");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значениеткоординаты Y:");
int y = int.Parse(Console.ReadLine());
part(x,y);
        
//2 способ решения через тернарную операцию
string part2 (int x, int y)
{
string name = x>0 && y>0 ? "1 четверть" : x>0 && y<0 ? "2 четверть" : x<0 && y<0 ? "3 четверть" : "4 четверть";
return name;
}
Console.WriteLine("Введите значениеткоординаты Х:");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значениеткоординаты Y:");
int y = int.Parse(Console.ReadLine());
part2(x,y);
string otvet = part2(x,y);
Console.WriteLine(otvet);

// №18. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
void part(int number)
{
    if (number == 1) Console.WriteLine("Возможные координаты точки по оси Х(0;+бесконечность), по оси Y (0; +бесконечность)");
    else if (number == 2) Console.WriteLine("Возможные координаты точки по оси Х(0;+бесконечность), по оси Y (0; -бесконечность)");
    else if (number == 3) Console.WriteLine("Возможные координаты точки по оси Х(0;-бесконечность), по оси Y (0; -бесконечность)");
    else if (number == 4) Console.WriteLine("Возможные координаты точки по оси Х(0;-бесконечность), по оси Y (0; +бесконечность)");
    else if (number <= 0 || number > 4) Console.WriteLine("Нарушение условия задачи");
}
//2 способ
void part (int number)
{
    string name=number==1? "Возможные координаты точки по оси Х(0;+бесконечность), по оси Y (0; +бесконечность)": number==2?"Возможные координаты точки по оси Х(0;+бесконечность), по оси Y (0; -бесконечность)":number==3?"Возможные координаты точки по оси Х(0;-бесконечность), по оси Y (0; -бесконечность)":number == 4?"Возможные координаты точки по оси Х(0;-бесконечность), по оси Y (0; +бесконечность)": (number <= 0 || number > 4)? "Нарушение условия задачи";
}

Console.WriteLine("Введите номер четверти (цифрами от 1 до 4):");
int l = int.Parse(Console.ReadLine());
part(l);

//№21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве
//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21
double Distance (int X1, int Y1, int X2, int Y2)
{
    double distance = Math.Sqrt(Math.Pow(X2-X1,2)+Math.Pow(Y2-Y1,2));
    return distance;
}
Console.WriteLine("Введите значение координаты Х для первой точки:");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значениеткоординаты Y для первой точки:");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение координаты Х для второй точки:");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значениеткоординаты Y для второй точки:");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"Координаты первой точки ({x1};{y1})");
Console.WriteLine($"Координаты второй точки ({x2};{y2})");

double result = Distance(x1,y1,x2,y2);
Console.WriteLine(result);

// №22. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N. 
void Qwadro(int N)
{
    int i = 1;
    while (i <= N)
    {
        int K = i * i;
        Console.WriteLine($"{K} квадрат числа {i}");
        i++;
    }
}
Console.WriteLine("Введите число:");
int n = int.Parse(Console.ReadLine());
Qwadro(n);

//Дополнительно. Выводит все элементы массива пока не встретится элемент -1
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        if (array[i] == -1) break;
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
int[] newarray = { 5, 7, 9, 1, 0, -1, 5 };
PrintArray(newarray);

//Дополнительно. Найти сумму всех элементов массива целых чисел, которые меньше среднего арифметического элементов массива. Размерность массива –20. Заполнение массива осуществить случайными числами от 150 до 300
int[] array = new int[20];
void FillArray(int[] array1)
{
    int length = array1.Length;
    int index = 0;
    while (index < length)
    {
        array1[index] = new Random().Next(150, 300);
        index++;
    }
}
void PrintArray(int[] array2)
{
    int newlength = array2.Length;
    int position = 0;
    while (position < newlength)
    {
        Console.Write($"{array2[position]} ");
        position++;
    }
}

void Summa(int[] array3)
{
    int allsumma = 0;
    int dlina = array3.Length;
    for (int count = 0; count < dlina; count++)
        allsumma = allsumma + array3[count];
    Console.WriteLine();
    Console.WriteLine($"Сумма всех элементов массива равна {allsumma}");
    int median = allsumma / dlina;
    Console.WriteLine();
    Console.WriteLine($"Среднеарифметическое массива равно {median}");
    int result = 0;
    for (int j = 0; j < dlina; j++)
        if (array3[j] < median) result = result + array3[j];
    Console.WriteLine();
    Console.WriteLine($"Сумма элементов массива, меньших среднеарефмитического числа массива, равна {result}");
}

FillArray(array);
PrintArray(array);
Summa(array);
*/
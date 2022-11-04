//Семинар4. список класса. сортируем первый с последним и так далее
//вывод на консоль элементов мaссива
void Vivod (string [] array)
{
	foreach (var i in array)
	{
		Console.Write(i+" ");
	}
	Console.WriteLine();
}

//меняем местами
string [] Perestanovka (string [] array)
{
	for (int i=0; i<array.Length/2;i++)
	{
		string temp=array[i];
		array[i]=array[array.Length-i-1];
		array[array.Length-i-1]=temp;
	}
	return array;
}

//действия
Console.Write("Введите количество учеников в классе: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите имена учеников: ");
string [] names = new string [n];
for (int i=0; i<n;i++)
{
	Console.Write($"{i+1}.");
	names[i]=Console.ReadLine();
}
Vivod(names);
Perestanovka(names);
Vivod(names);

//Семинар4. дан массив. посчитать сколько раз повторяется самое частое число
// 15, 14, 23, 17,23,21,23
Console.Clear();
//создаем массив случайных чисел
int [] FillArray()
{
Console.Write("Введите число элементов массива: ");
int number = int.Parse(Console.ReadLine());
int [] array = new int [number];
Console.Write("Введите диапазон случайных чисел от: ");
int start = int.Parse(Console.ReadLine());
Console.Write("                                 до: ");
int stop = int.Parse(Console.ReadLine());
for (int index=0; index<number; index++)
{        	
array[index] = new Random().Next(start,stop);
}
return array;
}

//вывод на консоль элементов мaссива
void PrintArray (int [] array)
{
	 Console.WriteLine(String.Join(" ",array));
}

int Schet (int [] array)
{
	int coint=0;
	int max=0;
	for (int i=0; i<array.Length; i++)
	{
		coint=0;
		for (int j=0; j<array.Length;j++)
		{
		if (array[i]==array[j]) coint++;
	    }
	    if (coint>max)
	    {
	    	max=coint;
	    }
	    }
	return coint;
}

int [] array=FillArray();
PrintArray(array);
Console.WriteLine($"Самое часто встречаемое число в массиве встречается {Schet(array)} раз");

//Семинар5. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива. Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
//создаем  массив случайных чисел

int [] FillArray()
{
int [] array = new int [12];
for (int index=0; index<12; index++)
{        	
array[index] = new Random().Next(-9,9);
}
return array;
}

//печать массива
void PrintArray (int [] array)
{
	 Console.WriteLine(String.Join(" ",array));
}

//сумма положительных и отрицательных чисел
void Summa (int[]array)
{;
	int positiv=0;
	int negativ=0;
	for(int i=0;i<12;i++)
	{
		if (array[i]>0) positiv+=array[i];
		else negativ+=array[i];
	}
    Console.WriteLine($"Сумма пожительных элементов массива равна {positiv} ");
    Console.WriteLine($"Сумма отрицательных элементов массива равна {negativ} ");
}
//действия
Console.Clear();
int [] array=FillArray();
Console.Write("Массив: ");
PrintArray(array);
Summa (array);

//Семинар5. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2] 
//создаем  массив случайных чисел
int [] FillArray()
{
Console.Write("Введите число элементов массива: ");
int number = int.Parse(Console.ReadLine());
int [] array = new int [number];
Console.Write("Введите диапазон случайных чисел от: ");
int start = int.Parse(Console.ReadLine());
Console.Write("                                 до: ");
int stop = int.Parse(Console.ReadLine());
for (int index=0; index<number; index++)
{        	
array[index] = new Random().Next(start,stop);
}
return array;
}

//печать массива
void PrintArray (int [] array)
{
Console.WriteLine(String.Join(" ",array));
}

//замена
int [] Change(int [] array)
{
	int n=array.Length;
	for (int i=0;i<n;i++)
	{
		array[i]=-array[i];
}
	return array;
}

//действия
Console.Clear();
int [] array=FillArray();
Console.Write("Начальный массив: ");
PrintArray(array);
Change(array);
Console.Write("Конечный  массив: ");
PrintArray(array);

//Семинар 5. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да
int [] FillArray()
{
Console.Write("Введите число элементов массива: ");
int number = int.Parse(Console.ReadLine());
int [] array = new int [number];
Console.Write("Введите диапазон случайных чисел от: ");
int start = int.Parse(Console.ReadLine());
Console.Write("                                 до: ");
int stop = int.Parse(Console.ReadLine());
for (int index=0; index<number; index++)
{        	
array[index] = new Random().Next(start,stop);
}
return array;
}

//печать массива
void PrintArray (int [] array)
{
Console.WriteLine(String.Join(" ",array));
}

//поиск
void Poisk(int [] array, int number)
{
	int n=array.Length;
	int count=0;
	for (int i=0;i<n;i++)
	{
		if (array[i]==number) count++;
	}
		if (count>0) Console.WriteLine("Искомое число найдено");
		else Console.WriteLine("Искомое число не найдено");
}

//действия
Console.Clear();
int [] array=FillArray();
Console.Write("Начальный массив: ");
PrintArray(array);
Console.Write("Введите искомое число ");
int number = int.Parse(Console.ReadLine());

//использованин лист
List <int> numbers = new List<int>();
numbers.AddRange(array);
var b = numbers.Contains(number);
Console.WriteLine(b);
//Poisk(array, number);

//Семинар5. нЗадайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5
int [] FillArray()
{
Console.Write("Введите число элементов массива: ");
int number = int.Parse(Console.ReadLine());
int [] array = new int [number];
Console.Write("Введите диапазон случайных чисел от: ");
int start = int.Parse(Console.ReadLine());
Console.Write("                                 до: ");
int stop = int.Parse(Console.ReadLine());
for (int index=0; index<number; index++)
{        	
array[index] = new Random().Next(start,stop);
}
return array;
}

//печать массива
void PrintArray (int [] array)
{
Console.WriteLine(String.Join(" ",array));
}

//поиск
void Schet (int [] array)
{
	int n=array.Length;
	int count=0;
	for (int i=0;i<n;i++)
	{
		if (array[i]>10 && array[i]<99) count++;
	}
	Console.WriteLine ($"Количество элементов в пределах от 10 до 99 составляет {count} единиц");
}

//действия
Console.Clear();
int [] array=FillArray();
Console.Write("Начальный массив: ");
PrintArray(array);
Schet(array);

//Семинар5. Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21
int [] array = {1,2,3,4,5,6,7,8};
int [] Umnojenie (int [] array)
{
	int [] newarray = new int [(array.Length+1)/2];
	for (int i=0; i<array.Length/2+1;i++)
	{
		if (i!=(array.Length-i-1)) newarray[i]=array[i]*array[array.Length-i-1];
	    else newarray[i]=array[i];
			}
	return newarray;
}

//печать массива
void PrintArray (int [] array)
{
Console.WriteLine(String.Join(" ",array));
}
PrintArray(array);
PrintArray(Umnojenie(array));
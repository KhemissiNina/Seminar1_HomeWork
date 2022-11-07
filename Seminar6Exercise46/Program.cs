//Задача41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

//0, 7, 8, -2, -2 -> 2 1, -7, 567, 89, 223->3 
int Scchet (int number)
{
int count =0;
int newcount=0;
while (count<number)
{
Console.Write($"Введите {count+1} число:");
int cchislo=int.Parse(Console.ReadLine());
if (cchislo<0) newcount++;
count++;
}
return newcount;
}
Console.Clear();
Console.Write("Какое количество чисел Вы будете вводить?");
int number=int.Parse(Console.ReadLine());
int i=Scchet(number);
if (i<5 ||i%10<5) Console.WriteLine($"Введено {i} отрицательных числа");
else Console.WriteLine($"Введено {i} отрицательных чисел");
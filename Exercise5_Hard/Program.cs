/*
Задача повышенной сложности из семинара 1
Напишите программу.
Какая сумма элементов массива больше – с первого до элемента с номером К или от элемента с номером К+1 до последнего.
На вход подается массив чисел. Затем вводится переменная K. На выход программа должна вывести или "Первая часть" или "Вторая часть"
Например, при вводе массива [8 11 15 8 9 10] и числа 3. Программа должна вывести 1 часть, так как 42 больше, чем 19.
*/
int [] array = {8, 11, 15, 8, 9, 10};
int length = array.Length;
// Выведим массив на экран
int index1=0;
while (index1<length){
    Console.Write($"{array[index1]},");
    index1++;
    }
int index=0;
int sum1=0;
int sum2=0;
Console.WriteLine();
Console.Write ("Введите индекс числа массива:");
int k = int.Parse(Console.ReadLine());
if (k<length){ 
    while (index<k) {
        sum1=sum1 + array[index];
        index ++;
        }
    while (index<length) {
        sum2=sum2 + array[index];
        index++;
        }
//Console.WriteLine();
    if (sum1>sum2)
        Console.WriteLine($"Первая часть {sum1} больше второй {sum2}");
    else
        Console.WriteLine($"Вторая часть {sum2} больше первой {sum1}");}
else
{
    Console.WriteLine("Длина массива меньше заданного числа");
}
/*
Найти два наименьших положитедбгых числа в массиве
*/

int [] array = {11,2,50,67,9,-35,32};
int n = array.Length;
int index = 0;
int index1 = 0;
int min1=array[index];
int min2=array[index1];
while (index<n){
    Console.Write($"{array[index]},");
    index++;}
while (index<n){
    if (array[index]>0)
        if (min1>array[index]) min1=array[index];
        index++;}
    while (index1<n){
        if (array[index1]>0)
        	if (array[index1]!=min1)
        	    if (min2>array[index1]) min2=array[index1];
        index1++;}
Console.WriteLine();
Console.WriteLine($"Первое наименьшее положительное число массива {min2}");
Console.WriteLine($"Второе наименьшее положительное число массива {min1}");
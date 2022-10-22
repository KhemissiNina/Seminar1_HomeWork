/*Задание. Найдем максимум из представленных чисел
доисторический способ
int a1=15;
int b1=21;
int c1=39;
        	
int a2=12;
int b2=23;
int c2=33;
        	
int a3=13;
int b3=23;
int c3=33;

int max=a1;
if (b1>max) max=b1;
if (c1>max) max=c1;

if (a2>max) max=a2;
if (b2>max) max=b2;
if (c2>max) max=c2;

if (a3>max) max=a3;
if (b3>max) max=b3;
if (c3>max) max=c3;
            
Console.WriteLine(max);
*/
//то же самое. но с помощью функции
int Max(int arg1, int arg2, int arg3)  //max - имя функции, arg - это ВВОДИМЫЙ аргумент
{
    int result = arg1; //переменная result для нахождения максимума внутри функции
    if (arg2>result) result=arg2;
    if (arg3>result) result=arg3;
    return result;
}
/*заменяем несколькострочный ввод данных в массивом
int a1=15;
int b1=21;
int c1=39;
        	
int a2=12;
int b2=23;
int c2=33;
        	
int a3=13;
int b3=23;
int c3=33;*/

int [] array ={15, 21, 39, 12, 23,33, 13, 23, 33};
        	
/* улучшаем код. вот все это можно записать как...
int max1 = Max (a1, b1, c1);
int max2 = Max (a2, b2, c2);
int max3 = Max (a3, b3, c3);
int max = Max (max1, max2, max3);*/
        	
/*... записать как это (это для построчного ввода данных а1, с1 и т.д.)
int max = Max (Max (a1, b1,c1), Max(a2, b2,c2), Max (a3, b3, c3));*/

// для ввода данных через массив вызов функции будет выглядеть так:

int max = Max (Max (array[0], array[1],array[2]), Max(array[3], array[4],array[5]), Max (array[6], array[7],array[8]));
Console.WriteLine(max);
//найти позицию числа в массиве совпадающий с требуемым (например, 13)
/* массив дан, число дано
int [] array = {45, 65, 13, 79, 56, 95, 13, 21};
int n = array.Length;
int find = 13;
int index = 0;
while (index < n)
{
    if (array[index]==find)
    {
        Console.WriteLine(index);
        break;//если достигло требуемого и больше не надо, то пишем команду прервать
    }
        index++;
}
*/

// решение через массив случайных чисел
void FillArray(int [] collection) // метод для создания массива случайных чисел
    {
      	int length = collection.Length;
       	int index = 0;
       	while (index<length)
       	{
       		collection[index] = new Random().Next(1,10);
      		index++;
       	}
    }
        
void PrintArray(int [] newarray) // метод для вывода на печать массива
    {
       	int count = newarray.Length;
       	int position = 0;
       	while(position<count)
        {
        	Console.WriteLine(newarray[position]);
            position++;
        }
    }
        
int IndexOff(int [] collection, int find) // метод для поиска местоположения числа в массиве равному заданному числу
    {
       	int count = collection.Length;
       	int index =0;
       	int position=-1;
       	while (index<count)
       	{
        	if (collection[index]==find)
       		{
        		position=index;
        		break; // остановка работы условия при первом достижении истины
        	}
        	index++;
        }
        return position; //возвращаемый результат работы метода, место в массиве с числом равным заданному
    }

int [] array = new int [10]; // задаем размер массива (10)
        
FillArray(array); //запускаем работу метода по созданию массива случайных чисел
PrintArray(array);// запускаем работу метода печати массива случ.чисел
Console.WriteLine();

int pos = IndexOff(array,4);// запускаем в работу метод (некой перменной присваеваем полученный рузцльтат) по поиску числа в массиве равному заданному числу, в качестве аргументов указываем, что берем массив array и число 4
Console.WriteLine(pos);
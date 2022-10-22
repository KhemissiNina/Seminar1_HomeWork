//сортировка массива
int [] arr = {6,3,7,9,15,4,1,8,8};
//выводим массив на экран с помощью метода с именем PrintArray
void PrintArray(int [] array) // создаем метод PrintArray
{
	int count = array.Length;
	for (int i=0; i<count;i++)
	{
		Console.Write($"{array[i]} ");
	}
	Console.WriteLine();
}

void SelectionSort(int [] array) // метод сортировки массива от min к max
{
	for (int i=0; i<array.Length-1; i++)
	{
		int minPosition=i;
		    for (int j=i+1; j<array.Length; j++)
		    {
		    	if (array[j]<array[minPosition]) minPosition=j;
		    }
		int temporary = array[i];
		array[i]=array[minPosition];
		array[minPosition]=temporary;
	}
}
PrintArray(arr); // вызыааем метод PrintArray, в качестве аргумента кладем наш массив arr
SelectionSort(arr); // вызываем метод SelectionSort, в качестве аргумента кладем наш массив arr

PrintArray(arr); //вызываем метод PrintArray, в качестве аргумента кладем наш массив arr
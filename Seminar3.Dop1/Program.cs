// Из массива удаляется элемент с позиции, которую введет пользователь

Console.Clear();
void NewArray(int [] array, int delete)
{
	int length=array.Length;
	int i=0;
	int j=0;
	while(i<length)
	{
		if (j!=delete) {
			array[j]=array[i];
		    Console.Write($"{array[j]} ");
		    }
		i++;
		j++;
	}
}

void PrintArray(int [] array)
{	
int count = array.Length;	
for (int i=0; i<count;i++)	
Console.Write($"{array[i]} ");
}

Console.WriteLine("Введите позицию числа в массиве, которую нужно удалить:");
int delete=int.Parse(Console.ReadLine());
int [] newarray ={5,7,9,1,0,-1,5};
Console.Write ("Первоначальный массив: ");
PrintArray(newarray);
Console.WriteLine();
Console.Write ("Измененный массив:     ");
NewArray(newarray,delete);
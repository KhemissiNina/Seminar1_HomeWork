//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

//попытка через простой массив
Console.Clear();
int[,,] FillArray(int[,,] array)
{
      for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                array[i, j, k] = new Random().Next(10, 20);
                /*
                int m=0;
                while (m<array.GetLength(2))
                if (array.Contains(array[i, j, k])) k--;
                m++;*/
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k})   ");
            }
        }
        Console.WriteLine();
    }
}

int[,,] array = new int[2, 2, 2];
FillArray(array);
PrintArray(array);

/*
// попытка через List
Console.Clear();

void FillList (List<List<List<int>>> mylist)
{
for (int i=0; i<2;i++)
{
     mylist.Add(new List<int>());
     for (int j=0; j<2;j++)
     {
     	mylist[i].Add(new Random().Next(10,100));
     	mylist.Add(new List<List<int>>());
        for (int k=0; k<2;k++)
        {
         mylist[j].Add(new Random().Next(10,100));
     }
     }
}
}

void PrintList (List<List<List<int>>> mylist)
{
	for (int i=0;i<2;i++)
	{
		for (int j=0;j<2;j++)
		{
            for (int k=0; k<2;k++)
			Console.Write(mylist[i][j][k] + " ");
        }
     Console.WriteLine();
	}
}

List <List<List<int>>> numbers = new List<List<List<int>>>();
FillList(numbers);
PrintList(numbers);
*/
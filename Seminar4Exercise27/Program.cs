//27.Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
Console.Clear();
Console.Write("Введите число: ");
string a = Console.ReadLine();

int Summa (string a)
{
	int length=a.Length;
	int summa=0;
	int temp=0;
	for (int i=0; i<length;i++)
	{
	temp=a[i]-'0';
	summa+=temp;
	}
	return summa;
}
int result=Summa(a);
Console.Write($"Сумма всех цифр в числе {a} равна {result}");
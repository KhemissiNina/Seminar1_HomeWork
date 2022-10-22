//Сравнение циклов while и for
string Method4(int count, string text)
{
//int i=0;
string result = String.Empty; // пустая строка
/*
while (i<count)
{
result=result+text;
i++;
}
return result;
}
string res = Method4(5, "условный_текст");
Console.WriteLine(res);
*/
for(int i=0; i<count; i++)
{
	result=result+text;
}
return result;
}
string res = Method4(5, "условный_текст");
Console.WriteLine(res);
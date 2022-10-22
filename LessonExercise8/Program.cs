// заменить пробелы на _
// маленькие буквы к заменить большими К
// маленькие а заменить большими А
string text = "- Я думаю, сказал князь,улыбаясь, - что "
             +"ежели бы вас послали вместо нашего милого Винценгероде,"
             +"вы бы взяли приступом согласие прусского короля"
             +"Вы так красноречивы. Вы дадите мне чаю?";
string Replace(string text, char OldValue, char NewValue)
{
	string result = string.Empty;
	int length =text.Length;
	for (int i=0; i<length;i++)
	{
		if (text[i]==OldValue) result= result + $"{NewValue}";
		else result= result + $"{text[i]}";
	}
	return result;
}
string NewText = Replace(text, ' ', '_');
Console.WriteLine(NewText);
Console.WriteLine();
    
NewText = Replace(NewText, 'к', 'К');
Console.WriteLine(NewText);
Console.WriteLine();
    
NewText = Replace(NewText, 'а', 'А');
Console.WriteLine(NewText);
Console.WriteLine();
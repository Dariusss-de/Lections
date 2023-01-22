// Дан текстю Нужно заменить все пробелы чёрточками, маленькие буквы 'k' заменить на 'K', а большие буквы 'C', заменить 'c'
string text = "- Я думаю, - сказал князь, улыбаясь - что, "
              + "ежели бы вас послали вместо нашего милого Винценгероде "
              + "вы бы взяли приступом согласия прусского короля. "
              + "Вы так красноречивы. Вы дадите мне час?";

//  string str = "qwerty"
//                012345
// str[1] //w

string Replace(string text,char oldValue,char newValue)
{
    string result = String.Empty;
    int Length = text.Length;
    for(int i=0;i<Length;i++)
    {
        if(text[i] == oldValue) result =  result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
   


    return result;
}
string newText = Replace(text,' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText,'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText,'с', 'С');
Console.WriteLine(newText);
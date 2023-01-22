// Вид1 Функции ничего не возвращают и не принимают
void Method1()
{
    Console.WriteLine("Ваше имя");
}
//Method1();

// Вид2 Функции принимают аргументы но не возвращают
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg: "Автор Чехова А.П");


void Method21(string msg, int count)
{
    int i=0;
    while(i<count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg:"Автор Чехова А.П",count:5);
//Method21(count:3, msg:"Новый текст");


// Вид 3 Функции не принимают ничего но возращают значение
int Method3()
{
    return DateTime.Now.Year;
}
//int year = Method3();
//Console.WriteLine(year);

// Вид 4 Функции принимают значения и возвращают значения
string Method4(int count, string ch)
{
    
    string result = String.Empty; // Пустая строка
    for(int i=0;i<count;i++)
    {
        result = result+ch;
    }
    return result;
    Console.WriteLine(result);
}
//Console.WriteLine(Method4(count:4,ch:" Return string "));



for(int i=2;i<=10;i++)
{
    for(int j=2;j<=10;j++)
    {
        Console.WriteLine($"{i} * {j} = {i*j}");
    }
    Console.WriteLine();

}

//Приветствия определённого пользователя уникально
Console.Write("Введите имя пользователя: ");
string name = Console.ReadLine();
switch(name)
{
    case "Маша":
    Console.WriteLine("Добрый день, "+name);
    break;
    case "Антон":
    Console.WriteLine("Добрый день, господин "+name);
    break;
}

/*
Console.Write("Введите имя пользователя: ");
string name = Console.ReadLine();
if(name.ToLower() == "Маша") Cosole.WriteLine("Добрый день, "+name);
else if (name.ToLower() == "Паша") Cosole.WriteLine("Добрый день,господин "+name);
*/
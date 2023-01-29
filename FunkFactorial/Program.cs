// Нахождение факториала

double Factorial (int fact)
{
    // 1! =1
    // 0! =1
    if(fact == 1 || fact == 0) return 1;
    else return fact * Factorial (fact -1) ;
}


Console.Write("Введите значение факториала: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Значение факториала числа {num} = {Factorial (num)}");

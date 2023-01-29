// Сравнения веса гирь
Console.Write("Введите вес 1 гири: ");
int Kettlebell1 = int.Parse(Console.ReadLine());
Console.Write("Введите вес 2 гири: ");
int Kettlebell2 = int.Parse(Console.ReadLine());
Console.Write("Введите вес 3 гири: ");
int Kettlebell3 = int.Parse(Console.ReadLine());
Console.Write("Введите вес 4 гири: ");
int Kettlebell4 = int.Parse(Console.ReadLine());
Console.Write("Введите вес 5 гири: ");
int Kettlebell5 = int.Parse(Console.ReadLine());
int max = Kettlebell1;
if(Kettlebell2>max)
{
    max = Kettlebell2;
 Console.WriteLine("Гиря 2 самая тяжёлая, ее вес: "+max);
}
else if(Kettlebell3>max)
{
    max = Kettlebell3;
 Console.WriteLine("Гиря 3 самая тяжёлая, ее вес: "+max);
}
else if(Kettlebell4>max)
{
    max = Kettlebell4;
 Console.WriteLine("Гиря 4 самая тяжёлая, ее вес: "+max);
}
else if(Kettlebell5>max)
{
    max = Kettlebell5;
 Console.WriteLine("Гиря 5 самая тяжёлая, ее вес: "+max);
}

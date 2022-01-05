// Показать таблицу квадратов чисел от 1 до N 

int N = new Random().Next(1, 25);

Console.Clear();
Console.WriteLine($"Число N = {N}");
for (int i = 1; i <= N; i++)
{
    double SquareOfN = Math.Pow(i, 2);
    Console.WriteLine($"|{i}|{SquareOfN}|");
}
/* Console.WriteLine("_______"); */



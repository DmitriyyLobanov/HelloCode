// Возведите число А в натуральную степень B используя цикл

Console.Clear();
int A = new Random().Next(1, 51);
int B = new Random().Next(1, 11);
int Pow = A;
Console.WriteLine(A);
Console.WriteLine(B);

for (int i = 1; i < B; i++)
{
   Pow *= A;
}


Console.WriteLine(Pow);
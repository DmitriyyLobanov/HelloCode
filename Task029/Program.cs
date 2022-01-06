// Написать программу вычисления произведения чисел от 1 до N

Console.Clear();

int N = new Random().Next(1, 15);
int Factorial = 1;
for (int i = 1; i <= N; i++)
{
    Factorial = Factorial * i;
}


Console.WriteLine($"Факториал числа {N} равен {Factorial}.");

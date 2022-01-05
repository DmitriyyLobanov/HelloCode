// Найти сумму чисел от 1 до А

int A = new Random().Next(1, 100);
int Sum = 0;

Console.Clear();
Console.WriteLine($"Число А = {A}.");
for (int i = 1; i <= A; i++)
{
    Sum = Sum + i;

}

Console.WriteLine($"Сумма чисел от 1 до {A} = {Sum}.");

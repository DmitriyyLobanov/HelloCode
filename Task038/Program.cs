// Найти сумму чисел одномерного массива стоящих на нечетной позиции


Console.Clear();
int[] array = new int[50];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 150);
}
string s = string.Join(", ", array);
Console.WriteLine($"Заданный массив чисел - ({s}).");

int Sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0)
    {
        Sum = Sum + array[i];
    }
}



Console.WriteLine();
Console.WriteLine($"Сумма чисел, находящихся на нечётной позиции в массиве равна {Sum}.");

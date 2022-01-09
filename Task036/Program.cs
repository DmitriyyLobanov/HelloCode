// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел


Console.Clear();
int[] array = new int[20];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
}
string s = string.Join(", ", array);

int even = 0;
int odd = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        even++;
    }
    else
    {
        odd++;
    }
}

Console.WriteLine($"Заданный массив чисел - ({s}).");
Console.WriteLine($"Количество четных чисел = {even}, количество нечетных чисел = {odd}.");





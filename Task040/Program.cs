// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

Console.Clear();
double[] array = new double[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = (new Random().NextDouble()) * 5;
    array[i] = Math.Round(array[i], 2);
}
string s = string.Join("; ", array);
Console.WriteLine($"Заданный массив вещественных чисел - ({s}).");

double max = array[0];
double min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}
Console.WriteLine($"Максимальное число, входящее в массив = {max}, минимальное = {min}.");
Console.WriteLine($"Разница между максимальным и минимальным = {Math.Round((max - min), 2)}.");




//Console.WriteLine("Hello, World!");

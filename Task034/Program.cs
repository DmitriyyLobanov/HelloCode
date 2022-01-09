// Написать программу замену элементов массива на противоположные

Console.Clear();
int[] array = new int[10];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-5, 6);
}
string S = string.Join(", ", array);
Console.WriteLine($"Заданный массив: ({S}).");

for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * (-1);
}
string InvertedS = string.Join(", ", array);
Console.WriteLine($"Массив, элементы которого, имеют противоположный знак: ({InvertedS})");
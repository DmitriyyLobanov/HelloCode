// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

Console.Clear();
int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 10);
}
string s = string.Join(", ", array);
Console.WriteLine($"Заданный массив чисел - ({s}).");
Console.WriteLine("Произведения пар чисел(первое - последнее, второе - предпоследнее и т.д).");

for (int i = 0, j = array.Length - 1; i < array.Length && j > 0; i++, j--)
{
    if (i > j)
    {
        break;
    }
    else
    {
        Console.WriteLine(array[i] * array[j]);
    }

}














//Console.WriteLine("Hello, World!");

// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
Console.Clear();
int[] array = new int[123];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 150);
}
string s = string.Join(", ", array);
Console.WriteLine($"Заданный массив чисел - ({s}).");
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if ((array[i] >= 10) && (array[i] <= 99))
    {
        count++;
    }
}
 Console.WriteLine($"Количество чисел в массиве, принадлежащик к диапазону [10, 99] = {count}.");

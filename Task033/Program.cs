// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
Console.Clear();
int[] array = new int[12];
int Sum = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
    if (array[i] > 0)
    {
        Sum = Sum + array[i];
    }

    //Console.Write(array[i]);
    //Console.Write(", ");
}

string s = string.Join(", ", array);




Console.WriteLine($"Заданный массив - ({s}).");
Console.WriteLine($"Сумма положительных элементов массива = {Sum}.");

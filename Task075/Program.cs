/* // Есть два массива info и data. 

Массив data состоит из нулей и единиц хранящий числа в двоичном представлении. Числа идут друг за другом без разделителей. 

Массив info состоит из чисел, которые представляют колличество бит чисел из массива data.

Составить массив десятичных представлений чисел массива data с учётом информации из массива info. 

Пример:
```
входные данные:
data = {0, 1, 1, 1, 1, 0, 0, 0, 1}
info = {2, 3, 3, 1}

выходные данные:
1, 7, 0, 1
```
 */
using System;
Console.Clear();

int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 1, 1, 0, 0 };
int[] info = { 2, 3, 3, 1, 4, 6 };
int[] result = new int[1];

void PrintArray(int[] array)
{
    Console.Write('[');
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length - 1)
        {
            Console.Write(", ");
        }

    }
    Console.Write(']');
}
int CreateDecimal(int[] binaryArray, int count, int startIndex)
{
    string s = "0";
    int addCount = 0;
    for (int i = startIndex; i < binaryArray.Length; i++)
    {
        if (addCount < count)
        {
            s += $"{binaryArray[i]}";
            addCount++;
        }
    }
    int number = Convert.ToInt32(s, 2);
    return number;
}
int FindStartIndex(int[] binArray, int indexOfElement)
{
    int start = 0;
    int count = 0;
    while (count < indexOfElement)
    {
        start += binArray[count];
        count++;
    }
    return start;
}

int num;
for (int i = 0; i < info.Length; i++)
{
    num = CreateDecimal(data, info[i], FindStartIndex(info, i));
    result[i] = num;
    if (i != info.Length - 1)
    {
        Array.Resize(ref result, result.Length + 1);
    }
}


PrintArray(result);

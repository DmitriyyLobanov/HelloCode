void fillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {

        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void printArray(int[] col)
{
    int count = col.Length;
    int posicion = 0;
    while (posicion < count)
    {
        Console.Write(col[posicion]);
        Console.Write(" ");
        posicion++;
    }
}

int indexOf(int[] collection, int find) // Написание метода для поиска нужного элемента массива.
{
    int count = collection.Length;
    int index = 0;
    int posicion = -1; // -1 введен для возврата в случае отсутствия искомого элемента в массиве.
    while (index < count)
    {
        if (collection[index] == find)
        {
            posicion = index;
            break;
        }
        index++;
    }
    return posicion;
}

int[] array = new int[10]; // Создание нового массива целых чисел (по умолчанию под всеми индексами будут 0)

fillArray(array);
printArray(array);
Console.WriteLine();

int pos = indexOf(array, 4);
Console.WriteLine(pos);


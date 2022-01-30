// Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента

Console.Clear();

int m = 3; //new Random().Next(3, 10);
int n = 3; //new Random().Next(3, 10);
int z = 2; //new Random().Next(3, 10);

int[,,] matrix3D = new int[m, n, z];

void PrintArray(int[,,] array)
{
    int count = 1;
    for (int k = 0; k < z; k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.WriteLine($"Элемент массива №{count}: {array[i, j, k]} ({i}, {j}, {k}). ");
                count++;
            }
        }
    }
}
void FillArray(int[,,] array)
{
    int value = 10;
    for (int k = 0; k < z; k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j, k] = value++;
            }
        }
    }
}

PrintArray(matrix3D);
FillArray(matrix3D);
Console.WriteLine();
PrintArray(matrix3D);


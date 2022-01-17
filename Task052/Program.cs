//  В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

Console.Clear();

int m = new Random().Next(3, 10);
int n = new Random().Next(3, 10);

int[,] matrix = new int[m, n];

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100);
        }
    }
}

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        while (i % 2 == 0 && j % 2 == 0)
        {
            matrix[i, j] *= matrix[i, j];
            break;
        }
    }
}

Console.WriteLine();
PrintArray(matrix);



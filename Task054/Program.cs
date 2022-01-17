// В матрице чисел найти сумму элементов главной диагонали

Console.Clear();

int m = 4;
int n = 4;

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
            array[i, j] = new Random().Next(0, 50);
        }
    }
}

FillArray(matrix);

int sum = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (i == j)
        {
            sum += matrix[i, j];
        }
    }
}

Console.WriteLine();
PrintArray(matrix);

Console.WriteLine($"Сумма элементов главной диагонали равна {sum}.");



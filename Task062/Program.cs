// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

Console.Clear();

int m = 3; //new Random().Next(3, 10);
int n = 3; //new Random().Next(3, 10);

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
            array[i, j] = new Random().Next(0, 100);
        }
    }
}


FillArray(matrix);
Console.WriteLine("Исходная матрица чисел:");
PrintArray(matrix);

int min = matrix[0, 0];
int row = 0;
int column = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] < min)
        {
            min = matrix[i, j];
            row = i;
            column = j;
        }
    }
}

Console.WriteLine($"Минимальное число в исходном массиве - {min}.");
Console.WriteLine($"Удалению подлежит строка - {row + 1} и столбец - {column + 1}.");
Console.WriteLine();

int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
for (int i = 0, j = 0; i < matrix.GetLength(0); i++)
{
    if (i == row) continue;
    for (int k = 0, u = 0; k < matrix.GetLength(0); k++)
    {
        if (k == column) continue;
        newMatrix[j, u] = matrix[i, k];
        u++;
    }
    j++;
}
Console.WriteLine("Матрица после удаления строки и столбца:");
PrintArray(newMatrix);

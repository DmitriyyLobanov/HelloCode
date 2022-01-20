// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).

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
            array[i, j] = new Random().Next(0, 100);
        }
    }
}
int[] ConvertRowToArray(int[,] matrix, int row)
{
    int[] array = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        array[i] = matrix[row, i];
    }
    return array;
}

FillArray(matrix);
PrintArray(matrix);

if (matrix.GetLength(0) == matrix.GetLength(1))
{
    int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        int[] array = ConvertRowToArray(matrix, i);
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            newMatrix[j, i] = array[j];
        }
    }


    Console.WriteLine();
    Console.WriteLine("Матрица после преобразования (строки заменены на столбцы).");
    PrintArray(newMatrix);
}
else
{
    Console.WriteLine("Преобразование невозможно, матрица не квадратная.");
}

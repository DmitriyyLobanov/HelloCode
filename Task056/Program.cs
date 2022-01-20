// Написать программу, которая обменивает элементы первой строки и последней строки

Console.Clear();

int m = new Random().Next(3, 6);
int n = new Random().Next(3, 6);

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
PrintArray(matrix);

int temp;

for (int i = 0; i < matrix.GetLength(1); i++)
{
    temp = matrix[0, i];
    matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
    matrix[matrix.GetLength(0) - 1, i] = temp;
}


Console.WriteLine();
PrintArray(matrix);
// Найти произведение двух матриц

Console.Clear();

int m = 3; //new Random().Next(3, 10);
int n = 3; //new Random().Next(3, 10);

int[,] matrix1 = new int[m, n];
int[,] matrix2 = new int[m, n];
int[,] prodactOfMatrix = new int[m, n];

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
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

FillArray(matrix1);
FillArray(matrix2);

Console.WriteLine("Матрица № 1:");
PrintArray(matrix1);
Console.WriteLine();
Console.WriteLine("Матрица № 2:");
PrintArray(matrix2);

for (int i = 0; i < prodactOfMatrix.GetLongLength(0); i++)
{
    for (int j = 0; j < prodactOfMatrix.GetLongLength(1); j++)
    {
        for (int k = 0; k < prodactOfMatrix.GetLongLength(0); k++)
        {
            prodactOfMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
        }
    }
}
Console.WriteLine();
Console.WriteLine("Произведение матриц:");
PrintArray(prodactOfMatrix);
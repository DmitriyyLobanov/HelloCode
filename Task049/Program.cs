// Показать двумерный массив размером m×n заполненный вещественными числами

Console.Clear();

int m = new Random().Next(3, 10);
int n = new Random().Next(3, 10);

double[,] matrix = new double[m, n];

void PrintArray(double[,] array)
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
void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = (new Random().NextDouble()) * 5;
            array[i, j] = Math.Round(array[i, j], 2);
        }
    }
}

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);




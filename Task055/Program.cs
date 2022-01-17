// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

Console.Clear();

int m = 5;  //new Random().Next(3, 10);
int n = 5;  //new Random().Next(3, 10);

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
PrintArray(matrix);
Console.WriteLine();

double arithmeticMean = 0;
for (int i = 0; i < matrix.GetLength(1); i++)
{
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        arithmeticMean += matrix[j, i];
    }
    Console.WriteLine($"Среднее арифметическое {i + 1} столбца = {arithmeticMean / matrix.GetLength(0)}.");
    arithmeticMean = 0;
}
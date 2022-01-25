// Составить частотный словарь элементов двумерного массива

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
            array[i, j] = new Random().Next(0, 20);
        }
    }
}

FillArray(matrix);
PrintArray(matrix);
int outOfRange = FindMin(matrix) - 1;

void FrequencyAnalys(int[,] matrix, int numberToAnalys)
{
    int count = 0;
    double persentOfRepeat = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == numberToAnalys)
            {
                count++;
                matrix[i, j] = outOfRange;
            }
        }
    }
    persentOfRepeat = (count / (matrix.GetLength(0) * matrix.GetLength(1))) * 100;
    Console.WriteLine($"Число {numberToAnalys} встречается {count} раз ({Math.Round(((double)count / (matrix.GetLength(0) * matrix.GetLength(1)) * 100), 2)} %).");
}
int FindMin(int[,] matrix)
{
    int min = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min) min= matrix[i, j];  
        }
    }
    return min;
}

Console.WriteLine();

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] != outOfRange)
        {
            FrequencyAnalys(matrix, matrix[i, j]);
        }
    }
}
Console.WriteLine();

Console.WriteLine($"min={outOfRange}   out of range = {outOfRange - 1 }");
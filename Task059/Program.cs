// В прямоугольной матрице найти строку с наименьшей суммой элементов.

Console.Clear();

int m = new Random().Next(3, 5);
int n = new Random().Next(6, 10);

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

int[] sumOfNumberInRow = new int[matrix.GetLength(0)];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum += matrix[i, j];
    }
    sumOfNumberInRow[i] = sum;
}

int posicionOfMin = 0;
int min = sumOfNumberInRow[0];
for (int i = 0; i < sumOfNumberInRow.Length; i++)
{
    if (sumOfNumberInRow[i] < min)
    {
        min = sumOfNumberInRow[i];
        posicionOfMin = i;
    }
}
Console.WriteLine($"Наименьшую сумму элементов имеет строка № {posicionOfMin + 1}. Сумма = {min}.");
// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

Console.Clear();

Console.WriteLine("Введите искомое число:");
bool resultOfParse = int.TryParse(Console.ReadLine(), out int findNumber);
while (resultOfParse == false)
{
    Console.WriteLine("Некорректный ввод, попробуйте снова.");
    resultOfParse = int.TryParse(Console.ReadLine(), out findNumber);
}

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
Console.WriteLine();
PrintArray(matrix);

int count = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] == findNumber)
        {
            Console.WriteLine($"Число {findNumber} присутствует в массиве на позиции ({i}, {j})");
            count++;
        }
    }
}

if (count == 0)
{
    Console.WriteLine();
    Console.WriteLine($"Число {findNumber} не присутствует в массиве.");
}
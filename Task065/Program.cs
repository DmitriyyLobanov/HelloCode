// Спирально заполнить двумерный массив:     
/* ```
 1  2  3  4
 12 13 14  5
 11 16 15  6
 10  9  8  7 
``` */

Console.Clear();

int m = 5;
int n = 5;

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
void FillHelix(int[,] array, int sizeX, int sizeY)
{
    int sum = sizeX * sizeY;
    int correctX = 0;
    int correctY = 0;
    int count = 1;
    while (sizeY > 0)
    {
        for (int y = 0; y < 4; y++)
        {
            for (int x = 0; x < ((sizeX < sizeY) ? sizeY : sizeX); x++)
            {
                if (y == 0 && x < sizeX - correctX && count <= sum)
                {
                    array[y + correctY, x + correctX] = count++;
                }
                if (y == 1 && x < sizeY - correctY && x != 0 && count <= sum)
                {
                    array[x + correctY, sizeX - 1] = count++;
                }
                if (y == 2 && x < sizeX - correctX && x != 0 && count <= sum)
                {
                    array[sizeY - 1, sizeX - (x + 1)] = count++;
                }
                if (y == 3 && x < sizeY - (correctY + 1) && x != 0 && count <= sum)
                {
                    array[sizeY - (x + 1), correctY] = count++;
                }
            }
        }
        sizeY--;
        sizeX--;
        correctX += 1;
        correctY += 1;
    }
    // Сам до решения не додумался, решение взято из сети: (http://spyrytus.narod.ru/algoritm/FillHelix.htm)
    // Немного опишу решение для будущего себя. Используемые переменные:
    // y - сторона (направление заполнения массива, y == 0 - вверх, y == 1 - вправо, y == 2 -вниз, y == 3 - вверх).
    // x - текущая, заполняемая позиция внутри массива.
    // sizeX - размер массива по горизонтали (количество столбцов).
    // sizeY - размер массива по вертикали (количество строк).
    // correctX - переменная, корректирующая заполняемую зону по Х.
    // correctY - переменная, корректирующая заполняемую зону по Y.
    // sum - общее количество элементов в массиве.
    // count - текущее значение для заполнения.
}



PrintArray(matrix);
FillHelix(matrix, m, n);
Console.WriteLine();
PrintArray(matrix);







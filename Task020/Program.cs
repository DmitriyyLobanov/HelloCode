// Задать номер четверти, показать диапазоны для возможных координат

Console.Clear();
void CheckCoordinates(int NumberOfQuarter)
{
    if (NumberOfQuarter == 1)
    {
        Console.WriteLine("Первой четверти соответствуют диапазоны координат (x > 0, y > 0)");
    }
    else if (NumberOfQuarter == 2)
    {
        Console.WriteLine("Второй четверти соответствуют диапазоны координат (x < 0, y > 0)");
    }
    else if (NumberOfQuarter == 3)
    {
        Console.WriteLine("Третьей четверти соответствуют диапазоны координат (x < 0, y < 0)");
    }
    else if (NumberOfQuarter == 4)
    {
        Console.WriteLine("Четвёртой четверти соответствуют диапазоны координат (x > 0, y < 0)");
    }
    else
    {
        Console.WriteLine("Некорректный ввод.");
    }
}

InputNumber:
Console.WriteLine("Введите номер координатной четверти:");
bool ResultOfParse = Int32.TryParse(Console.ReadLine(), out int NumberOfQuarter);
if (ResultOfParse)
{
    if (NumberOfQuarter == 1 || NumberOfQuarter == 2 || NumberOfQuarter == 3 || NumberOfQuarter == 4)
    {
        CheckCoordinates(NumberOfQuarter);
    }
    else
    {
        Console.WriteLine("Некорректный ввод, попробуйте снова.");
        goto InputNumber;
    }
}
else
{
    Console.WriteLine("Некорректный ввод, попробуйте снова.");
    goto InputNumber;
}

//Console.WriteLine("Hello, World!");

/* int NumberOfQuarter = 2;

while (NumberOfQuarter == 1 || NumberOfQuarter == 2 || NumberOfQuarter == 3 || NumberOfQuarter == 4)
{
    if (NumberOfQuarter == 1)
    {
        Console.WriteLine("Первой четверти соответствуют диапазоны координат (x > 0, y > 0)");
        break;
    }
    else if (NumberOfQuarter == 2)
    {
        Console.WriteLine("Второй четверти соответствуют диапазоны координат (x < 0, y > 0)");
        break;
    }
    else if (NumberOfQuarter == 3)
    {
        Console.WriteLine("Третьей четверти соответствуют диапазоны координат (x < 0, y < 0)");
        break;
    }
    else if (NumberOfQuarter == 4)
    {
        Console.WriteLine("Четвёртой четверти соответствуют диапазоны координат (x > 0, y < 0)");
        break;
    }
    Console.WriteLine("Некорректный ввод, попробуйте снова.");
} */
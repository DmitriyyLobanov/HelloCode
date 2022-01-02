// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

Console.Clear();

void CheckingCoordinateQuarter(int x, int y)
{
    if ((x > 0) && (y > 0))
    {
        Console.WriteLine($"Точка с координатами({x};{y}) соотвествует первой координатной четверти.");
    }
    else if ((x < 0) && (y < 0))
    {
        Console.WriteLine($"Точка с координатами({x};{y}) соотвествует третьей координатной четверти.");
    }
    else if ((x < 0) && (y > 0))
    {
        Console.WriteLine($"Точка с координатами({x};{y}) соотвествует второй координатной четверти.");
    }
    else if ((x > 0) && (y < 0))
    {
        Console.WriteLine($"Точка с координатами({x};{y}) соотвествует четвёртой координатной четверти.");
    }
    else
    {
        Console.WriteLine("Некорректный ввод.");
    }
}

InputX:
Console.WriteLine("Введите _x_ координату.");
bool ResultOfParse = Int32.TryParse(Console.ReadLine(), out int x);
if (ResultOfParse)
{
    if (x == 0)
    {
        Console.WriteLine("Недопустимое значение х для определения четверти, х не может быть равен 0. Попробуйте ещё раз");
        goto InputX;
    }
    else
    {
        Console.WriteLine();
    }

}
else
{
    Console.WriteLine("Некорректный ввод, повторите попытку.");
    goto InputX;
}

InputY:
Console.WriteLine("Введите _y_ координату.");
ResultOfParse = Int32.TryParse(Console.ReadLine(), out int y);
if (ResultOfParse)
{
   if (y == 0)
    {
        Console.WriteLine("Недопустимое значение y для определения четверти, y не может быть равен 0. Попробуйте ещё раз");
        goto InputY;
    }
}
else
{
    Console.WriteLine("Некорректный ввод, повторите попытку.");
    goto InputY;
}

CheckingCoordinateQuarter(x, y);


// Найти расстояние между точками в пространстве 2D/3D
Console.Clear();

CoordinateSystemSelect:
Console.WriteLine("Выберите систему координат для рассчета расстояния между точками. Введите 1 для выбора плоскости (2D), или 2 для выбора пространства (3D).");
bool ResultOfParse = Int32.TryParse(Console.ReadLine(), out int NumberOfSystem);
if (ResultOfParse)
{
    if (NumberOfSystem != 1 && NumberOfSystem != 2)
    {
        Console.WriteLine("Некорректный ввод, попробуйте снова.");
        goto CoordinateSystemSelect;
    }
}
else
{
    Console.WriteLine("Некорректный ввод, попробуйте снова.");
    goto CoordinateSystemSelect;
}

if (NumberOfSystem == 1)
{
    Console.WriteLine("Выбрана двумерная система координат.");
Input2DX1:
    Console.WriteLine("Введите (х) координату точки А.");
    ResultOfParse = Int32.TryParse(Console.ReadLine(), out int x1);
    if (ResultOfParse)
    {
        Console.WriteLine($"Точка А ({x1},...).");
    }
    else
    {
        Console.WriteLine("Некорректный ввод, попробуйте снова.");
        goto Input2DX1;
    }
Input2DY1:
    Console.WriteLine("Введите (y) координату точки А.");
    ResultOfParse = Int32.TryParse(Console.ReadLine(), out int y1);
    if (ResultOfParse)
    {
        Console.WriteLine($"Точка А ({x1},{y1}).");
    }
    else
    {
        Console.WriteLine("Некорректный ввод, попробуйте снова.");
        goto Input2DY1;
    }

Input2DX2:
    Console.WriteLine("Введите (х) координату точки В.");
    ResultOfParse = Int32.TryParse(Console.ReadLine(), out int x2);
    if (ResultOfParse)
    {
        Console.WriteLine($"Точка B ({x2},...).");
    }
    else
    {
        Console.WriteLine("Некорректный ввод, попробуйте снова.");
        goto Input2DX2;
    }
Input2DY2:
    Console.WriteLine("Введите (y) координату точки B.");
    ResultOfParse = Int32.TryParse(Console.ReadLine(), out int y2);
    if (ResultOfParse)
    {
        Console.WriteLine($"Точка B ({x2},{y2}).");
    }
    else
    {
        Console.WriteLine("Некорректный ввод, попробуйте снова.");
        goto Input2DY2;
    }

    double Distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    Console.WriteLine($"Расстояние между точками А и В равно {Distance}.");
}
else
{
    Console.WriteLine("Выбрана трёхмерная система координат.");
Input3DX1:
    Console.WriteLine("Введите (х) координату точки А.");
    ResultOfParse = Int32.TryParse(Console.ReadLine(), out int x1);
    if (ResultOfParse)
    {
        Console.WriteLine($"Точка А ({x1},..,...).");
    }
    else
    {
        Console.WriteLine("Некорректный ввод, попробуйте снова.");
        goto Input3DX1;
    }
Input3DY1:
    Console.WriteLine("Введите (y) координату точки А.");
    ResultOfParse = Int32.TryParse(Console.ReadLine(), out int y1);
    if (ResultOfParse)
    {
        Console.WriteLine($"Точка А ({x1},{y1},...).");
    }
    else
    {
        Console.WriteLine("Некорректный ввод, попробуйте снова.");
        goto Input3DY1;
    }
Input3DZ1:
    Console.WriteLine("Введите (z) координату точки А.");
    ResultOfParse = Int32.TryParse(Console.ReadLine(), out int z1);
    if (ResultOfParse)
    {
        Console.WriteLine($"Точка А ({x1},{y1},{z1}).");
    }
    else
    {
        Console.WriteLine("Некорректный ввод, попробуйте снова.");
        goto Input3DZ1;
    }

Input3DX2:
    Console.WriteLine("Введите (х) координату точки B.");
    ResultOfParse = Int32.TryParse(Console.ReadLine(), out int x2);
    if (ResultOfParse)
    {
        Console.WriteLine($"Точка B ({x2},..,...).");
    }
    else
    {
        Console.WriteLine("Некорректный ввод, попробуйте снова.");
        goto Input3DX2;
    }
Input3DY2:
    Console.WriteLine("Введите (y) координату точки B.");
    ResultOfParse = Int32.TryParse(Console.ReadLine(), out int y2);
    if (ResultOfParse)
    {
        Console.WriteLine($"Точка B ({x2},{y2},...).");
    }
    else
    {
        Console.WriteLine("Некорректный ввод, попробуйте снова.");
        goto Input3DY2;
    }
Input3DZ2:
    Console.WriteLine("Введите (z) координату точки B.");
    ResultOfParse = Int32.TryParse(Console.ReadLine(), out int z2);
    if (ResultOfParse)
    {
        Console.WriteLine($"Точка B ({x2},{y2},{z2}).");
    }
    else
    {
        Console.WriteLine("Некорректный ввод, попробуйте снова.");
        goto Input3DZ2;
    }

    double Distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    Console.WriteLine($"Расстояние между точками А и В равно {Distance}.");

}





/* Console.WriteLine($" {y1}"); */
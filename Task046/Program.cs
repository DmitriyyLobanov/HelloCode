// Написать программу масштабирования фигуры
Console.Clear();
double ax = 3;
double ay = 3;
double bx = 9;
double by = 11;
double cx = 15;
double cy = 3;

Console.WriteLine($"Координаты точек вершин фигуры: А({ax}, {ay}), B({bx}, {by}), C({cx}, {cy}).");

Console.WriteLine("Введите 1 чтобы выбрать коэффициент масштабирования k = 4.");
Console.WriteLine("Введите 2 чтобы выбрать коэффициент масштабирования k = 2.");
Console.WriteLine("Введите 3 чтобы выбрать коэффициент масштабирования k = 0.5.");

bool ResultOfParse = double.TryParse(Console.ReadLine(), out double choiceScalingFactor);
while (ResultOfParse == false)
{
    Console.WriteLine("Неверный ввод, попробуйте снова. (1 - (k = 4), 2 - (k = 2), 3 - (k =0.5))");
    ResultOfParse = double.TryParse(Console.ReadLine(), out choiceScalingFactor);
}
while (choiceScalingFactor > 3)
{
    Console.WriteLine("Неверный ввод, попробуйте снова. (1 - (k = 4), 2 - (k = 2), 3 - (k =0.5))");
    ResultOfParse = double.TryParse(Console.ReadLine(), out choiceScalingFactor);
    while (ResultOfParse == false)
    {
        Console.WriteLine("Неверный ввод, попробуйте снова. (1 - (k = 4), 2 - (k = 2), 3 - (k =0.5))");
        ResultOfParse = double.TryParse(Console.ReadLine(), out choiceScalingFactor);
    }
}

if (choiceScalingFactor == 1)
{
    double scalingFactor = 4;
    ax *= scalingFactor;
    ay *= scalingFactor;
    bx *= scalingFactor;
    by *= scalingFactor;
    cx *= scalingFactor;
    cy *= scalingFactor;
    Console.WriteLine($"Координаты точек вершин фигуры после масштабирования (k = 4): А({ax}, {ay}), B({bx}, {by}), C({cx}, {cy}).");
}
else if (choiceScalingFactor == 2)
{
    double scalingFactor = 2;
    ax *= scalingFactor;
    ay *= scalingFactor;
    bx *= scalingFactor;
    by *= scalingFactor;
    cx *= scalingFactor;
    cy *= scalingFactor;
    Console.WriteLine($"Координаты точек вершин фигуры после масштабирования (k = 2): А({ax}, {ay}), B({bx}, {by}), C({cx}, {cy}).");
}
else
{
    double scalingFactor = 0.5;
    ax *= scalingFactor;
    ay *= scalingFactor;
    bx *= scalingFactor;
    by *= scalingFactor;
    cx *= scalingFactor;
    cy *= scalingFactor;
    Console.WriteLine($"Координаты точек вершин фигуры после масштабирования (k = 0.5): А({ax}, {ay}), B({bx}, {by}), C({cx}, {cy}).");
}


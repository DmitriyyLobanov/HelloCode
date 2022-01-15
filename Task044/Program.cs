// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

Console.Clear();

int K1 = 5;  //new Random().Next(-10, 11);
int K2 = 3;  //new Random().Next(-10, 11);
int b1 = 2;  //new Random().Next(-10, 11);
int b2 = 10;  //new Random().Next(-10, 11);
Console.WriteLine($"K1 = ({K1}), K2 = ({K2}), b1 = ({b1}), b2 = ({b2}).");

if ((K1 * b2) != (K2 * b1))
{
    double x = -(b1 - b2) / (K1 - K2);
    double y = K2 * x + b2;
    Console.WriteLine($"Точка пересечения прямых имеет координаты: ({x}, {y}).");
}
else
{
    Console.WriteLine("Прямые не пересекаются.");
}





//Console.WriteLine($"Точка пересечения прямых имеет координаты: ({x}, {y}).");

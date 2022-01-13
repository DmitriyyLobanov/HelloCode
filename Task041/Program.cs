// Выяснить являются ли три числа сторонами треугольника 



Console.WriteLine("Введите первое число.");
bool ResultOfParse = int.TryParse(Console.ReadLine(), out int FirstNumber);
while (ResultOfParse == false)
{
    Console.WriteLine("Некорректный ввод, попробуйте снова.");
    ResultOfParse = int.TryParse(Console.ReadLine(), out FirstNumber);
}

Console.WriteLine("Введите второе число.");
ResultOfParse = int.TryParse(Console.ReadLine(), out int SecondNumber);
while (ResultOfParse == false)
{
    Console.WriteLine("Некорректный ввод, попробуйте снова.");
    ResultOfParse = int.TryParse(Console.ReadLine(), out SecondNumber);
}

Console.WriteLine("Введите третье число.");
ResultOfParse = int.TryParse(Console.ReadLine(), out int ThirdNumber);
while (ResultOfParse == false)
{
    Console.WriteLine("Некорректный ввод, попробуйте снова.");
    ResultOfParse = int.TryParse(Console.ReadLine(), out ThirdNumber);
}


if ((FirstNumber > (SecondNumber + ThirdNumber)) && (SecondNumber > (FirstNumber + ThirdNumber)) && (ThirdNumber > (FirstNumber + SecondNumber)))
{
    Console.WriteLine($"Числа {FirstNumber}, {SecondNumber}, {ThirdNumber} не могут являться длинами сторон треугольника.");
}
else
{
    Console.WriteLine($"Числа {FirstNumber}, {SecondNumber}, {ThirdNumber}  могут являться длинами сторон треугольника.");
}



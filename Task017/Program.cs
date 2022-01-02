// По двум заданным числам проверять является ли одно квадратом другого

Console.Clear();
void CheckingSquare(int FirstNumber, int SecondNumber)
{
    if ((SecondNumber * SecondNumber) == FirstNumber)
    {
        Console.WriteLine($"Число {FirstNumber} явялется квадратом числа {SecondNumber}");
    }
    else
    {
        Console.WriteLine($"Число {FirstNumber} не явялется квадратом числа {SecondNumber}");
    }
}

InputFirstNumber:
Console.WriteLine("Введите первое число.");
bool resultOfParse = int.TryParse(Console.ReadLine(), out int FirstNumber);

if (resultOfParse)
{
    Console.WriteLine();
}
else
{
    Console.WriteLine("Некоректный ввод, попробуйет снова");
    goto InputFirstNumber;
}

InputSecondNumber:
Console.WriteLine("Введите второе число.");
resultOfParse = int.TryParse(Console.ReadLine(), out int SecondNumber);
if (resultOfParse)
{
    Console.WriteLine();
}
else
{
    Console.WriteLine("Некоректный ввод, попробуйте снова.");
    goto InputSecondNumber;
}


CheckingSquare(FirstNumber, SecondNumber);
CheckingSquare(SecondNumber, FirstNumber);



//По двум заданным числам проверять является ли первое квадратом второго 

Console.WriteLine("Введите первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());

double squareSecondNumber = Math.Pow(secondNumber, 2);

if (firstNumber == squareSecondNumber)
{
    Console.WriteLine("Первое число является квадратом второго.");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго.");
}


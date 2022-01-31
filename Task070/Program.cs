// Найти сумму цифр числа Рекурсия

Console.Clear();
int number = new Random().Next(10, 999);

int SumOfDigits (int number)
{
    if (number < 10) return number;
    else return number % 10 + SumOfDigits(number / 10);
}

int sum = SumOfDigits(number);
Console.WriteLine($"Число: {number}.");
Console.WriteLine($"Сумма цифр числа {number} = {sum}.");
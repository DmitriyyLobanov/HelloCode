
// Даны два числа. Показать большее и меньшее число.

Console.WriteLine("Введите первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    Console.WriteLine($"Первое число больше второго, {firstNumber} > {secondNumber}");
}
else
{
    Console.WriteLine($"Второе число больше первого, {secondNumber} > {firstNumber}");
}

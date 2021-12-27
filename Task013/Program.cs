// Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.WriteLine("Введите делимое целое число:");
int firstNumber = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите целочисленный делитель:");
int secondNumber = Int32.Parse(Console.ReadLine());

if (firstNumber % secondNumber == 0) Console.WriteLine($" Число {firstNumber} кратно числу {secondNumber}");
else 
{
    Console.WriteLine($"Остаток от деления числа {firstNumber} на число {secondNumber} равен числу {firstNumber % secondNumber}");
}

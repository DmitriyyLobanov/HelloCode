// Определить количество цифр в числе



Console.Clear();
InputNumber:
Console.WriteLine("Введите число.");
bool ResultOfParse = int.TryParse(Console.ReadLine(), out int number);
if (ResultOfParse)
{
    string check = Convert.ToString(number);
    Console.WriteLine($"Количество цифр во введённом числе {number} равно {check.Length}.");
}
else
{
    Console.WriteLine("Некорректный ввод, попробуйте снова.");
    goto InputNumber;
}


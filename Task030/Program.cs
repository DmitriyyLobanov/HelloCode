// Показать кубы чисел, заканчивающихся на четную цифру

Console.Clear();
Console.WriteLine("Введите число:");
bool ResultOfParse = int.TryParse(Console.ReadLine(), out int number);
while (ResultOfParse == false)
{
    Console.WriteLine("Некорректный ввод, попробуйте снова.");
    ResultOfParse = int.TryParse(Console.ReadLine(), out number);
}

string TextNumber = Convert.ToString(number);
if (char.GetNumericValue(TextNumber[TextNumber.Length - 1]) % 2 == 0)
{
    double Result = Math.Pow(char.GetNumericValue(TextNumber[TextNumber.Length - 1]), 3);
    Console.WriteLine($"Число {number} заканчивается на чётную цифру и её куб равен {Result}.");
}
else
{
    Console.WriteLine($"Число {number} заканчивается на нечётную цифру.");
}

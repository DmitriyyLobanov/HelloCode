// Подсчитать сумму цифр в числе

Console.Clear();
InputNumber:
Console.WriteLine("Введите число.");
bool ResultOfParse = int.TryParse(Console.ReadLine(), out int number);
if (ResultOfParse)
{
    string array = Convert.ToString(number);
    double Sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        Sum = Sum + char.GetNumericValue(array[i]);
        //Console.WriteLine(array[i]);
    }
    Console.WriteLine($"Сумма всех цифр в числе {number} равна {Sum}.");
}
else
{
    Console.WriteLine("Некорректный ввод, попробуйте снова.");
    goto InputNumber;
}



// Определить сколько чисел больше 0 введено с клавиатуры


int CountPositive = 0;
int CountNegative = 0;
string s = string.Empty;
Console.WriteLine("Введите числа через ENTER, если вы завершили ввод чисел введите q.");



while (s != "q")
{
    s = Console.ReadLine();
    bool ResultOfParse = int.TryParse(s, out int number);
    if (number > 0)
    {
        CountPositive++;
    }
    if (number < 0)
    {
        CountNegative++;
    }
}

Console.WriteLine($"Количество положительных чисел = {CountPositive}, отрицательных = {CountNegative}");

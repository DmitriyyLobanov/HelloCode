// Программа проверяет пятизначное число на палиндром.

Console.Clear();
void CheckPalindrome(int arg)
{
    string number = Convert.ToString(arg);
    char[] array = number.ToCharArray();
    Array.Reverse(array);
    string InvertedNumber = new string(array);

    bool result = number.Equals(InvertedNumber);
    if (result)
    {
        Console.WriteLine($"Число {arg} является палиндромом.");
    }
    else
    {
        Console.WriteLine($"Число {arg} не является палиндромом.");
    }
}


inputNumber:
Console.WriteLine("Введите число:");
bool ResultOfParse = Int32.TryParse(Console.ReadLine(), out int number);
if (ResultOfParse)
{
    CheckPalindrome(number);
}
else
{
    Console.WriteLine("Некорректный ввод, попробуйте снова.");
    goto inputNumber;
}

// Показать натуральные числа от 1 до N, N задано  Рекурсия.
int N = new Random().Next(1, 21);

string SequenceRec (int startNumber, int lastNumber)
{
    if (startNumber <= lastNumber) return $"{startNumber}" + ' ' + SequenceRec(startNumber + 1, lastNumber);
    else return string.Empty;
}

Console.WriteLine($"Последнее число последовательности чисел (N) = {N}.");
Console.WriteLine(SequenceRec(1, N));


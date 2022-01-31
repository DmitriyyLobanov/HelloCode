// Показать натуральные числа от N до 1, N задано Рекурсия

int N = new Random().Next(1, 21);

string ReverseSequenceRec (int startNumber, int lastNumber)
{
    if (startNumber >= lastNumber) return $"{startNumber}" + ' ' + ReverseSequenceRec(startNumber - 1, lastNumber);
    else return string.Empty;
}

Console.WriteLine($"Первое числообратной последовательности чисел (N) = {N}.");
Console.WriteLine(ReverseSequenceRec(N, 1));







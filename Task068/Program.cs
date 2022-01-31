// Показать натуральные числа от M до N, N и M заданы   Рекурсия

Console.Clear();

int M = new Random().Next(1, 5);
int N = new Random().Next(6, 21);

string SequenceRec(int startNumber, int lastNumber)
{
        if (startNumber <= lastNumber) return $"{startNumber}" + ' ' + SequenceRec(startNumber + 1, lastNumber);
        else return string.Empty;
}

Console.WriteLine($"Первое число последовательности чисел (M) = {M}.");
Console.WriteLine($"Последнее число последовательности чисел (N) = {N}.");
Console.WriteLine(SequenceRec(M, N));











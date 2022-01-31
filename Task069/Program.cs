// Найти сумму элементов от M до N, N и M заданы Рекурсия


Console.Clear();

int M = new Random().Next(1, 5);
int N = new Random().Next(6, 21);

int SumNumbersRec(int startNumber, int lastNumber)
{
        if (startNumber == lastNumber) return startNumber;
        else return lastNumber += SumNumbersRec(startNumber, lastNumber - 1);
}

Console.WriteLine($"Первое число последовательности чисел (M) = {M}.");
Console.WriteLine($"Последнее число последовательности чисел (N) = {N}.");
int sum = SumNumbersRec(M, N);
Console.WriteLine($"Сумма элементов в последовательности = {sum}.");


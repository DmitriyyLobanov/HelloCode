// Написать программу показывающую первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем
Console.Clear();
int N = new Random().Next(5, 10);

int FiboSequenceRec(int first, int second, int count)
{
    if (count == 1) return first;
    else if (count == 2) return second;
    else return FiboSequenceRec(first, second, count - 1) + FiboSequenceRec(first, second, count - 2);
}

Console.WriteLine("Введите первое число последовательности.");
bool resultOfParse = int.TryParse(Console.ReadLine(), out int firstNumber);
while (resultOfParse == false)
{
    Console.WriteLine("Неверный ввод, попробуйте снова.");
    resultOfParse = int.TryParse(Console.ReadLine(), out firstNumber);
}

Console.WriteLine("Введите второе число последовательности.");
resultOfParse = int.TryParse(Console.ReadLine(), out int secondNumber);
while (resultOfParse == false)
{
    Console.WriteLine("Неверный ввод, попробуйте снова.");
    resultOfParse = int.TryParse(Console.ReadLine(), out secondNumber);
}

Console.WriteLine();
Console.WriteLine($"Последовательность Фибоначчи, включающая {N} элементов:");

Console.Write('(');
for (int i = 1; i <= N; i++)
{
    Console.Write($"{FiboSequenceRec(firstNumber, secondNumber, i)}");
    if (i != N)
    {
        Console.Write(' ');
    }
}
Console.Write(')');

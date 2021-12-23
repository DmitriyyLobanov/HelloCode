// Выяснить является ли число чётным

Console.WriteLine("Введите проверяемое целое число:");
int number = Int32.Parse(Console.ReadLine());


if (number % 2 == 0)
{
    Console.WriteLine($"Число {number} - чётное");
}
else
{
    Console.WriteLine($"Число {number} - нечетное");
}



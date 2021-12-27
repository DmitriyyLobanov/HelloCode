// Показать последнюю цифру трёхзначного числа


Console.WriteLine("Введите трёхзначное число");
int number = Int32.Parse(Console.ReadLine());

int lastDigit = number % 10;

Console.WriteLine($"Последняя цифра числа {number} - {lastDigit}");

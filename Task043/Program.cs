// Написать программу преобразования десятичного числа в двоичное

Console.Clear();

int number = new Random().Next(1, 100);
Console.WriteLine($"Преобразуемое десятичное число = {number}.");

string s = Convert.ToString(number, 2);
Console.WriteLine($"Его двоичный эквивалент = {s}.");













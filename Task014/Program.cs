// Найти третью цифру числа или сообщить, что её нет

int number = new Random().Next(10, 999);
string numberToString = Convert.ToString(number);
int lenght = numberToString.Length;
int find = 3;

Console.WriteLine($"Заданное число = {number}.");
if (lenght > (find - 1)) Console.WriteLine($"Третья цифра числа {number} = {numberToString[find - 1]}.");
else Console.WriteLine($"В числе {number} нет третьей цифры.");


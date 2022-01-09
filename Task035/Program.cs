// Определить, присутствует ли в заданном массиве, некоторое число 
Console.Clear();
Console.WriteLine("Введите число.");
bool ResultOfParse = int.TryParse(Console.ReadLine(), out int number);
while (ResultOfParse == false)
{
    Console.WriteLine("Некорректный ввод, попробуйте снова.");
    ResultOfParse = int.TryParse(Console.ReadLine(), out number);
}

int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
}
string s = string.Join(", ", array);
Console.WriteLine(s);


bool check = false;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == number)
    {
        check = true;
    }
}
if (check)
{
 Console.WriteLine($"Введенное число {number} присутствует в массиве ({s}).");
}
else
{
    Console.WriteLine($"Введенное число {number} не присутствует в массиве ({s}).");
}



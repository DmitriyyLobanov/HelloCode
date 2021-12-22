//Найти максимальное из трех чисел


Console.WriteLine("Введите первое число: ");
int firstNumber = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNumber = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int thirdNumber = Int32.Parse(Console.ReadLine());
int max = firstNumber;

if (secondNumber > max) max = secondNumber;
if (thirdNumber > max) max = thirdNumber;



Console.WriteLine($"Максимаьное из трёх чисел = {max}");
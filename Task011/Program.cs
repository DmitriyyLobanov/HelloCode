// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int number = new Random().Next(10, 99);

int length = (Convert.ToString(number)).Length;
Console.WriteLine($"Число из отрезка [10, 99] = {number}");

if ((Convert.ToString(number)[0] > (Convert.ToString(number)[1])))
{
    Console.WriteLine($"Наибольшая цифра {(Convert.ToString(number)[0])}");
}
else
{
    Console.WriteLine($"Наибольшая цифра {(Convert.ToString(number)[1])}");
}

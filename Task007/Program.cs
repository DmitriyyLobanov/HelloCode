// Показать числа от -N до N
Console.WriteLine("Введите число N: ");
int positiveNumber = Convert.ToInt32(Console.ReadLine());
int negativeNumber = positiveNumber * (-1);


while (negativeNumber <= positiveNumber)
{
    Console.Write(negativeNumber);
    Console.Write(" ");
    negativeNumber++;
}

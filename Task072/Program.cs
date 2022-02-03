// Написать программу возведения числа А в целую степень B

Console.Clear();

int A = new Random().Next(1, 10);
int B = new Random().Next(2, 10);

int ExponentiationRec(int arg, int pow)
{
    if (pow == 0) return 1;
    else return pow = arg * ExponentiationRec(arg, pow - 1);
}


Console.WriteLine($"Результат возведения числа {A} в степень {B} равен: {ExponentiationRec(A, B)}.");
// Дано число. Проверить кратно ли оно 7 и 23

Console.WriteLine("Введите число для проверки на кратность числам 7 и 23.");
int inputNumber = Int32.Parse(Console.ReadLine());

int checkingMultiplicity(int divisibleNumber, int dividerNumber)
{
    int result = 0;
    if (divisibleNumber % dividerNumber == 0)
    {
        result = 0;
        return result;
    }
    else
    {
        result = divisibleNumber % dividerNumber;
        return result;
    }
    
}


int multiplisity7 = checkingMultiplicity(inputNumber, 7);
int multiplisity23 = checkingMultiplicity(inputNumber, 23);

if (multiplisity7 == 0) 
{
    Console.WriteLine($"Число {inputNumber} кратно числу 7.");
}
else 
{
    Console.WriteLine($"Число {inputNumber} не кратно числу 7");
}
if (multiplisity23 == 0)
{
    Console.WriteLine($"Число {inputNumber} кратно числу 23.");
}
else
{
     Console.WriteLine($"Число {inputNumber} не кратно числу 23.");
}

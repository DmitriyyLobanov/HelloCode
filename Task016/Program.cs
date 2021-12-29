// Дано число обозначающее день недели. Выяснить является номер дня недели выходным 


string[] week = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

Console.WriteLine("Введите номер дня недели от 1 до 7:");
int numberOfDay = int.Parse(Console.ReadLine());


if (numberOfDay <= week.Length)
{
    if (numberOfDay == 6 || numberOfDay == 7)
    {
        Console.WriteLine($"День недели под номером {numberOfDay} является выходным днём({week[numberOfDay - 1]}.)");
    }
    else
    {
        Console.WriteLine($"День недели под номером {numberOfDay} не является выходным днём({week[numberOfDay - 1]}.)");
    }
    
}
else
{
    Console.WriteLine("Введено число которому не соответствует день недели.");
}

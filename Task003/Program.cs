
// По заданному номеру дня недели вывести его название.


string[] week = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

Console.WriteLine("Введите номер дня недели от 1 до 7:");
int numberOfDay = int.Parse(Console.ReadLine());
int iteracion = 0;


if (numberOfDay <= week.Length)
{
    Console.WriteLine(week[numberOfDay - 1]);
}
else
{
    Console.WriteLine("Введено число которому не соответствует день недели.");
}



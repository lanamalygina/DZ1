Console.WriteLine("Программа принимает число и сообщает, является ли число чётным");
Console.WriteLine("Введите число: ");
int e = int.Parse(Console.ReadLine());

int number = e % 2;

if(number > 0)
{
    Console.WriteLine("Такое число нечётное");
}
else
{
    Console.WriteLine("Это число чётное");
}
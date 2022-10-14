Console.WriteLine("Программа принимает три числа и выдаёт максимальное из этих чисел.");
Console.WriteLine("Введите первое число: ");
int c = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int d = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int f = int.Parse(Console.ReadLine());

int max = c;

if (c > max) max = c;
if (d > max) max = d;
if (f > max) max = f;

Console.WriteLine("Максимальное число = "+ max);
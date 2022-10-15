Console.WriteLine("Задание №10");
Console.WriteLine("Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");

int number = Convert.ToInt32(Console.ReadLine());

string gg = Convert.ToString(number);

Console.WriteLine("Вторая цифра числа: " + gg[1]);
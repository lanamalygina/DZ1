Console.WriteLine("Задание №13");
Console.WriteLine("Напишите программу,которая выводит третью цифру заданного числа или сообщает что третьей цифры нет. ");
Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

string gg = Convert.ToString(number);

if (gg.Length > 2)
{
    Console.WriteLine("Третья цифра числа: " + gg[2]);
}
else
{
    Console.WriteLine("Ввод не соответствует задаче!\nВведите трехзначное число!");
}
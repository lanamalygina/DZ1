﻿Console.WriteLine("Задание 15 ");

Console.WriteLine("Принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. ");

Console.Write("Введи цифру, обозначающую день недели: ");

int dayNumber = Convert.ToInt32(Console.ReadLine());
void CheckingTheDayOfTheWeek (int dayNumber) 
{
  if (dayNumber == 6 || dayNumber == 7) 
    {
        Console.WriteLine("этот день выходной");
    }
  else if (dayNumber < 1 || dayNumber > 7) 
    {
        Console.WriteLine("это не день недели");
    }
  else 
        Console.WriteLine("этот день не выходной");
}

CheckingTheDayOfTheWeek(dayNumber);

﻿// на вход подаётся два числа, определить является ли одно число квадратом второго


Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);



if (number1 * number1 == number2 || number2 * number2 == number1)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}





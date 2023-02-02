// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.


void Triangle_yes_or_no(int board1, int board2, int board3)
{
    string answer = "нет";
    if (board1 < board2 + board3 && board2 < board1 + board3 && board3 < board1 + board2) answer = "да";
    System.Console.WriteLine(answer);
}


System.Console.WriteLine("Введите три числа, а я скажу может ли сущестовать трегульник!");

System.Console.Write("Введите число 1: ");
int number1 = int.Parse(Console.ReadLine()!);


System.Console.Write("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine()!);


System.Console.Write("Введите число 3: ");
int number3 = int.Parse(Console.ReadLine()!);


Triangle_yes_or_no(number1, number2,  number3);


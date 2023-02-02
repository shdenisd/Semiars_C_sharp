// Задача №14. Работа в группах
// Напишите программу, которая принимает на вход
// число и проверяет, кратно ли оно одновременно
// 7 и 23.
// ● 14 -> нет
// ● 46 -> нет
// ● 161 -> да

int number1 = int.Parse(Console.ReadLine()!);
int number2 = int.Parse(Console.ReadLine()!);

int number3 = number1 % number2;

if (number3 == 0)
{
    Console.WriteLine($" Число {number1} кратно числу {number2}");
}
else
{
    Console.WriteLine($" Число {number1} не кратно числу {number2}, остаток {number3}");
}


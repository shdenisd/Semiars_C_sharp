// С помощью рекурсии написать функцию, которая принимает на вход число и возвращает сумму его чисел
// 456 = 15


int GetSum (int num)
{
    if (num == 0) return 0;
    else return num % 10 + GetSum(num / 10);

}

System.Console.WriteLine(GetSum(1000));
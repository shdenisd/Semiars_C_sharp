// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от M до N.
// M = 1 N = 5 -> "1, 2, 3, 4, 5"
// M = 4 N = 6 -> "4, 5, 6"

// рекурсивно

string FromMToN(int m, int n)
{
    if (n <= m) return $"{ncd}";
    else
    {
        return FromMToN(m, n - 1) + " " + n.ToString();
    }
}

int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

System.Console.WriteLine(FromMToN(m, n));  
// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// рекурсивно


string FromOneToN(int n)
{
    if (n == 1) return "1";
    else
    {
        return FromOneToN(n - 1) + " " + n.ToString();
    }

}


int n = int.Parse(Console.ReadLine());
System.Console.WriteLine(FromOneToN(n));
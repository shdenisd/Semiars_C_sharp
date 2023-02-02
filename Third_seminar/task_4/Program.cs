// Программа получает на вход число N и выводит квадраты всех чисел от 1 до N()

System.Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);


System.Console.Write($"Квадрарты чисел от 1 до {number}: ");

int counter = 1;
while (counter <= number)
{
    System.Console.Write($"{Math.Pow(counter, 2)}");
    if (counter != number) System.Console.Write(", ");
    if (counter == number) System.Console.Write(".");
    counter++;
}

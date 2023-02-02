


int count_number(int number)
{
    int counter = 0;
    while (number != 0)
    {
        number = number / 10;
        counter++;
    }
    return counter;
}

int number = int.Parse(Console.ReadLine()!);

int A = count_number(number);
System.Console.WriteLine($"Кол-во знаков = {A}");

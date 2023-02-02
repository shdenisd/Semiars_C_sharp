


int mult(int arg)
{
    int multiplication = 1;
    for (int i = 1; i <= arg; i++)
    {
        multiplication *= i;
    }
    return multiplication;

}


Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int sum = mult(number);
Console.WriteLine($"Произведение всех чисел от 1 до {number} = {sum}");

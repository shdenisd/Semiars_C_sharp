
void Fibonacci(int num)
{
    int firstFib = 0;
    int secondFib = 1;
    int temp = 0;
    for (int i = 0; i < num; i++)
    {
        System.Console.WriteLine(firstFib);
        temp = secondFib;
        secondFib = firstFib + secondFib;
        firstFib = temp;

    }
}


Fibonacci(3);

// Возведение в ступень рекурсивно


int Pow(int n, int b)
{
    if (b == 0) return 1;
    else
    {
        return n * Pow(n, b - 1);
    }
}

int n = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

System.Console.WriteLine(Pow(n, b));
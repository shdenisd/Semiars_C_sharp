// Написать метод который выводит значения по главной диагонале (0,0; 1,1; 2,2;)



int[,] FillDoubleArray(int str, int col, int minValue, int maxValue)
{
    int[,] doubleArray = new int[str, col];

    for (int i = 0; i < str; i++)
    {
        for (int j = 0; j < col; j++)
        {
            doubleArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return doubleArray;
}

void PrintDoubleArray(int[,] doubleArray)
{
    for (int i = 0; i < doubleArray.GetLength(0); i++)
    {
        for (int j = 0; j < doubleArray.GetLength(1); j++)
        {
            Console.Write($"{doubleArray[i, j]}\t ");
        }
        System.Console.WriteLine();
    }
}


void PrintSumArrayDiagonal(int[,] doubleArray)
{
    int sum = 0;
    int x = doubleArray.GetLength(0) > doubleArray.GetLength(1) ? doubleArray.GetLength(1) : doubleArray.GetLength(0);
    for (int i = 0; i < x; i++)
    {
        sum += doubleArray[i, i];
        if (i + 1 == x)
        {
            Console.Write($"{doubleArray[i, i]} = ");
            continue;
        } 
        Console.Write($"{doubleArray[i, i]} + ");
    }
    System.Console.Write(sum);
}


Console.Clear();
int[,] array = FillDoubleArray(5, 6, 0, 10);
PrintDoubleArray(array);

System.Console.WriteLine();

PrintSumArrayDiagonal(array);
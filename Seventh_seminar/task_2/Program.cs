//Написать метод, который возводит в квадрат элементы двумерного массива у которых оба индекса чётные


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

int[,] ArrayEvenIndexToSquare(int[,] doubleArray)
{
    for (int i = 0; i < doubleArray.GetLength(0); i++)
    {
        for (int j = 0; j < doubleArray.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) doubleArray[i, j] *= doubleArray[i, j]; 
        }
    }
    return doubleArray;
}


Console.Clear();
int[,] array = FillDoubleArray(3, 4, 0, 10);
PrintDoubleArray(array);

System.Console.WriteLine();

int[,] arrayInSquare = ArrayEvenIndexToSquare(array);
PrintDoubleArray(arrayInSquare);




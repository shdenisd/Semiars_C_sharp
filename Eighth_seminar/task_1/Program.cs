int[,] GetDoubleArray(int str, int col, int minValue, int maxValue)
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
    System.Console.WriteLine();
}

void ChangeLastStringWithFirstString(int[,] array)
{
    int str = array.GetLength(0);
    int col = array.GetLength(1);
    int temp = 0;
    for (int i = 0; i < col; i++)
    {
        temp = array[0, i];
        array[0, i] = array[str - 1 , i];
        array[str - 1, i] = temp;
    }
}


int[,] array = GetDoubleArray(3, 4, 0, 10);
PrintDoubleArray(array);
ChangeLastStringWithFirstString(array);
PrintDoubleArray(array);
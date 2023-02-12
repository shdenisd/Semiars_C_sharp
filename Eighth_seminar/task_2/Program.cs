// Напишите программу которая в двумерном массиве будет 
// заменять строки на столбцы, если это невозможно - выводить сообщение об этом.



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

void ReplaceStringAndColumn(int[,] array)
{
    if (array.GetLength(0) != array.GetLength(1))
    {
        System.Console.WriteLine("Братишка, так низя");
        System.Console.WriteLine();
        return;
    }
    else
    {
        int[,] copyArray = (int[,])array.Clone();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = copyArray[j, i];
            }
        }
    }
}

Console.Clear();
int[,] array = GetDoubleArray(4, 3, 0, 10);
PrintDoubleArray(array);
ReplaceStringAndColumn(array);
PrintDoubleArray(array);
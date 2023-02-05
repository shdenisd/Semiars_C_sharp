// Зполнение и вывод двумерного массива случайных чисел по заданным параметрам - кол-во строк, столбцов, диапазон случайных чисел



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



Console.Clear();
int[,] array = FillDoubleArray(3, 4, 0, 10);
PrintDoubleArray(array);




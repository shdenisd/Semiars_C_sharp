// Задача 59: Задайтедвумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7





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

int[] FindIndexisOfMinElInDoubleArray(int[,] doubleArray)
{
    int row = 0;
    int column = 0;
    int[] indexisOfMinElInDoubleArray = new int[2];
    for (int i = 0; i < doubleArray.GetLength(0); i++)
    {
        for (int j = 0; j < doubleArray.GetLength(1); j++)
        {
            if (doubleArray[row, column] > doubleArray[i, j])
            {
                row = i;
                column = j;
            }
        }

    }
    indexisOfMinElInDoubleArray[0] = row;
    indexisOfMinElInDoubleArray[1] = column;
    return indexisOfMinElInDoubleArray;
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

int[,] RemoveRowAndColumn (int[,] array, int[] indexis)
{
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int rowIndex = 0;
    int columnIndex = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == indexis[0]) continue;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            
            if(j == indexis[1]) continue;
            else
            {
                newArray[rowIndex, columnIndex] = array[i, j];
                columnIndex++;
            }
        }
        columnIndex = 0;
        rowIndex++;
    }
    
    
    return newArray;
}


int[,] array = GetDoubleArray(3, 3, 0, 50);
PrintDoubleArray(array);
int[] minIndexis = FindIndexisOfMinElInDoubleArray(array);

System.Console.WriteLine(String.Join(" ", minIndexis)); 

System.Console.WriteLine($"Минимальны элемент в массиве это - {array[minIndexis[0], minIndexis[1]]}");

int[,] newArray = RemoveRowAndColumn(array, minIndexis);

System.Console.WriteLine("Новый массив:");
PrintDoubleArray(newArray);

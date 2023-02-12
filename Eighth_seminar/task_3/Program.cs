// Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.
// 25 мин
// Набор данных Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 } 
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза

// выровнять двумерный массив в одномерный +
// отсортировать одномерный массив 
// посчитать повторающиеся значения



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


void FrequencyDictionaryForSortArray(int[] array)
{
    int counter = 1;
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] != array[i + 1])
        {
            System.Console.WriteLine($"Элемент {array[i]} встречается {counter} раз");
            counter = 1;
        }
        else counter++;
    }
    System.Console.WriteLine($"Элемент {array[array.Length - 1]} встречается {counter} раз");
}

void SortArrayMinimax (int[] array)
{
    int temp = 0;
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] > array[j])
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
}

int[] FromMatrixToArray(int[,] array)
{
    int[] oneDimensional = new int[array.GetLength(0) * array.GetLength(1)];
    int counter = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            oneDimensional[counter++] = array[i, j];
        }
    }
    return oneDimensional;
}


int[,] array = GetDoubleArray(3, 5, 0, 5);

System.Console.WriteLine("Двумерный массив:");
PrintDoubleArray(array);

int[] oneDimensionalArray = FromMatrixToArray(array);

System.Console.WriteLine("Одномерный массив");
System.Console.WriteLine(String.Join(" ", oneDimensionalArray));

SortArrayMinimax(oneDimensionalArray);

System.Console.WriteLine("Отстортированный одномерный массив:");
System.Console.WriteLine(String.Join(" ", oneDimensionalArray));

System.Console.WriteLine("Словарь частотности:");
FrequencyDictionaryForSortArray(oneDimensionalArray);





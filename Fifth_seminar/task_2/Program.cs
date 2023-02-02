int[] fill_array(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
        
    }
    return array;
}

void change_array(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
}



int[] array = fill_array(12, -9, 9);
Console.WriteLine(String.Join(" ", array));

change_array(array);
Console.WriteLine(String.Join(" ", array));
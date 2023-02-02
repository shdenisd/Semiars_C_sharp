//
//
//

int[] fill_array(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
        
    }
    return array;
}

void sum_array(int[] array)
{
    int pos_number = 0;
    int neg_number = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) pos_number += array[i];
        else neg_number += array[i];
    }
    System.Console.WriteLine(pos_number);
    System.Console.WriteLine(neg_number);
}

int[] array = fill_array(12, -9, 9);
sum_array(array);
Console.WriteLine(String.Join(" ", array));
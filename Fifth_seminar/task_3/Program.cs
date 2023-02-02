
// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве. [1 2 3 4 5] -> 5 8 3 [6 7 3 6] -> 36 21


int[] fill_array(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
        
    }
    return array;
}


int[] qwerty(int[] array)
{
    if (array.Length % 2 == 0)
    {
        int[] mult_array = new int[array.Length / 2];
        for (int i = 0; i < array.Length / 2; i++)
        {
            mult_array[i] = array[i] * array[array.Length -1   - i];
        }
        return mult_array;
    }
    else 
    {   
        int[] mult_array = new int[array.Length / 2 + 1];
        for (int i = 0; i < array.Length / 2 + 1; i++)
        {
            if (i == array.Length / 2)
            {
                mult_array[i] = array[array.Length / 2 ];
                break;
            } 
            mult_array[i] = array[i] * array[array.Length -1 - i];
        }
        return mult_array;
    }
    
 
}

int[] array  = fill_array(5, 1, 10);

System.Console.WriteLine(string.Join(" ", array) );

int[] muliple = qwerty(array);

System.Console.WriteLine(string.Join(" ", muliple));
int[] Random_Array()
{
    int[] array_1 = new int[8];
    for (int i = 0; i < array_1.Length; i++)
    {
        array_1[i] = new Random().Next(0, 2);
    }
    return array_1;
}

void Print_Array(int[] array_2)
{
    for (int i = 0; i < array_2.Length; i++)
    {
        Console.Write($"{array_2[i]} ");
    }
}

int[] array_3 = Random_Array();
Print_Array(array_3);

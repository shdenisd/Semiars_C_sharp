// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

string From_int_to_binary(int number)
{
    string result = string.Empty;
    while (number > 0)
    {   
        result = (number % 2).ToString() + result;
        number /= 2;
    }
    return result;
}

string answer = From_int_to_binary(44);

System.Console.WriteLine(answer);

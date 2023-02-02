// программе на вход подаётся номер четверти в плоскости, программа выдаёт какими Х и У могут быть в этой четверти.

int number = int.Parse(Console.ReadLine()!);


switch (number)
{
    case 1:
    {
        System.Console.WriteLine("X > 0 и У > 0");
        break;
    }
    case 2:
    {
        System.Console.WriteLine("X < 0 и У > 0");
        break;
    }
    case 3:
    {
        System.Console.WriteLine("X < 0 и У < 0");
        break;
    }
    case 4:
    {
        System.Console.WriteLine("X > 0 и У < 0");
        break;
    }
    default:
    {
        System.Console.WriteLine("Вы ввели неверное чило!");
        break;
    }
}
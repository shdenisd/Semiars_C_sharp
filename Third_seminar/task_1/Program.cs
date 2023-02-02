// принимает на вход x и y, которые не равны 0, показывает в какой четверти плоскости находится точка

Console.Clear();

System.Console.Write("Введите координату X: ");
int X = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите координату Y: ");
int Y = int.Parse(Console.ReadLine()!);


if (Y > 0)
{
    if (X > 0) Console.WriteLine("Точка лежит в 1 четверти");
    else Console.WriteLine("Точка лежит в 2 четверти");
}
else
{
    if (X > 0) Console.WriteLine("Точка лежит в 4 четверти");
    else Console.WriteLine("Точка лежит в 3 четверти");
}
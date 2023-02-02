// расчитать расстояние между двуя точками в 2Д пространстве
// формула С = квадратиз((х1 - х0)^2 + (у1 - у0)^2)


System.Console.WriteLine("Введите координаты двух точек, а программа посчитает растояние между ними в 2d пространстве");

System.Console.Write("Введите точку x1: ");
int x1 = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите точку y1: ");
int y1 = int.Parse(Console.ReadLine()!);

System.Console.Write("Введите точку x0: ");
int x0 = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите точку y0: ");
int y0 = int.Parse(Console.ReadLine()!);


double distance = Math.Sqrt(Math.Pow(x1 - x0, 2) + Math.Pow(y1 - y0, 2));

System.Console.WriteLine($"Расстояние между точками равно {distance:F2}");


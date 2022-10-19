// Найти точку пересечения 2-х прямых, заданных уравнением y=k1*x + b1, y=k2*x + b2.
Console.WriteLine("Введите число b1");
int b1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число k1");
int k1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число b2");
int b2 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число k2");
int k2 = int.Parse(Console.ReadLine() ?? "0");
int x = (b2 - b1) / (k1 - k2);
//x = int.Parse(Console.ReadLine() ?? "0");
int y = k2 * ((b2 - b1) / (k1 - k2)) + b2;
//y = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("x = " + x);
Console.WriteLine("y = " + y);


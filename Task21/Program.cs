Console.Clear();
Console.WriteLine("Введите координаты Х1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты Y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты Z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты X2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты Y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты Z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Math.Sqrt(Math.Pow(x1- x2, 2) + Math.Pow(y1 - y2, 2) + (Math.Pow(z1-z2, 2))));
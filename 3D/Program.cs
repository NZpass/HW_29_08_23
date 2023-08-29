// Внутри класса Answer напишите метод DistanceBetweenPoints, 
// который принимает на вход координаты двух точек pointA и pointB в виде массива целых чисел,
// и возвращает расстояние между ними в 3D пространстве.

Console.Write("Введите х для первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите y для первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите z для первой точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите х для второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите y для второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите z для второй точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());

int A = x2 - x1;
int B = y2 - y1;
int C = z2 - z1;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine("Расстояние = " + length);
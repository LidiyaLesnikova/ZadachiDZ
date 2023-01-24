// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Введите координаты точки A: ");
Console.Write("X: ");
int AX = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int AY = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int AZ = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
Console.Write("X: ");
int BX = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int BY = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int BZ = Convert.ToInt32(Console.ReadLine());

double r = Math.Sqrt(Math.Pow(AX-BX,2)+Math.Pow(AY-BY,2)+Math.Pow(AZ-BZ,2));//((x1-x2)+(y1-y2)) в квадрате
Console.WriteLine("Расcтояние между точками: "+Math.Round(r,3));
// Задача 43: Напишите программу, которая найдёт точку пересечения двух 
// прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double UserNumber()
{
    double num = Convert.ToInt32(Console.ReadLine());
    return num;
}

Console.WriteLine("Для уравнения k1*x+b1 введите:");
Console.Write("b1: ");
double b1 = UserNumber();
Console.Write("k1: ");
double k1 = UserNumber();
Console.WriteLine("Для уравнения k2*x+b2 введите:");
Console.Write("b2: ");
double b2 = UserNumber();
Console.Write("k2: ");
double k2 = UserNumber();

//k1*x+b1=k2*x+b2 -> k1*x-k2*x=b2-b1 -> x=(b2-b1)/(k1-k2)
//y = k2*x+b2
double x = (b2-b1)/(k1-k2);
double y = k2*x+b2;
Console.WriteLine($"точка пересечения -> ({x}; {y})");

double RandomNumber()
{
    double num = new Random().Next(-10,10);
    return num;
}

Console.WriteLine("Случайные значения:");
b1 = RandomNumber();
Console.Write($"b1 = {b1}, ");
k1 = RandomNumber();
Console.Write($"k1 = {k1}, ");
b2 = RandomNumber();
Console.Write($"b2 = {b2}, ");
k2 = RandomNumber();
Console.Write($"k2 = {k2} ");

x = (b2-b1)/(k1-k2);
y = k2*x+b2;
Console.WriteLine($" -> точка пересечения ({x}; {y})");
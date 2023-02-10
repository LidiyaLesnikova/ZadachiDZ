// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите начало M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите окончание N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.Write($"Сумма чисел от {M} до {N} -> {SumNumbers(M, N)}");

int SumNumbers(int M, int N)
{
    if (M==N) return M;
    if (M<N) return M+SumNumbers(M+1,N);
    else return M+SumNumbers(M-1,N);
}
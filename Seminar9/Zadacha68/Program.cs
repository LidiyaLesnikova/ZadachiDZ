// Задача 68: Напишите программу вычисления функции Аккермана с помощью 
// рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите M: ");
int M = InputNumber();
Console.Write("Введите N: ");
int N = InputNumber();

Console.Write($"A({M},{N}) = {FunctionAccerman(M, N)}");

int InputNumber()
{
    int param = Convert.ToInt32(Console.ReadLine());
    while (param < 0)
    {
        Console.Write("Ошибка ввода, введите положительное число: ");
        param = Convert.ToInt32(Console.ReadLine());
    }
    return param;
}

int FunctionAccerman(int M, int N)
{
    if (M == 0) return N + 1;
    if (N == 0) return FunctionAccerman(M - 1, 1);
    return FunctionAccerman(M-1, FunctionAccerman(M, N-1));
}
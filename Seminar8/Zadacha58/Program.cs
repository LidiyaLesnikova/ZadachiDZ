// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц. Например, даны 2 матрицы:
// 2 4 | 3 4 => 2*3 + 4*3 = 18   2*4 + 4*3 = 20
// 3 2 | 3 3 => 3*3 + 2*3 = 15   3*4 + 2*3 = 18          
// Результирующая матрица будет:
// 18 20
// 15 18
int m = new Random().Next(3, 5);
int n = new Random().Next(3, 5);
while (m != n) n = new Random().Next(3, 5);

Console.WriteLine("Первая матрица:");
int[,] arr1 = FillArray(m, n);
PrintArray(arr1);
Console.WriteLine("Вторая матрица:");
int[,] arr2 = FillArray(m, n);
PrintArray(arr2);
Console.WriteLine("Произведение двух матриц:");
int[,] arrMulti = MultiplicationArray(arr1, arr2);
PrintArray(arrMulti);

int[,] MultiplicationArray(int[,] array1, int[,] array2)
{
    int[,] multArray = new int[array1.GetLength(0), array1.GetLength(1)];

    for (int k = 0; k < array1.GetLength(1); k++)
    {
        for (int i = 0; i < multArray.GetLength(1); i++)
        {
            int multNumber = 0;
            for (int j = 0; j < array2.GetLength(0); j++)
            {
                multNumber += array1[k, j] * array2[j, i];
                Console.Write($"{array1[k, j]}*{array2[j, i]} + ");
            }
            Console.Write($"\b\b = {multNumber}    ");
            multArray[k,i] = multNumber;
        }
        Console.WriteLine();
    }
    return multArray;
}

int[,] FillArray(int row, int col)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],4}");
        }
        Console.WriteLine();
    }
}
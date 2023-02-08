﻿// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
Console.Write("Введите размер массива (количество строк и столбцов): ");
int kol = Convert.ToInt32(Console.ReadLine());
while (kol<4)
{
    Console.Write("Некорректный размер (от 4 и более), введите заново: ");
    kol = Convert.ToInt32(Console.ReadLine());
}
int[,] arr = FillArray(kol, kol);
PrintArray(arr);

int[,] FillArray(int row, int col)
{
    int[,] array = new int[row, col];
    int count = 1;
    int kolStep = array.GetLength(0)/2;
    if (array.GetLength(0)%2==1) kolStep++;
    for (int i = 0; i < kolStep; i++)
    {
        //right
        for (int j = i; j < (array.GetLength(1)-i); j++)
        {
            array[i, j] = count;
            count++;
        }
        //down
        for (int j = i+1; j < array.GetLength(0)-i; j++)
        {
            array[j, array.GetLength(1)-1-i] = count;
            count++;
        }
        //left
        for (int j = array.GetLength(1)-2-i; j >= i; j--)
        {
            array[array.GetLength(1)-1-i, j] = count;
            count++;
        }
        //up
        for (int j = array.GetLength(0)-2-i; j > i; j--)
        {
            array[j, i] = count;
            count++;
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
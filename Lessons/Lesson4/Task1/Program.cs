﻿// Создать двумерный массив с размерами
// 3 x 5, состоящий из целых чисел
// • Вывести его элементы на экран

int [,] CreateMatrix (int rowCount, int columsCount)
{
int[,] matrix = new int[rowCount, columsCount];
Random rnd = new Random(); // вынесли за пределы цикла, тк будет создаваться новый при каждой итерации
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = rnd.Next(1, 10);
    }
}
return matrix;
}

void ShowMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} "); //интерполяция строк
    }
    Console.WriteLine();
}
}

int[,] matrix= CreateMatrix(4, 5);
ShowMatrix(matrix);
﻿
int[,,] GetRndMatrix(int dimension, int rows, int columns, int min, int max)
{
    int[,,] matrix = new int[dimension, rows, columns];
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[k, i, j] = new Random().Next(min, max);
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
        Console.WriteLine();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[k, i, j]}({k},{i},{j})  ");
            }
            Console.WriteLine();
        }
    }
}

PrintMatrix(GetRndMatrix(3,3,3,0,10));
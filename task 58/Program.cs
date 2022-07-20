int[,] GetRndMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] matrix1 = GetRndMatrix(3, 4, 0, 10);
int[,] matrix2 = GetRndMatrix(4, 3, 0, 10);

PrintMatrix(matrix1);
System.Console.WriteLine("------------------");
PrintMatrix(matrix2);

int[,] MultiplicMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix2.GetLength(1), matrix1.GetLength(0)];
    
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        if (matrix1.GetLength(1) != matrix2.GetLength(0))
            {
                System.Console.WriteLine("Умножение матриц не возможно!");break;
            }
        for (int k = 0; k < matrix2.GetLength(1); k++)
        {
            for (int m = 0; m < matrix2.GetLength(0); m++)
            {
                resultMatrix[i, k] += matrix1[i, m] * matrix2[m, k]; 
            }           
        }        
    }
    return resultMatrix;
}

System.Console.WriteLine("------result------");

PrintMatrix(MultiplicMatrix(matrix1, matrix2));
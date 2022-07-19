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

int[,] matrix1 = GetRndMatrix(2, 2, 0, 10);
int[,] matrix2 = GetRndMatrix(2, 2, 0, 10);

PrintMatrix(matrix1);
System.Console.WriteLine("---------------");
PrintMatrix(matrix2);

int[,] MultiplicMatrix(int[,] matrix1, int[,] matrix2)
{
int[,] resultMatrix = new int[matrix2.GetLength(0), matrix1.GetLength(1)];
    int k = 0;
    int n = 0;
    for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                resultMatrix[k, n] += matrix1[i, j] * matrix2[j, i];
            }
            n++;          
        }
        k++;
     return resultMatrix;
}

System.Console.WriteLine("------result------");
int[,] resmatr = new int[2,2];
resmatr = MultiplicMatrix(matrix1,matrix2);
PrintMatrix(resmatr);
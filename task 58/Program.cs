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
    int n = 0;
    int o = 0; 
                        for (i=0; i<matrix1.GetLength(0))
                        {
                            for (k=0; k<matrix2.GetLength(1))
                                {
                                for (m=0; m<matrix2.GetLength(0); m++)
                                    {
                                    resultMatrix[n,o] += matrix1[i,m] * matrix2[m,k]; //resultMatrix[i,k] и удалить 46-50стр
                                    }
                                o++;
                                if (o == 3) {o = 0;}
                                }
                            n++;
                            if (n == 3) {n = 0;}
                        }   
    return resultMatrix;
}


System.Console.WriteLine("------result------");
int[,] resmatr = new int[2,2];
resmatr = MultiplicMatrix(matrix1,matrix2);
PrintMatrix(resmatr);

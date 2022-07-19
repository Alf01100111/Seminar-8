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

int[,] matrix = GetRndMatrix(4,4,0,10);
PrintMatrix(matrix);
int temp = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int k = j+1; k < matrix.GetLength(1); k++)
        {
            if (matrix[i,j] > matrix[i,k])   //сортировка пузырьком каждой строки.
            {
                temp = matrix[i,j];
                matrix[i,j] = matrix[i,k];
                matrix[i,k] = temp;
            }
        }
    }
}

System.Console.WriteLine("матрица с отсортированными строками");
PrintMatrix(matrix);
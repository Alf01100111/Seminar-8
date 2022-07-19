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

int[,] matrix = GetRndMatrix(5,5,0,10);
PrintMatrix(matrix);

int[] arrayWithSum = new int[matrix.GetLength(1)];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        arrayWithSum[i] += matrix[i,j];
    }
}

int FindMinElemPos(int[] array)
{   int min = array[0];
    int minpos = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            minpos = i;
        }
    }
    return minpos;
}

System.Console.WriteLine($"Строка с минимальной суммой элементов - {FindMinElemPos(arrayWithSum)+1}");
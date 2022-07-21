
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

int n = 4;
int[,] matrix = new int[n, n];
int num = 1;

for (int i = 0; i < n / 2; i++)
{
    for (int j = i; j < n - i; j++) { matrix[i, j] = num++; }
    for (int k = i + 1; k < n - i; k++) { matrix[k, n - 1 - i] = num++; }
    for (int j = n - i - 2; j >= i; j--) { matrix[n - 1 - i, j] = num++; }
    for (int k = n - 2 - i; k > i; k--) { matrix[k, i] = num++; }
}

PrintMatrix(matrix);
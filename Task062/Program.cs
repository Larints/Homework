// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] SomeMatrix = new int[4, 4];
FillArray(SomeMatrix);
PrintArray(ResultMatrix(SomeMatrix));

int[,] ResultMatrix(int[,] array)
{
    int[,] resultMatrix = new int[4, 4];
    int count = 1;
    int n = 4;
    int rowStart = 0, colStart = 0;

    while (count <= n * n)
    {
        for (int j = colStart; j < n - colStart; j++)
        {
            resultMatrix[rowStart, j] = count++;
        }

        for (int i = rowStart + 1; i < n - rowStart; i++)
        {
            resultMatrix[i, n - colStart - 1] = count++;
        }

        for (int j = n - colStart - 2; j >= colStart; j--)
        {
            resultMatrix[n - rowStart - 1, j] = count++;
        }

        for (int i = n - rowStart - 2; i > rowStart; i--)
        {
            resultMatrix[i, colStart] = count++;
        }

        rowStart++;
        colStart++;
    }

    return resultMatrix;
}

int[,] FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = 0;
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
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

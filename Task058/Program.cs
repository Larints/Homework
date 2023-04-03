// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] firstMatrix = new int[2, 2];
int[,] secondMatrix = new int[2, 2];
FillArray(firstMatrix);
FillArray(secondMatrix);
Console.WriteLine("Первая матрица:");
PrintArray(firstMatrix);
Console.WriteLine("Вторая матрица:");
PrintArray(secondMatrix);
Console.WriteLine("Результативная матрица");
PrintArray(NewMatix(firstMatrix, secondMatrix));

int[,] FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5);
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

int[,] NewMatix(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] newMatrix = new int[2, 2];
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
           int sum = 0;
           for (int k = 0; k < firstMatrix.GetLength(1); k++)
           {
            sum += firstMatrix[i,k] * secondMatrix[k,j];
            newMatrix[i,j] = sum;
           }
        }
    }
    return newMatrix;
}





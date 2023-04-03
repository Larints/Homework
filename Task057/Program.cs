// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

Console.Write("Введите количествро строк:");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количествро столбцов:");
int cols = int.Parse(Console.ReadLine()!);
int[,] SomeArray = new int[rows, cols];
FillArray(SomeArray);
PrintArray(SomeArray);
Console.WriteLine();
CountList(SomeArray);

int[,] FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
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

void CountList(int[,] array)
{
    int[] counts = new int[10];

    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            counts[array[i, j]]++;
        }
    }
    for (int i = 0; i < counts.Length; i++)
    {
        if (counts[i] > 0)
        {
            Console.WriteLine($"{i} встречается {counts[i]} раз(а)");
        }
    }
}
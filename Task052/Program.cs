// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

int[,] SomeArray = new int[4, 4];

FillArray(SomeArray);
PrintArray(SomeArray);
GetAverage(SomeArray);



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

void GetAverage(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    for (int j = 0; j < cols; j++)
    {
        double sum = 0;

        for (int i = 0; i < rows; i++)
        {
            sum += array[i, j];
        }

        double average = sum / rows;
        Console.WriteLine($"Среднее арифметическое столбца {j}: {average}");
    }
}

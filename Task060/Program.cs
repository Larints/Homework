// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int cols = int.Parse(Console.ReadLine()!);
Console.Write("Введите значения глубины: ");
int depth = int.Parse(Console.ReadLine()!);
int[] SomeNumbers = new int [rows * cols * depth];
int [,,] SomeArray = new int [rows, cols, depth];
SomeNumbers = Randomizer(SomeNumbers);
SomeArray = FillArray(SomeArray, SomeNumbers);
PrintArray(SomeArray);


int[] Randomizer (int[] array)
{
    int count = 10; 
    for (int i =0; i < array.Length; i++)
    {
        array[i] = count;
        count +=7/2;
    }
    return array;
}

int [,,] FillArray (int [,,] firstArray, int [] secondArray)
{
    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        for (int j = 0; j < firstArray.GetLength(1); j++)
        {
            for (int k = 0; k < firstArray.GetLength(2); k++)
            {
                firstArray[i, j, k] = secondArray[i * firstArray.GetLength(1) * firstArray.GetLength(2) + j * firstArray.GetLength(2) + k];
            }
        }
    }
    return firstArray;
}

void PrintArray (int [,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"Построчное выведение значения {array[i,j,k]} ({i}{j}{k})");
            }
        }
    }
}

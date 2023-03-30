// Задача 50. Напишите программу, которая на вход принимает два числа
// (строка, столбец), проверяя есть ли такая позиция в двумерном массиве 
// и возвращает сообщение о том, что оно найдено, 
// а также какое число стоит на этом месте или же указание, 
// что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// i = 1, j = 3 -> Такой элемент есть: 3
// i = 4, j = 2 -> такого элемента в массиве нет


Console.WriteLine("Введите номер искомой строки: ");

int row = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите номер искомого столбца: ");

int column = int.Parse(Console.ReadLine()!);

int[,] SomeArray = new int[5, 5];

FillArray(SomeArray);
PrintArray(SomeArray);
SearhcingElement(SomeArray);



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

void SearhcingElement(int[,] array)
{
    if (row < array.GetLength(0) && column < array.GetLength(1))
    {
        Console.WriteLine($"Такой элемент есть: {array[row, column]}");
    }
    else
    {
        Console.WriteLine("Такого элемента в массиве нет");
    }
}




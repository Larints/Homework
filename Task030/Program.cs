// Домашнее задание
// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] GetRandomArray(int size, int minValue, int maxValue)  // Метод заполнения массива случайными числами
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}

int SearchEvenNumbers(int[] array) // Метод поиска четных чисел в массиве
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}


int[] array = GetRandomArray(10, 100, 999); // Инциализируем трёхзначный массив
Console.WriteLine($"Заполненный массив -> [{String.Join(",", array)}], ");
Console.WriteLine($"Количество четных чисел в массиве -> {SearchEvenNumbers(array)}");
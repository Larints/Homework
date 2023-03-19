// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)

int [] FillArray (int size)
{
    int [] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next();
    }
    return result;
}

int number = 8;
int[] array = FillArray(number);
Console.WriteLine($"[{String.Join("; ", array)}] ");
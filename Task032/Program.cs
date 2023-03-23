// Задача 3: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

double[] FillArray(int size) // Метод заполнения массива случайными значениями
{
    double[] resultArray = new double[size];
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = Math.Round(new Random().NextDouble() * 100, 1);

    }
    return resultArray;
}

double FindMinMaxResult(double[] array) // Метод поиска разницы
{
    double max = array[0];
    double min = array[0];
    double result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    Console.WriteLine($"Заполненный массив -> [{String.Join("; ", array)}]");
    Console.WriteLine($"Макисмальное значение массива -> {max}");
    Console.WriteLine($"Минимальное значение массива -> {min}");
    return result = max - min;
}


double[] array = FillArray(10);
Console.WriteLine($"Разница между максимальным и минимальным значением равна -> {FindMinMaxResult(array)}");


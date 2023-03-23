// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите **сумму элементов, стоящих на нечётных индексах**.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArray(int size, int minValue, int maxValue) // Метод заполнения массива случайными числами
{
    int[] resultArray = new int[size];
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return resultArray;
}

int SumOfOddNumbers(int[] array) // Метод поиска суммы элементов стоящих нечетных индексах
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
        Console.WriteLine($"{sum}, текущее состояние суммы");
    }
    return sum;
}

int[] array = FillArray(10, -10, 10);
Console.WriteLine($"Заполненный массив -> [{String.Join(",", array)}]");
Console.WriteLine($"Сумма всех элементов стоящих на нечетных индексах -> {SumOfOddNumbers(array)}");
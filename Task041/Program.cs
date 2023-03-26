// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int CountOfNumbers (int [] array)
{
    int count = 0;
    foreach (int el in array)
    {
        if (el > 0) count ++;
    }
    return count;
}

Console.Write("Введите любые числа: ");
string[] array = Console.ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
Console.WriteLine($"Cписок введенных чисел -> {String.Join(", ", array)}");
int[] intArray = Array.ConvertAll(array, int.Parse);
Console.WriteLine($"Количество введенных числе больше 0 -> {CountOfNumbers(intArray)}");
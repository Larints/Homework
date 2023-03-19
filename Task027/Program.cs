// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int SumOfNumber(int SomeNumber)
{

    int sum = 0;
    while (SomeNumber != 0)
    {
        sum += SomeNumber % 10;
        SomeNumber = SomeNumber / 10;
    }
    return sum;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine($"Сумма всех чисел в введенном значении равна -> {SumOfNumber(number)}");


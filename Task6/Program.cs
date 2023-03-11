// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


Console.WriteLine("Введите число: ");
string number = Console.ReadLine()!;
if (number.Length >= 3)
{
    Console.WriteLine($"Третья цифра во введенном числе -> {number[2]}");
}
else
{
    Console.WriteLine($"Третьей цифры в {number} нет ");
}


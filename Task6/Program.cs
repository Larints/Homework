// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// Строковый метод
// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine()!;
// if (number.Length > 2)
// {
//     Console.WriteLine($"Третья цифра во введенном числе -> {number[2]}");
// }
// else
// {
//     Console.WriteLine($"Третьей цифры в {number} нет ");
// }

int number = Convert.ToInt32(Console.ReadLine()!);
if (number > 99)
{
    while (number > 999)
    {
        number /=10;
    }
    System.Console.WriteLine(number % 10);
}
else 
{
    System.Console.WriteLine("Введенно неверное число")
}
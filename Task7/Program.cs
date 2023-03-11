// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите день недели: ");
int number = int.Parse(Console.ReadLine()!);
if (number > 7)
{
    Console.WriteLine("Увы такого дня недели нет");
}
if (number < 6){
    Console.WriteLine("Сегодня будничный день");
}
else
{
    if (number == 6)
    {
        Console.WriteLine("Сегодня суббота");
    }
    if (number == 7)
    {
        Console.WriteLine("Сегодня воскресенье");
    }
}
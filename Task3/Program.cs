// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка(number%2==0)).

Console.WriteLine("Программа для определения четности");
Console.Write ("Введите значение: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение: ");

if (number % 2 == 0)
{
    Console.WriteLine($"Введеное значение {number} является четным");

}
else
{
    Console.WriteLine($"Введеное значение {number} является нечетным");
}

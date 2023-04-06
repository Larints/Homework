﻿// Задача 68: **Выполнить с помощью рекурсии**.Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.Write("Ввелиие значение m: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Ввелиие значение n: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(AckermannFunction(m,n));

int AckermannFunction(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return AckermannFunction(m - 1, 1);
    if (m > 0 && n > 0) return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    return 0;
}

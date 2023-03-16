// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// Console.WriteLine("Программа определяющая четные числа от 1 до Введенного числа");
// Console.WriteLine("Введите число: ");
// int N = int.Parse(Console.ReadLine()!);
// int A = 1;

// while (A <= N)
// {
//     if (A%2 == 0)
//     Console.Write($"{A} ");
//     A++;
// }

Console.WriteLine("Программа определяющая четные числа от 1 до Введенного числа");
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

for (int index = 1; index <= a; index += 2)
{
    System.Console.Write(index + " ");
}




// Console.WriteLine("Программа определяющая четные числа от 1 до Введенного числа");
// Console.WriteLine("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int A = 2;

// while (A <= N)
// {
//     if (A%2 == 0)
//     Console.Write($"{A} ");
//     A++;
// }
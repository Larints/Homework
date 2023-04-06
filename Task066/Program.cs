// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите значение М:");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение N:");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Сумма всех значений в заданном промежутке -> {RandomNumbersSumm(M, N)}");

int RandomNumbersSumm(int M, int N)
{
    int sum = 0;
    if (M == 0 && N == 0) return 0;
    if (M > 0 && N == 0 || M == 0 && N > 0) return 1;
    if (M == N) return N;
    if (M > N) return M + RandomNumbersSumm(M-1,N);
    else sum = N + RandomNumbersSumm(M, N - 1);
    return sum;
}
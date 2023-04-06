// Задача 64: Выполнить с помощью рекурсии.Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Ввелиие значение N : ");
int N = int.Parse(Console.ReadLine()!);
int M = 1;

Console.WriteLine(PrintNumbers(N,M));

// Метод
string PrintNumbers(int N, int M = 1){
    if(M==N) return M.ToString();
    return (N + " " + PrintNumbers(N - 1));
}



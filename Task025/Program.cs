// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. (Задачи, решенные через Math.Pow, не будут считаться правильными, так как задача стоит в том, чтобы написать цикл)

// 3, 5 -> 243 (3⁵)

int Pow(int number_1, int number_2)
{
    int i = 1;
    int pow = 0;
    int N = number_1;
    while (i < number_2)
    {
        pow = N * number_1;
        number_1 = pow;
        i++;
    }
    return pow;
}


Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Pow(A, B));





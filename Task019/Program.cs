// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Строковый метод

System.Console.Write("Введите пятизначное число ");
string number = Console.ReadLine()!;

void PalindromTest()
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine("Введенное число является палиндромом");
    }
    else
    {
        Console.WriteLine("Введенное число не является палиндромом");
    }
}

if (number.Length == 5)
{

    PalindromTest();
}
else
{
    Console.WriteLine("Введенное число не является пятизначным");
}


// Математический метод

System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
void Palindrom(int somenumber)
{
    if (somenumber / 10000 == somenumber % 10)
    {
        somenumber = somenumber / 10;
        somenumber = somenumber % 1000;
    }
    if (somenumber / 100 == somenumber % 10) Console.WriteLine("Число является палиндромом");
    else Console.WriteLine("Число не является палиндромом");

}

if (num > 9999 && num < 100000)
{
    Palindrom(num);
}
else
{
    System.Console.WriteLine("Вы ввели не пятизначное число");
}

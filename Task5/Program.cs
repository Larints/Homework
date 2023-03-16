// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Строковый метод

// Console.WriteLine("Введите трёхзначное число: ");
// string number = Console.ReadLine()!;
// if (number.Length  == 3){
//     Console.WriteLine($"Вторая цифра введенного числа {number[1]}");
// }
// else{
//     Console.WriteLine("Введенно неверное число");
// }

// Математический метод

Console.WriteLine("Генерируем случайное трёхзначное число: ");
int num = new Random().Next(100, 1000);
Console.WriteLine($" Выводим это число -> {num}");
int result = num % 100;
int finish = result / 10;
Console.WriteLine($"Вторая цифра введенного числа -> {finish}");

// Random rand = new Random();                    - верная запись рандома
// int number = rand.Next(100,1000);

// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5            782 -> 8             918 -> 1

Console.Clear();
Console.WriteLine("Введите трезначное число");
int num = int.Parse(Console.ReadLine());
int number = num % 100 / 10;
Console.WriteLine($"Второе число = {number}");

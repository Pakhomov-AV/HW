// Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine (" Введите число ");
int number = int.Parse(Console.ReadLine());

int i = 0;
while ( i<number-1)
{
i = i+2;
Console.Write (i+ " ");
}
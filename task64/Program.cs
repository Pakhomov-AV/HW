// Задача 64: Задайте значение N. Напишите программу,
// которая выведет все чётные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "4, 2"
// N = 8 -> "8, 6, 4, 2,"

void Main()
{
    Console.WriteLine("Введите число: ");
    int n = int.Parse(Console.ReadLine()!);
    Numbers(n);
}

void Numbers(int n)
{
    if (n <= 1)
        return;
    else
    {
        if (n % 2 == 0)
        {
            Console.Write($"{n} ");
            Numbers(n - 2);
        }
        else
        {
            n--;
            Console.Write($"{n} ");
            Numbers(n - 2);
        }

    }
}

Main();
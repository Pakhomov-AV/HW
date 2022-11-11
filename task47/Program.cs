//Задача 47. Задайте двумерный массив размером m×n,
 //заполненный случайными вещественными числами.

void Main()
{
    Console.WriteLine("Введите количество строк масива");
    int m = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов масива");
    int n = int.Parse(Console.ReadLine());

    double[,] result = InputArray(m, n);
    WriteArray(result, m, n);
}

double[,] InputArray(int m, int n)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; ++i)
    {
        for (int j = 0; j < n; ++j)
        {
            Random random = new Random();
            result[i, j] = Math.Round(random.NextDouble(), 3);
        }
    }
    return result;
}

void WriteArray(double[,] result, int m, int n)
{
    for (int i = 0; i < m; ++i)
    {
        for (int j = 0; j < n; ++j)
        {
            Console.Write("{0}{1}:| " + result[i, j] + "\t", i + 1, j + 1);
        }
        Console.WriteLine("");
    }
}
Main();
/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.*/

void Main()
{
    Console.WriteLine("Введите количество строк масива");
    int m = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов масива");
    int n = int.Parse(Console.ReadLine());
    double[,] result = InputArray(m, n);
    WriteArray(result, m, n);
    PositionValue(result, m, n);
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

void PositionValue(double[,] result, int m, int n)
{
    Console.WriteLine("");
    Console.WriteLine("Введите позиции элемента");
    int position_line = int.Parse(Console.ReadLine());
    int position_column = int.Parse(Console.ReadLine());
    if (position_line < m + 1 && position_line > 0 && position_column < n + 1 && position_column > 0)
        Console.WriteLine(result[position_line - 1, position_column - 1]);
    else
        Console.WriteLine(" такого числа в массиве нет ([" + position_line + "," + position_column + "] - это позиция элемента)");
}

Main();
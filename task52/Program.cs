/*Задача 52. Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.*/

void Main()
{
    Console.WriteLine("Введите количество строк масива");
    int m = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов масива");
    int n = int.Parse(Console.ReadLine());
    int[,] result = InputArray(m, n);
    WriteArray(result, m, n);
    ArithmeticMeanColumn(result, m, n);
}

int[,] InputArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; ++i)
    {
        for (int j = 0; j < n; ++j)
        {
            Random random = new Random();
            result[i, j] = random.Next(1, 10);
        }
    }
    return result;
}

void WriteArray(int[,] result, int m, int n)
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

void ArithmeticMeanColumn(int[,] result, int m, int n)
{
    int[] array = new int[n];
    for (int i = 0; i < n; ++i)
    {
        array[i] = 0;
        for (int j = 0; j < m; ++j)
        {
            array[i] += result[j, i];
        }
        Console.Write(Convert.ToDouble(array[i])/Convert.ToDouble(m) + "; ");
    }
}
Main();
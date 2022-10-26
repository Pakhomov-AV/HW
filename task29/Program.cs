// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 2, 4, 9 -> [1, 2, 5, 7, 19, 2, 4, 9 ]
// 6, 1, 33, 2, 93, 15, 424, 0-> [6, 1, 33, 2, 93, 15, 424, 0]


int[] array = new int[8];

ArrayNew(array);

void ArrayNew(int[] array2)
{
    for (int i = 0; i < array2.Length; i++)
    {
        array2[i] = new Random().Next(1, 1000);
        Console.Write(array2[i] + " ");
    }
}
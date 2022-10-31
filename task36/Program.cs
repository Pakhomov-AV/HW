//  Задача 36: Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.
//  [3, 7, 23, 12] -> 19
 
Console.WriteLine("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array1 = new int[size];
ArrayRandomNumbers(array1);
Console.WriteLine("массив: ");
PrintArray(array1);
Console.WriteLine("Сумму элементов, стоящих на нечётных позициях равна: " + SumOfOddElements(array1));

void PrintArray(int[] array1)// Выводит масив
{
    Console.Write("[");
    for(int i = 0; i < array1.Length; i++)
    {
        Console.Write(array1[i]);
        if ( i != array1.Length-1){
          Console.Write(" ");
        }
    }
    Console.WriteLine("]");
}

void ArrayRandomNumbers(int[] array1)//заполняет массив случайными числами 
{
    for(int i = 0; i < array1.Length; i++)
    {
        array1[i] = new Random().Next(1,10);
    }
}

int SumOfOddElements (int[] array1)//сумма нечт. элементов 
{
  int j = 0;
  for (int i = 1; i < array1.Length; i++){
    if (i % 2 != 0)
      j+= array1[i];  
  }
  return j;
}
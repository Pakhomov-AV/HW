//  Задача 38: Задайте массив вещественных чисел.
//  Найдите разницу между максимальным и минимальным элементов массива.
//  [3 7 22 2 78] -> 76
  
int Main()
{
  Console.WriteLine("Введите размер массива:  ");
  int size = Convert.ToInt32(Console.ReadLine());
  if ( size == 0 ){
    return 0;
  }
  double[] array1 = new double[size];
  ArrayRandomNumbers(array1);
  Console.WriteLine("массив: ");
  PrintArray(array1);
  Console.WriteLine("Разницу между максимальным и минимальным элементов массива равна: " + DifferenceMaxMin(array1));
  return 0;
}

void PrintArray(double[] array1)
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

void ArrayRandomNumbers(double[] array1)
{
    for(int i = 0; i < array1.Length; i++)
    {
      if(new Random().Next(0,2) == 0)
        array1[i] = -1*Convert.ToDouble(new Random().Next(1,1000)) / 100;
      else array1[i] = Convert.ToDouble(new Random().Next(1,1000)) / 100;
    }
}

double DifferenceMaxMin (double[] array1)
{
  
  double max = array1[0];
  double min = array1[0];
  for (int i = 0; i < array1.Length; i++){
    if (array1[i] > max)
      max = array1[i];  
    if (array1[i] < min)
      min = array1[i]; 
  }
  double j = max - min;
  return j;
}

Main();
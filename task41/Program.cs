//  Задача 41: Пользователь вводит с клавиатуры M чисел.
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.
//  0, 7, 8, -2, -2 -> 2
 //  1, -7, 567, 89, 223-> 3
 
void Main()
{
  Console.Write("Введите М: ");
  int M = Convert.ToInt32(Console.ReadLine());
  double number;
  int greater_than_zero = 0;
  for (int i =0; i < M;i++){
    number = Convert.ToInt32(Console.ReadLine());
    greater_than_zero = GreaterThanZero(greater_than_zero, number);    
  }
  Console.WriteLine(greater_than_zero);
}
int GreaterThanZero(int greater_than_zero, double number){
    if (number > 0){
    greater_than_zero ++;
  }
  return greater_than_zero;
}
Main();

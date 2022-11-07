//  Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//  b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
 
void Main()
{
  Console.WriteLine("Последоватльно введите значения b1, k1, b2 и k2: ");
  double b1 = Convert.ToInt32(Console.ReadLine());
  double k1 = Convert.ToInt32(Console.ReadLine());
  double b2 = Convert.ToInt32(Console.ReadLine());
  double k2 = Convert.ToInt32(Console.ReadLine());
  IntersectionPoint(b1, b2, k1, k2);
  
}
void IntersectionPoint(double b1, double b2, double k1, double k2){
  double intersection_point_Y = (b2 - b1)/(k1 - k2);
  double intersection_point_X = (intersection_point_Y - b1)/k1;
  Console.Write("( " + intersection_point_X + "; " + intersection_point_Y + " )");
}
Main();
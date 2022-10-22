//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.Write("Введите Х точки А: ");
double ax = int.Parse(Console.ReadLine());
Console.Write("Введите Y точки А: ");
double ay = int.Parse(Console.ReadLine());
Console.Write("Введите Z точки А: ");
double az = int.Parse(Console.ReadLine());

Console.Write("Введите Х точки B: ");
double bx = int.Parse(Console.ReadLine());
Console.Write("Введите Y точки B: ");
double by = int.Parse(Console.ReadLine());
Console.Write("Введите Z точки B: ");
double bz = int.Parse(Console.ReadLine());

double S = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2));

Console.WriteLine($"Расстояние между точками равно {Math.Round(S, 2)}");
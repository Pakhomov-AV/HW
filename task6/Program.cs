// Напишите программу, которая на вход принимает число и выдаёт,
//является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine ( "Введите число" );
int number = int.Parse(Console.ReadLine());
int a = number % 2;

if ( a==0 )
{
    Console.WriteLine ("Число " + number + " является четным");
}
else 
Console.WriteLine ("Число " + number + " не является четным");
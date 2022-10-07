// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Point A: enter coordinate X1: ");
int X1 = int.Parse(Console.ReadLine());
Console.Write("Point A: enter coordinate Y1: ");
int Y1 = int.Parse(Console.ReadLine());
Console.Write("Point A: enter coordinate Z1: ");
int Z1 = int.Parse(Console.ReadLine());
Console.Write("Point B: enter coordinate X2: ");
int X2 = int.Parse(Console.ReadLine());
Console.Write("Point B: enter coordinate Y2: ");
int Y2 = int.Parse(Console.ReadLine());
Console.Write("Point B: enter coordinate Z2: ");
int Z2 = int.Parse(Console.ReadLine());

double distance = Math.Round(Math.Sqrt(Math.Pow((X2-X1),2)+Math.Pow((Y2-Y1),2)+Math.Pow((Z2-Z1),2)),2);

Console.WriteLine($"Distanse between points A and B is {distance}");
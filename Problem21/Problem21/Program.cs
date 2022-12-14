// Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B(2, 1, -7), -> 15.84
//A(7, -5, 0); B(1, -1, 9)-> 11.53
Console.WriteLine("Введите xa: ");
double xa = double.Parse(Console.ReadLine());

Console.WriteLine("Введите ya: ");
double ya = double.Parse(Console.ReadLine());

Console.WriteLine("Введите za: ");
double za = double.Parse(Console.ReadLine());

Console.WriteLine("Введите xb: ");
double xb = double.Parse(Console.ReadLine());

Console.WriteLine("Введите yb: ");
double yb = double.Parse(Console.ReadLine());

Console.WriteLine("Введите zb: ");
double zb = double.Parse(Console.ReadLine());

double ab = Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2);
ab = Math.Sqrt(ab); // корень
ab = Math.Round(ab, 2);//округление
Console.WriteLine($"Длина отрезка {ab}");
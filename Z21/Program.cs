﻿// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
Console.WriteLine("Введите координаду Х точки А:");
int x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаду Y точки А:");
int y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаду Z точки А:");
int z1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаду Х точки B:");
int x2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаду Y точки А:");
int y2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаду Z точки А:");
int z2 = int.Parse(Console.ReadLine()!);

double result;
result = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
Console.WriteLine($"Длина отрезка равна: {result:f2}");



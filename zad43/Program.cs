﻿/* Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.Write("Введите число b1: ");
double b1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число k1: ");
double k1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число b2: ");
double b2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число k2: ");
double k2 = int.Parse(Console.ReadLine()!);


double x = (b1 -b2)/(k2-k1);
double y = k2 * x + b2;


Console.WriteLine($"({x};{y})");
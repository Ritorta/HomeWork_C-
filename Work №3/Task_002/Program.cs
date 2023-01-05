/*
Task №2:
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53


!!! d = √ (х А – х В) 2 + (у А – у В) 2 + (z A - z B) 2 !!!

Math.Pow(a,b) - а числов, b квадрат.
Math.Sqrt(a) - только квадратный корень.

// ---Вариант №1---
// Базовая рабочая программа.

double PointPF (double Ax, double Ay, double Az, double Bx, double By, double Bz)
{
    return Math.Sqrt(Math.Pow((Ax - Bx), 2)  + Math.Pow((Ay - By),2) + Math.Pow((Az - Bz),2));
}


Console.WriteLine("Coordinate A");
Console.Write("First Coordinate Ax: ");
double Ax = Convert.ToDouble(Console.ReadLine());
Console.Write("Second Coordinate Ay: ");
double Ay = Convert.ToDouble(Console.ReadLine());
Console.Write("Third Coordinate Az: ");
double Az = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Coordinate B");
Console.Write("First Coordinate Bx: ");
double Bx = Convert.ToDouble(Console.ReadLine());
Console.Write("Second Coordinate By: ");
double By = Convert.ToDouble(Console.ReadLine());
Console.Write("Third Coordinate Bz: ");
double Bz = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

Console.Write(PointPF(Ax, Ay, Az, Bx, By, Bz));

// ---Вариант №2---
// 
*/


double PointPF (double Ax, double Ay, double Az, double Bx, double By, double Bz)
{
    return Math.Sqrt(Math.Pow((Ax - Bx), 2)  + Math.Pow((Ay - By),2) + Math.Pow((Az - Bz),2));
}


Console.WriteLine("Coordinate A");
Console.Write("First Coordinate Ax: ");
double Ax = Convert.ToDouble(Console.ReadLine());
Console.Write("Second Coordinate Ay: ");
double Ay = Convert.ToDouble(Console.ReadLine());
Console.Write("Third Coordinate Az: ");
double Az = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Coordinate B");
Console.Write("First Coordinate Bx: ");
double Bx = Convert.ToDouble(Console.ReadLine());
Console.Write("Second Coordinate By: ");
double By = Convert.ToDouble(Console.ReadLine());
Console.Write("Third Coordinate Bz: ");
double Bz = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

Console.Write(PointPF(Ax, Ay, Az, Bx, By, Bz));

// Здесь нужно применить оператор для сокращения десятков, ещё не сделано в работе.
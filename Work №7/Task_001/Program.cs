/*
Task №1:
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

*/
// ---Вариант №1---
// 

double[,] RandomDouble2D ()
{
Console.Write("Input row: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input coluns: ");
int colouns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minValue: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maxValue: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

    double[,] array = new double[rows, colouns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colouns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
            array[i,j] = Math.Round(array[i,j], 3);
        }
    }
return array;    
}

void ShowArray2D (double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}



double[,] newArray = RandomDouble2D();
ShowArray2D(newArray);


// https://www.youtube.com/watch?v=g4nGMWwf7OQ
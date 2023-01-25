/*
Task №3:
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

*/
// ---Вариант №1---
// 

double[,] RandomArray2D(int rows, int colouns, int minValue, int maxValue)
{
    double[,] array = new double[rows, colouns];
        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < colouns; j++)
            {
                array[i,j] = new Random().Next(minValue, maxValue + 1);
            }
        }
return array;        
}

void ShowArray2D(double[,] array)
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

double middleSum(double[,] array)
{
double result = 0;
    for(int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for(int j = 0; j < array.GetLength(0); j++)
        
        {
            sum = sum + array[j,i];
            result = sum;
        }
        Console.Write(sum / array.GetLength(0) + " ");
        
    }
    return result / array.GetLength(0);
} 

Console.Write("Input row: ");
int rows = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input coluns: ");
int colouns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minValue: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maxValue: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

double[,] newArray = RandomArray2D(rows, colouns, minValue, maxValue);
ShowArray2D(newArray);
double Sum = middleSum(newArray);
Console.Write($">{Sum}<");


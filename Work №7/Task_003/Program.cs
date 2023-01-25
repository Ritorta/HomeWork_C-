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

int[,] RandomArray2D(int rows, int colouns, int minValue, int maxValue)
{
    int[,] array = new int[rows, colouns];
        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < colouns; j++)
            {
                array[i,j] = new Random().Next(minValue, maxValue + 1);
            }
        }
return array;        
}

void ShowArray2D(int[,] array)
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

int[,] middleSum (int[,] array)
{
    int Sum = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {

        }
    }
return;
} 

Console.Write("Input row: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input coluns: ");
int colouns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minValue: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maxValue: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] newArray = RandomArray2D(row, colouns, minValue, maxValue);
ShowArray2D(newArray);

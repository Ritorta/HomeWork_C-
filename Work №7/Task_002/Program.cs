/*
Task №2:
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> элемента с такими индексами в массиве нет


// ---Вариант №1---
// Не внимательно прочитал и решил, что нужно найти заданное число и указать его позицию в массиве, коли написал, решил уже не удалять.



int[,] CreateRandomArray2D(int rows, int colouns, int minValue, int maxValue)
{ 
    int[,] array = new int[rows, colouns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < colouns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        }
        return array;
}

void ShowArray(int[,] array)
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


int SpeachArrayIndex(int[,] array, int num)
{

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            
            if(array[i,j] == num)
            {
                Console.Write($"Cordinats (rows: {i}, colouns: {j}) the desired number: ");
                return array[i,j];
                  
            }
                     
        }
    
    }
    Console.Write("No number in thes array: Error ");
return -1;
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Input quantity rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input quantity colouns: ");
int colouns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Min Value array: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Max Value array: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] newArray = CreateRandomArray2D(rows, colouns, minValue, maxValue);
ShowArray(newArray);
int W = SpeachArrayIndex(newArray, num);
Console.Write(W);

*/

// ---Вариант №2---
// Решение согласно условию задачи.

int[,] CreateRandomArray2D(int rows, int colouns, int minValue, int maxValue)
{ 
    int[,] array = new int[rows, colouns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < colouns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        }
        return array;
}

void ShowArray(int[,] array)
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


int SpeachArrayIndex(int[,] array, int x, int y)
{
    
    if(x < array.GetLength(0) & y < array.GetLength(1))
    {
        Console.Write("Enter position is equal to: ");
        return array[x,y];
    }
    else
    {
        Console.Write("No index in thes array: Error ");             
    }
    
return -1;
}

Console.Write("Input position rows: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input position colouns: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Input quantity rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input quantity colouns: ");
int colouns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Min Value array: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Max Value array: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] newArray = CreateRandomArray2D(rows, colouns, minValue, maxValue);
ShowArray(newArray);
int W = SpeachArrayIndex(newArray, x, y);
Console.Write(W);
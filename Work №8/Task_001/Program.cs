﻿/*
Task №1:
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:

7 4 2 1
9 5 3 2
8 4 4 2

*/
// ---Вариант №1---
// 

int[,] CreateArray2D()
{
    int[,] array = new int[3,4];
        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 4; j++)
            {
                array[i,j] = new Random().Next(1,100 + 1);
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

void SortArray2D(int[,] array)
{
    
    for(int i = 0; i < array.GetLength(0); i++)
    {
       for(int j = 0; j < array.GetLength(1); j++)
       { 
            for(int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if(array[i,k] < array[i, k + 1])
                {
                int temp = 0;
                temp = array[i,k];
                array[i,k] = array[i, k + 1];
                array[i, k + 1] = temp;
                }
            }
            
        }
               
    }
  
}

int[,] newArray = CreateArray2D();
ShowArray2D(newArray);
SortArray2D(newArray);
ShowArray2D(newArray);

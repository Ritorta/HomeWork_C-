/*
Task №2:
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

*/
// ---Вариант №1---
// 

int[,] CreateDoubleArray2D()
{
    int[,] array = new int[8,4];
    
    for(int i = 0; i < 8; i++)
    {
        for(int j = 0; j < 4; j++)
        {
            array[i,j] = new Random().Next(1,10 + 1);
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

void SumRowMin(int[,] array)
{
    int index = 0;
    int min = 0;
    // for(int i = 0; i < array.GetLength(1); i++) //Другой вариант 
    // {
    //     min = min + array[0,i];
    // }
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sum = array[i,j] + sum;
          
        }
            if(i == 0)
            {
                min = sum;
            }
            else if(sum < min)
            {
                min = sum;
                index = i;
            }
            
    }
    Console.WriteLine($"Thes row have min sum: Number row {index + 1}.");
}



int[,] newArray = CreateDoubleArray2D();
ShowArray2D(newArray);
SumRowMin(newArray);

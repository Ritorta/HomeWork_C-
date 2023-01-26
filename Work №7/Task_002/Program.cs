/*
Task №2:
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> элемента с такими индексами в массиве нет

*/
// ---Вариант №1---
// 



int[,] CreateRandomArray2D()
{
   // int rows = Convert.ToInt32(Console.ReadLine());
   // int colouns = Convert.ToInt32(Console.ReadLine());
   // int minValue = Convert.ToInt32(Console.ReadLine());
   // int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[2, 2];
    for(int i = 0; i < 2; i++)
        for(int j = 0; j < 2; j++)
        {
            array[i,j] = new Random().Next(1, 10 + 1);
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


int SpeachArrayIndex(int[,] array, int rows)
{

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] == rows)
            {
                
                Console.Write($"(rows: {i}, colouns: {j}) ");
                         return  j;  
            } 
                  
        }
        
    }
return -1;
}

Console.Write("Input number rows: ");
int rows = Convert.ToInt32(Console.ReadLine());


int[,] newArray = CreateRandomArray2D();
ShowArray(newArray);
int W = SpeachArrayIndex(newArray, rows);
Console.Write($">{W}<");




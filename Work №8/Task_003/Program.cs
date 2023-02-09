/*
Task №3:
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:

2 4 | 3 4
3 2 | 3 3

Результирующая матрица будет:

18 20
15 18

*/
// ---Вариант №1---
// 

int[,] CreatMatrix(int rows, int colouns)
{
    int[,] array = new int[rows, colouns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colouns; j++)
        {
            array[i,j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void ShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}



Console.Write("Enter quantity rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter quantity colouns: ");
int colouns = Convert.ToInt32(Console.ReadLine());

int[,] NewArray = CreatMatrix(rows, colouns);
ShowArray(NewArray);

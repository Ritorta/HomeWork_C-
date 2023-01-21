/*
Task №3:
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76

*/
// ---Вариант №1---
// 

int[] IntRandomArray(int length, int minValue, int maxValue)
{
int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
        
    }
    return array;
}

double[] DoubleRandomArray(int length)
{
double[] array = new double[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().NextDouble();
        
    }
    return array;
}


void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
Console.WriteLine();
}

int Difference(int[] array, int min, int max)
{
    
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > min)
        {
            min = array[i];
        }
        else if (array[i] < max)
        {
            max = array[i];
        }
    }
return min - max;
}

Console.Write("/1 - ");
int length = Convert.ToInt32(Console.ReadLine());



double[] newArray2 = DoubleRandomArray(length);
ShowArray(newArray2);
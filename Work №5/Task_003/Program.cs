/*
Task №3:
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76


// ---Вариант №1---
// Рандом вещественных чисел я реализовал как склейку нескольких рандомов в ячейки памяти.

double[] DoubleRandomArray(int length, int minValue, int maxValue)
{
int[] array = new int[length];
double[] array2 = new double[length];
double[] array3 = new double[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
        array2[i] = new Random().NextDouble();
        array2[i] = Math.Round(array2[i], 2);
        array3[i] = array[i] + array2[i];
    }
    return array3;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
Console.WriteLine();
}

double Difference(double[] array, double minValue, double maxValue)
{

    for(int i = 0; i < array.Length; i++)
    {
    
        if (array[i] > maxValue)
        {
            maxValue = array[i];
        }
        if(array[i] < minValue)
        {
            minValue = array[i];
        }
        
    }
return maxValue - minValue;
}

Console.Write("Enter the size array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the minimum value length array: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the maximum value length array: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

double[] newArray = DoubleRandomArray(length, minValue, maxValue);
ShowArray(newArray);
double Sum = Difference(newArray, maxValue, minValue);
double Sum1 = Math.Round(Sum, 2);
Console.Write($"Difference min or max: {Sum1}");

*/

// ---Вариант №2---
// Это вариант с реализацией вещественных чисел в одну строку.

double[] DoubleRandomArray(int length, int minValue, int maxValue)
{
double[] array = new double[length];

    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
        array[i] = Math.Round(array[i], 2);
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

double Difference(double[] array, double minValue, double maxValue)
{

    for(int i = 0; i < array.Length; i++)
    {
    
        if (array[i] > maxValue)
        {
            maxValue = array[i];
        }
        if(array[i] < minValue)
        {
            minValue = array[i];
        }
        
    }
return maxValue - minValue;
}

Console.Write("Enter the size array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the minimum value length array: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the maximum value length array: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

double[] newArray = DoubleRandomArray(length, minValue, maxValue);
ShowArray(newArray);
double Sum = Difference(newArray, maxValue, minValue);
double Sum1 = Math.Round(Sum, 2);
Console.Write($"Difference min or max: {Sum1}");

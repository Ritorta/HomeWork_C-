/*
Task №3:
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76

*/
// ---Вариант №1---
// 

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

int Difference(int[] array, int minValue, int maxValue)
{
    for(int i = 0; i < array.Length; i++)
    {
    
        if(array[i] < minValue)
        {
            minValue = array[i];
        }
        if (array[i] > maxValue)
        {
            maxValue = array[i];
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
//double Sum = Difference(newArray);



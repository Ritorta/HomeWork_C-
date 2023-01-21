/*
Task №2:
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0

*/
// ---Вариант №1---

int[] RandomArray(int length, int min, int max)
{
int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
Console.WriteLine();
}

int NotEvenGetSum(int[] array)
{
int sum = 0;
    for(int i = 0; i < array.Length; i+=2)
    {
        sum = sum + array[i];        
    }
return sum;
}

Console.Write("Enter the size: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the minimum value length array: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the maximum value length array: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = RandomArray(length, min, max);
ShowArray(newArray);
int sum = NotEvenGetSum(newArray);
Console.WriteLine($"The sum of number in odd positions: {sum}.");
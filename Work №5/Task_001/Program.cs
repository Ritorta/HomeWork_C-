/*
Task №1:
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2]

*/
// ---Вариант №1---

int[] RandomArray(int length)
{
int[] array = new int[length];

    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100, 999 + 1);

    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
Console.WriteLine();
}

int NumbEven(int[] array)
{
int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        
        if(array[i] %2 == 0)
        {
            count = count + 1;
        }
        else if (array[i] %2 != 0)
        {
            Console.WriteLine($"Number {array[i]} no even.");
        }
    }

return count;
}

Console.Write("Enter the size of the array: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] newArray = RandomArray(length);
Console.Write($"Array: ");
ShowArray(newArray);
int count = NumbEven(newArray);
Console.Write("Quantity even numbers: " + count +".");
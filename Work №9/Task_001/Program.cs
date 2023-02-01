/*
Task №1:
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// ---Вариант №1---
// Это красивый вариант с точкой.

void ShowNaturalNum(int num)
{
    Console.Write(num + " ");
    if(num > 1)
    {
        ShowNaturalNum(num - 1);
    }
}

Console.Write($"Natural numbers: ");
ShowNaturalNum(10);

*/

// ---Вариант №2---
// Это красивый вариант с запятыми и точкой.

void ShowNaturalNum(int num)
{
    
    
    if(num > 1)
    {
        Console.Write(num + ", ");
        ShowNaturalNum(num - 1);
      
    }
    if(num == 1)
    {
            Console.Write(1 + ".");
    }

}

Console.Write($"Natural numbers: ");
ShowNaturalNum(10);

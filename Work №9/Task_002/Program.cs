/*
Task №2:
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

*/
// ---Вариант №1---
// 

int SumNumb(int num1, int num2)
{
    if(num1 == 0)
    {
        return num2 * (num2 + 1) /2;
    }
    else if(num2 == 0)
    {
        return num1 * (num1 + 1) /2;
    }
    else if(num1 == num2)
    {
        return num1;
    }
    else if(num1 < num2)
    {
        return num2 + SumNumb(num1, num2 - 1);
    }
    else if(num1 > num2)
    {
        return num1 + SumNumb(num1 - 1, num2);
    }
    else
    {
        Console.Write("Error: ");
        return -1;
    }
}

Console.WriteLine(SumNumb(5, 1));

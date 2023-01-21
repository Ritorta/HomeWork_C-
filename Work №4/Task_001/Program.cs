/*
Task №1:
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16


*/
// ---Вариант №1---
// 

int Degree(int num, int deg)
{
int num1 = num;    
int result = 1;

    for(int count = 1; count <= deg; count++)
    {
        result = num1 * result;
    }

return result;
}

Console.WriteLine("Program raises a number to a natural power.");
Console.Write("Input to number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Input to degree: ");
int deg = Convert.ToInt32(Console.ReadLine());

Console.Write($"Degree number = : {Degree(num, deg)}");
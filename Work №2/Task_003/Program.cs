/* 
Task №1:
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет


*/

bool Day(int numb1)
{
    if(numb1 >= 6 & numb1 <= 7) 
    {
        return true;
    }
    else
    {
        return false;
    }
}


Console.Write("Input number day of week from 1 to 7: ");
int numb1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Day(numb1));


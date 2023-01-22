/*
Task №1:
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3

*/
// ---Вариант №1---


int[] ImputNumber(int leng)
{
int[] array = new int[leng];
    for(int i = 0; i < leng; i++)
    {
        Console.Write($"Enter the number {i + 1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int SumNumber(int[] array)
{
int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] != 0)
        {
            count = count + 1;            
        }
    }
return count;    
}    

Console.Write("Enter the quantity number: ");
int leng = Convert.ToInt32(Console.ReadLine());

int[] newSum = ImputNumber(leng);
int Sum = SumNumber(newSum);
Console.Write(Sum);
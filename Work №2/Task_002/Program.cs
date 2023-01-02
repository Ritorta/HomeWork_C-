/* 
Task №2:
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6


// Вариант №1
// Решение так сказать в лоб без изысков.
int NumFree(int numb1)
{
    int Free = numb1 % 10;
    int resoult = Free;
    return resoult;
    
}

Console.Write("Enter the number: ");
int numb1 = Convert.ToInt32(Console.ReadLine());


    if(numb1 <= 99)
    {
        numb1 = numb1 = -1;
        Console.Write("There is no third numb: error ");
        
    }
    else if (numb1 <= 999)
    {
        numb1 = numb1 % 10;
    }
    else if (numb1 <= 9999)
    {
        numb1 = numb1 / 10;
    }
    else if (numb1 <= 99999)
    {
        numb1 = numb1 / 100;
    }

Console.Write(NumFree(numb1));
*/    
// Вариант №2
// 

int NumFree(int numb1)
{
    int Free = numb1 % 10;
    int resoult = Free;
    return resoult;
    
}

Console.Write("Enter the number: ");
int numb1 = Convert.ToInt32(Console.ReadLine());

  if(numb1 <= 99)
    {
        numb1 = numb1 = -1;
        Console.Write("There is no third numb: error ");
        
    }
    while (numb1>999)
    {
        

    }
/* 
Task №2:
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6


// ---Вариант №1---
// Простой, рабочий, броский и исправленный.

int NumFree(int numb1)
{

int result = numb1;
    
    if(numb1 <= 99)
    {
        numb1 = numb1 = -1;
        result = numb1;
        Console.Write("There is no third numb: error ");
    }
    else if (numb1 <= 999)
    {
        numb1 = numb1 % 10;
        result = numb1;
    }
    else if (numb1 <= 9999)
    {
        numb1 = numb1 / 10 % 10;
        result = numb1;
    }
    else if (numb1 <= 99999)
    {
        numb1 = numb1 / 100 % 10;
        result = numb1;
    }
    
return result;
}

Console.Write("Enter the number: ");
int numb1 = Convert.ToInt32(Console.ReadLine());

Console.Write(NumFree(numb1));


// ---Вариант №2---
// Через оператор "while" хотя особой разницы с Вариант№1 нету. 

Console.Write("Enter the number: ");
int numb1 = Convert.ToInt32(Console.ReadLine());

int NumFree(int numb1)
{
int result = 0;

    while(numb1 <= 99999)
    {
        
        if(numb1 <= 99)
        {
            numb1 = numb1 = -1;
            result = numb1;
            Console.Write("There is no third numb: error ");
            break;
        }
        else if (numb1 <= 999)
        {
            numb1 = numb1 % 10;
            result = numb1;
            break;
        }
        else if (numb1 <= 9999)
        {
            numb1 = numb1 / 10 % 10;
            result = numb1;
            break;
        }
        else
        {
            numb1 = numb1 / 100 % 10;
            result = numb1;
            break;
        }
        
    }
return result;
}

Console.Write(NumFree(numb1));
*/

// ---Вариант №3---
// Теперь он может брать отрицальные значения и также ввёл ограничения на допустимый ввод.

int NumFree(int numb1)
{

int result = numb1;  

    if(numb1 <= 99 & numb1 >= -99)
    {
        Console.Write("There is no third numb: error ");
        return -1;
    }
    else if (numb1 <= 999 & numb1 >= -999)
    {
       numb1 = numb1 % 10;
       result = numb1;   
    }
      else if (numb1 <= 9999 & numb1 >= -9999)
    {
        numb1 = numb1 / 10 % 10;
        result = numb1;
    }
    else if (numb1 <= 99999 & numb1 >= -99999)
    {
        numb1 = numb1 / 100 % 10;
        result = numb1;
    }
    else
    {
        Console.Write("Please imput number -99999 to 99999: error ");
        return -1;
    }
     
return result;
}

Console.Write("Enter the number: ");
int numb1 = Convert.ToInt32(Console.ReadLine());

Console.Write(NumFree(numb1));

// Можно ли автоматизировать методику, чтобы она не была такой громозкой и принимала более крупные значения.


/*
// Вариант который нагуглил и попытался в нём разобраться как он работает.
// Я так до конца не понял, как оно должно работать...

Console.Write("Enter the number: ");
int numb1 = Convert.ToInt32(Console.ReadLine());
int leng = numb1.ToString().Length; // Это рабоатет как абсолютно рандомная длинна?

int NumFree(int numb1, int leng)
{
    int result = 0;
    int c = 1; // это строчка не рабобрана(не понятна)!!!

    for(int count = leng; count > 3; count--) // Не совсем понял почему уменьшаем.
    {
        
        c = c * 10; // это строчка не рабобрана(не понятна)!!!
               
    }
    result = (numb1 / c) % 10; 

      if (leng < 3)
    {
        numb1 = numb1 = -1;
        result = numb1;
        Console.Write("There is no third numb: error ");
    }
    return result;
}

Console.Write(NumFree(numb1, leng));
*/
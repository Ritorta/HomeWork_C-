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


// ---Вариант №4---
// Нашёл как написать функцию(метод) для проверки разряда числа и применил, программа не работает с отрицательными числами. 

int Digit(int num) // Првоерка разрядности числа.
{
int dig = num;    
int count = 0;
    while (dig > 0)
    {
        dig = dig /10;
        count = dig;
        count++;
    }
    return count;
}

Console.Write("Imput Number: ");
int num = Convert.ToInt32(Console.ReadLine());
string numLeng = Convert.ToString(num); // Преобразование числа в строку, позволяет работать с длинной числа.
int numDigit = Digit(num); // Присваем переменной работу функции.
numDigit = numLeng.Length; // Работа функции с длиной числа.

if(numDigit > 2)
{
    Console.Write($"=1= {numLeng[2]}" ); // Цифра в скобках обозначает какой разряд числа нужно выводить.
}
else
{
    Console.Write("Error!");
}


// ---Вариант №5---
// Я так до конца не понял, как оно должно работать...

Console.Write("Enter the number: ");
int numb1 = Convert.ToInt32(Console.ReadLine());
int leng = numb1.ToString().Length; // Преобразование числа в строку, позволяет работать с длинной числа, в этой же ствочке сразу сделано присвоение "numb1".

int NumFree(int numb1, int leng)
{
int result = 0;
int c = 1; // это строчка не рабобрана!!!  
    if (leng < 3)
    {
        numb1 = numb1 = -1;
        result = numb1;
        Console.Write("There is no third numb: error ");
    }
    else
    {
        for(int count = leng; count > 3; count--) // Не совсем понял почему уменьшаем.
    
        
         c = c * 10; // это строчка не рабобрана!!!
               
    }
    result = (numb1 / c) % 10; 
return result;
}

Console.Write(NumFree(numb1, leng));


*/
// ---Вариант №6---
// К самому удачному второму варианту добавлена работа с отрицательными числами.

Console.Write("Enter the number: ");
int numb1 = Convert.ToInt32(Console.ReadLine());

int NumFree(int numb1)
{
int num = numb1;    
int result = 0;

    while(num <= 999999 & num >= -999999)
    {
        
        if(num <= 99 & num >= -99)
        {
            num = num = -1;
            result = num;
            Console.Write("There is no third numb: error ");
            break;
        }
        else if (num <= 999 & num >= -999)
        {
            num = num % 10;
            result = num;
            break;
        }
        else if (num <= 9999 & num >= -9999)
        {
            num = num / 10 % 10;
            result = num;
            break;
        }
          else if (num <= 99999 & num >= -99999)
        {
            num = num / 100 % 10;
            result = num;
            break;
        }
        else
        {
            num = num / 1000 % 10;
            result = num;
            break;
        }
        
    }
return result;
}

Console.Write(NumFree(numb1));
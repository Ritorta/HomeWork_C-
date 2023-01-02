/* 
Task №1:
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1



int TwoNum(int numb1)
{
    int Two = numb1 % 100 / 10;
    int resolt = Two;
    

    if(numb1 >= 100 && numb1 <= 999)
    {
       return resolt;
    }
    else
    {
     
     return -1; // Можно ли здесь задать текстовое сообщение на возврат?
     
    }    
   
    
}


Console.Write("Imput any theree-digit number: ");
int numb1 = Convert.ToInt32(Console.ReadLine());

Console.Write(TwoNum(numb1));



int TwoNum(int numb1)
{
    int Two = numb1 % 100 / 10;
        
    return Two;
}

Console.Write("Imput any theree-digit number: ");
int numb1 = Convert.ToInt32(Console.ReadLine());

if(numb1 >= 100 && numb1 <= 999)
{
    Console.Write(TwoNum(numb1));
}
else
{
    Console.Write("Invalid command, please enter the three-digit number.");
}

*/

int TwoNum(int numb1)
{
    int Two = numb1 % 100 / 10;
    int resolt = Two;    
    return resolt;
}


Console.Write("Imput any theree-digit number: ");
int numb1 = Convert.ToInt32(Console.ReadLine());

if(numb1 >= -999 & numb1 <= -100 || numb1 >= 100 & numb1 <= 999)
{
    Console.Write(TwoNum(numb1));
}
else
{
    Console.Write("Invalid command, please enter the three-digit number.");
}

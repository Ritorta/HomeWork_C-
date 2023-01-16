/*
Task №2:
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12


// ---Вариант №1---
// Через метод While 


int SumNumber(int num)
{
int usenum = num;
int result = 0;

    while(usenum > 0)
    {
       result = usenum % 10 + result;  
       usenum = usenum / 10;            
    }

return result;
}


Console.Write("Imput number: ");
int num = Convert.ToInt32(Console.ReadLine());


Console.WriteLine(SumNumber(num));

// ---Вариант №2---
// Через метод For, но капец он грузит ядро процессора в усмерть просто ужс... и чо ему ненравится, хотя но работает же)


int SumNumber(int num)
{
int usenum = num;
int result = 0;

    for(int count = usenum; count != 0; count++)
    {
        result = usenum % 10 + result;
        usenum = usenum / 10;         
    }

return result;
}


Console.Write("Imput number: ");
int num = Convert.ToInt32(Console.ReadLine());


Console.WriteLine(SumNumber(num));



// ---Вариант №3---
// Через if узнал, что можно циклить if

int SumNumber(int num)
{
int usenum = num;
int result = 0;
int temp = 0;

    if(usenum < 10)
    {
        result = usenum;
        return result;
    }
    else
    {
       result = usenum % 10;  
       temp = usenum / 10;            
    }

return result + SumNumber(temp);
}


Console.Write("Imput number: ");
int num = Convert.ToInt32(Console.ReadLine());


Console.WriteLine(SumNumber(num));

*/

// ---Вариант №4---
// Вспомнил, что использовал ранее в одной из предыдущих задач "Length" и решил его реализовать и это о чудо не грузит ядро процессора в усмерть


int SumNumber(int num, int leng)
{
int usenum = num;
int result = 0;

    for(int count = 0; count < leng; count++)
    {
        result = usenum % 10 + result;
        usenum = usenum / 10;         
    }

return result;
}


Console.Write("Enter the number: ");
int num = Convert.ToInt32(Console.ReadLine());
int leng = num.ToString().Length; 


Console.WriteLine(SumNumber(num, leng));
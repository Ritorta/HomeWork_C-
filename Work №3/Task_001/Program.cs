/*
Task №1:
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да



// ---Вариант №1---
// Всё согласно условию, любая длинна числа.


Console.Write("Imput number to cheeck palindrome : "); 
int numb = Convert.ToInt32(Console.ReadLine());



void Reverse (int numb)
{

int temp = 0;
int num = numb;

    while (num > 0)
    {
        temp = temp * 10 + num % 10;
        num = num / 10;
        
    }

     if(temp == numb)
        {
            Console.WriteLine("Yes is poly");
            
        }
        else
        {
            Console.WriteLine("Dont no poly");
        }
}

Reverse(numb);


*/
// ---Вариант №2---
// !!!Вариант №1 основной вариант решения!!!

// Как-то криво через "For" и "String" зато может проверять слова, скрипит но работает же)


Console.Write("Imput number to cheeck palindrome : "); 
string num = Console.ReadLine();
int len = num.Length; // Определяем символы в строке.

for(int count = 0; count < len/2; count++)
	{
		if(num[count] != num[len-count-1])
		{
			Console.WriteLine("Dont no poly");
            break;
		}
        else
        {
            Console.WriteLine("Yes is poly");
            break;
        }
	}
	


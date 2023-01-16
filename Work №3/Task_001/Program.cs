/*
Task №1:
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да


*/
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


/*
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
	
*/

// Описание функции разворачивая функции
/*
#include <stdio.h>
 
// Итерационная функция для проверки, является ли заданное число палиндромом или нет
int isPalindrome(int num)
{
    // `n` сохраняет заданное целое число
    int n = num;
 
    // `rev` хранит обратную сторону заданного целого числа
    int rev = 0;
 
    while (n)
    {
        // это сохранит последнюю цифру `n` в переменной `r`
        // например, если `n` равно 1234, то `r` будет равно 4
        int r = n % 10;
 
        // добавляем `r` к `rev` вместо себя
        // например, если `rev = 65` и `r = 4`, то новый `rev` будет 654
        rev = rev * 10 + r;
 
        // удалить последнюю цифру из `n`
        // например, если `n` равно 1234, то новое `n` будет 123
        n = n / 10;
    }
 
    // это выражение вернет 1, если заданное число равно
    // наоборот; в противном случае он вернет 0
    return (num == rev);
}
 
int main(void)
{
    int n = 12321;
 
    if (isPalindrome(n)) {
        printf("Palindrome");
    }
    else {
        printf("Not Palindrome");
    }
 
    return 0;
}
*/
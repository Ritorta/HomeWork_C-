/*
Task №1:
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да


/*
// ---Вариант №1---
// Пробуемс реализовать
*/

Console.Write("Imput number: "); 
int numb = Convert.ToInt32(Console.ReadLine());



int Reverse (int numb)
{

int temp = 0;

    while (numb > 0)
    {
        temp = temp * 10 + numb % 10;
        numb = numb / 10;
    }
return temp;
}

int Cheek (int n)
{
    int rev_n = Reverse(n);

     if(rev_n == n)
        {
            Console.WriteLine("Yes is poly");
            return 1;
        }
        else
        {
            Console.WriteLine("Dont no poly");
            return 0;
        }
}

Console.WriteLine(Reverse(numb));
Console.WriteLine(Cheek(numb));



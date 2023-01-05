/* 
Task №3:
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет



// Вариант №1
// Самое простое решение, без проверки числа.

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

// Вариант №2
// Самое простое решение, c проверкой числа.

bool Day(int numb1)
{
    if(numb1 < 1 & numb1 > 7)
    {
        return false;
    }
    else if(numb1 >= 6 & numb1 <= 7) 
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

// Вариант №3 
// С проверкой числа но без функции.


Console.Write("Input number day of week from 1 to 7: ");
int numb1 = Convert.ToInt32(Console.ReadLine());

if (numb1 < 1 || numb1 > 7)
{
    Console.Write("Error, thes number don't interval 1 or 7!");
}
else if (numb1 > 5)
{
    Console.Write("Yes, weekend!");
}
else
{
    Console.Write("Ohh, Work again");
}

Console.WriteLine();


// Вариант №4
// Как второй вариант но с функцией.
bool Day(int numb1)
{
    if(numb1 < 1 || numb1 > 7) 
    {
        Console.WriteLine("Error, thes number don't interval 1 or 7.");
        return false;
        
    }
    else if (numb1 > 5)
    {
         Console.WriteLine("Yes, weekend!");
         return true;
    }
    else
    {
        Console.WriteLine("Ohh, Work again...");
        return false;
    }
}

Console.Write("Input number day of week from 1 to 7: ");
int numb1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Day(numb1));


// Вариант №5
// Воспользовался оператором if() как подсказали, только долго втыкал, что в условие надо подставить "Day(numb1)" а не просто написать "true"


Console.Write("Input number day of week from 1 to 7: ");
int numb1 = Convert.ToInt32(Console.ReadLine());

bool Day(int numb1)
{
    if (numb1 > 5)
    {
         
         return true;
    }
    else
    {
        
        return false;
    }
}

if(numb1 < 1 || numb1 > 7) 
    {
        Console.WriteLine("Error, thes number don't interval 1 or 7.");               
    }

else if(Day(numb1))
{
    Console.WriteLine("Yes, weekend!");
}
else
{
    Console.WriteLine("Ohh, Work again...");
}

*/

// Вариант №6
// Пересмотрел второй семинар (запись преподавателя), реализовал тернарный оператор который там промелькнул.


Console.Write("Input number day of week from 1 to 7: ");
int numb1 = Convert.ToInt32(Console.ReadLine());

bool Day(int numb1)
{
    if (numb1 > 5)
    {
         
         return true;
    }
    else
    {
        
        return false;
    }
}

if(numb1 < 1 || numb1 > 7) 
    {
        Console.WriteLine("Error, thes number don't interval 1 or 7.");               
    }

else
{
    Console.Write(Day(numb1) ? "Yes, weekend!" : "Ohh, Work again...");
}

/*
Task №3:
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125



// ---Вариант №1---
//Аналогично функции с cеминара через "void".

void Cube(int numb)
{
int count = 1;

    while (count <= numb)
    {
    int N = (count * count * count);
    Console.WriteLine(N);
    count++;
    }
  
}

Console.Write("Imput number: ");
int numb = Convert.ToInt32(Console.ReadLine());
Cube(numb);

*/

// ---Вариант №2---
// Через функцию "while" и костыль в виде оформления чтобы скрыть "return".

double Cube(double numb)
{
    
    double result = 0; 
    double count = 1;
    
    while(count <= numb)
    {
        double T = Math.Pow(count, 3);
        Console.WriteLine($"  {count}. Degree cube - {T} ");
        result = count;
        count++;                                   
    }
Console.Write("Cube degree number: ");
return result;   
}

Console.Write("Imput number: ");
double numb = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Cube(numb));

// ---Вариант №3---
// Через функцию "for"

/*

Task №2:
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

//              --------------- !!!Несколько вариаций решения!!! -----------------

// Начало стандартное работает, а вот дальше опять не смог понять как бы можно было сделать на основе предыдущего, нехватает знания в операторах,
для использования больше двух значений в операторе if...итог опять много кода(


// Первый вариант 

// Я сам пока не понял как это работает но, работает вроде и ладно.

Console.Write("Enter to First number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter to Second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter to Third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num1 > num2) 
{
    max = num1;
}
else
{
    max = num2;
}

if (num1 > num3)
{
    max = num1;
}
else
{
    max = num3;
}

if (num2 > num3)
{
    max = num2;
}
else
{
    max = num3;
}

if (max < num1)
{
    max = num1; 
}
  
  
    Console.Write("Max number: " + max);


// Вариант второй

// Здесь я запарился и попытался разобраться как следует и за одним сократить код.

*/

Console.Write("Enter to First number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter to Second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter to Third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num1 > num2 && num1 > num3)

// Оператор "&&" я погугл, потому как мне очень хотелось сократить код и напистаь условия в одну строку,
// честно я доконца не понял как он прям работает в отличии от "||" .

{
    max = num1;
}
else if (num2 > num1 && num2 > num3)
{
    max = num2;
}
else if (num3 > num1 && num3 > num2)
{
    max = num3;
}

Console.Write("Max number: " + max);


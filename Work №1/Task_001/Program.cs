/* 
Task №1:
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

//              --------------- !!!Несколько вариаций решения!!! -----------------

//Первый вариант:

// Данный вариант писал полностью сам, не много подглядев в семинар, подправил мелкие ошибки.

Console.Write("Imput first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Imput second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("Наибольшие число: " + num1);
}

if (num1 < num2)
{
    Console.WriteLine("Наименьшие число: " + num1);
}

if (num1 < num2)
{
    Console.WriteLine("Наибольшие число: " + num2);
}

if (num1 > num2)
{
    Console.WriteLine("Наименьшие число: " + num2);
}


// Второй вариант:
 
// Некрасиво как на мой взгляд один оператор if(не профисионально выглядит), 
оператор "else" (который сразу я присвоить не смог и задался вопросом можно ли ему присваивать условия, 
лично у меня не получилось без ошибки, хотя я хотел сделать совсем небольшой код)

Console.Write("Imput first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Imput second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("Наибольшие число: " + num1);
}

else
{
    Console.WriteLine("Наименьшие число: " + num1);
}

if (num1 < num2)
{
    Console.WriteLine("Наибольшие число: " + num2);
}

else
{
    Console.WriteLine("Наименьшие число: " + num2);
}



//Третий вариант

// Ещё одна вариация в этот раз строки не прыгают как хотят
 
Console.Write("Imput first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Imput second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("Наибольшие число: " + num1);
}

else
{
    Console.WriteLine("Наибольшие число: " + num2);
}

if (num1 < num2)
{
    Console.WriteLine("Наименьшие число: " + num1);
}

else
{
    Console.WriteLine("Наименьшие число: " + num2);
}

*/

// Четвёртый вариант 

// Сократил код, погуглил оператор "else if" теперь я смог присвоить ему знанчение, наконец-то.

Console.Write("Imput first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Imput second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("Наибольшие число: " + num1);
    Console.WriteLine("Наименьшие число: " + num2);
}
else if (num1 < num2)
{
    Console.WriteLine("Наибольшие число: " + num2);
    Console.WriteLine("Наименьшие число: " + num1);
}

//В ходе проверки различный значений в операторы пришёл к выводу, что программа прерывается на сравнении одинаковых чисел, 
// решил решить проблему, чисто так для себя.

else if (num1 == num2) 

// Интересно есть ли ещё один доп параметр или можно постоянно дублировать else if ? 
// (Это вопрос к вам преподаватель, у меня к сожалению с работой не так много времени гуглить.)

{
    Console.WriteLine("Числа равны, введённое число: " + num1);
}

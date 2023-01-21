/* 
Task №1:
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1


// Вариант №1 
// Получение через функицю "return" однако не нашёл возможности при ошики пользователя выводить что-либо кроме "-1". 

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

Console.Write("Input any theree-digit number: ");
int numb1 = Convert.ToInt32(Console.ReadLine());

Console.Write(TwoNum(numb1));

// Вариант № 2
// Функция делает только расчёт, вывод производиться спомощью "if".

int TwoNum(int numb1)
{
    int Two = numb1 % 100 / 10;
        
    return Two;
}

Console.Write("Input any theree-digit number: ");
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
// Вариант №3
// С учётом отрицальтеных значений.

int TwoNum(int numb1)
{
    int Two = numb1 % 100 / 10;
    int resolt = Two;    
    return resolt;
}


Console.Write("Input any theree-digit number: ");
int numb1 = Convert.ToInt32(Console.ReadLine());

if(numb1 >= -999 & numb1 <= -100 || numb1 >= 100 & numb1 <= 999)
{
    Console.Write(TwoNum(numb1));
}
else
{
    Console.Write("Invalid command, please enter the three-digit number.");
}


// Долго искал но так и несмог найти как реализовать возможность понимания нуля программой, если с нуля начинается число, например трёх значное число (012),
// ноль не учитывается как число, как заставить его понимать, что ноль есть и его надо учитывать, скорее всего это нужно прописывать в самой функции.

//Комментарий преподователя:
//Программа не учитывает нули, т.к. они не несут информационной ценности при такой записи(012). 
//Так пишут обычно, когда необходимо, чтобы у всех чисел было одинаковое кол-во цифр. 
//Число 012 не является трёхзначным, так как 0 в старшем разряде и говорит, что сотен нет, следовательно, число двузначное.

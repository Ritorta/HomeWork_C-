/*
Task №4:
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)

*/
// ---Вариант №1---
// Так вроде работает.


// Начало, Задания переменных и условий. 

// Задаём переменные.

Console.Write("Enter quantity list: ");
int layer = Convert.ToInt32(Console.ReadLine()); // Запрос количества Слоёв.
Console.Write("Enter quantity rows: ");
int rows = Convert.ToInt32(Console.ReadLine()); // Запрос количества Строк.
Console.Write("Enter quantity colouns: ");
int colouns = Convert.ToInt32(Console.ReadLine()); // Запрос количества Колонок.

// Проверки на выполнение условий согласно задачи.

if(layer == 0 || rows == 0 || colouns == 0) // Если пользователь ввёл нули в одно из значений или в все.
{
    Console.WriteLine("Error!");
}
else if(layer <= 3 && rows <= 6 && colouns <= 5) // Согласно заданию массив должен состоять только из двухзначных чисел.
{
    int[,,] newArray = CreatTripleArray3D(layer, rows, colouns); // Вызов метода.
    ShowTripleArray3D(newArray);
        
}
else if(layer <= 3 && rows <= 5 && colouns <= 6) // Согласно заданию массив должен состоять только из двухзначных чисел.
{
    int[,,] newArray = CreatTripleArray3D(layer, rows, colouns); // Вызов метода.
    ShowTripleArray3D(newArray);
    
}
else
{
    Console.WriteLine("Error!");
}

// Окончание, Задания переменных и условий, дальше идут методы.

int[,,] CreatTripleArray3D(int layer, int rows, int colouns) // Metod Create and Sort Array, - В данном методе массив создаётся и идёт проверка значений на двойников. Метод с возвратом значения.
{
    int[,,] array = new int[layer, rows, colouns]; // Выделяем память под массив.

    bool Check; // Булевая переменная для поиска дубликатов.

    for (int i = 0; i < layer; i++) // Проходим по массиву Слои.
    {
        for (int j = 0; j < rows; j++) // Проходим по массиву Строки.
        {
            for (int k = 0; k < colouns; k++) // Проходим по массиву Колонки.
            {
                Check = false; // Булевая переменная изначально переведена в значение False
                int newRand = new Random().Next(10, 99 + 1); // Генератор двухзначных рандомных чисел согласно заданию, кладём сгенерированное числов в переменную newRand.
               // array[i, j, k] = newRand;

                for (int q = 0; q < k; q++) // Идём по массиву.
                {
                    if (array[i, j, q] == newRand) // Сравниваем, если сгенерированное число в массиве.
                    {
                        Check = true; // Переводим в True.
                        break; // Перываем запись числа которое уже есть в массиве.
                    }
                }
                if (!Check) // Если сгенерированного числа нет в массиве, то кладём его в массив.
                {
                    array[i, j, k] = newRand; // Записываем числов  массив.
                    k++; // Двигаемся дальше по массиву.
                }
            }
        }
    }
    return array; // Возвращаем метод.
}


void ShowTripleArray3D(int[,,] array)   // Metod Show Array - Данный метод нужен для того, чтобы вывести массив. Метод без возврата значения.
{
    for(int i = 0; i < array.GetLength(0); i++) // Проходим по массиву Слои.
    {
        Console.WriteLine($"---Layer №: {(i + 1)}"); // Выводи Слои.
        for(int j = 0 ; j < array.GetLength(1); j++) // Проходим по массиву Строки.
        {
            for(int k = 0; k < array.GetLength(2); k++) // Проходим по массиву Колонки.
            {
                Console.Write(" " + array[i,j,k] + " "); // Выводим Строки и Колонки.
                Console.Write($"({i},{j},{k})"); // Согласно задания обрамляем в скобки и добавляем индексы для значений.
            }
            Console.WriteLine(); // Для отступа и правильного вывода.
        }
        Console.WriteLine(); // Для отступа и правильного вывода.
    }
}


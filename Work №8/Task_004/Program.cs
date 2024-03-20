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

else if(layer * rows * colouns < 99) // Согласно заданию массив должен состоять только из двухзначных чисел.
{
    int[,,] a = CreatTripleArray3D(layer, rows, colouns); // Вызов метода.
    int[,,] b = WriteTripleArray3D(a);
    ShowTripleArray3D(b);        
}

int[,,] CreatTripleArray3D(int layer, int rows, int coluns) // Metod Create and Sort Array, - В данном методе создаётся пустой массив.
{
    int[,,] array = new int[layer, rows, coluns]; // Выделяем память под массив.

    return array; // Возвращаем метод.
}

int[,,] WriteTripleArray3D(int[,,] array) // В данном методе ищем дубликаты и меняем их.
{
    bool Cheak;

    for (int i = 0; i < array.GetLength(0); i++) // Проходим по массиву Слои.
    {
        for (int j = 0; j < array.GetLength(1);j++)
        {
            for (int k = 0; k < array.GetLength(2);)
            {
                Cheak = false;
                int newRand = new Random().Next(10, 99 + 1);

                int i1 = 0;
                int j1 = 0;
                int k1 = 0;

                for (int q = i1; q < array.GetLength(0); q++)
                {
                    for (int w = j1; w < array.GetLength(1); w++)
                    {
                        for (int e = k1; e < array.GetLength(1); e++)
                        {
                            if (array[q, w, e] == newRand)
                            {
                                Cheak = true;
                            }
                        }
                    }
                }

                if (!Cheak)
                {
                    array[i, j, k] = newRand;
                    k++;
                }
            }
        }
    }
    return array;
}

void ShowTripleArray3D(int[,,] array)   // Metod Show Array - Данный метод нужен для того, чтобы вывести массив. Метод без возврата значения.
{
    for (int i = 0; i < array.GetLength(0); i++) // Проходим по массиву Слои.
    {
        Console.WriteLine($"---Layer №: {(i + 1)}"); // Выводи Слои.
        for (int j = 0; j < array.GetLength(1); j++) // Проходим по массиву Строки.
        {
            for (int k = 0; k < array.GetLength(2); k++) // Проходим по массиву Колонки.
            {
                Console.Write(" " + array[i, j, k] + " "); // Выводим Строки и Колонки.
                Console.Write($"({i},{j},{k})"); // Согласно задания обрамляем в скобки и добавляем индексы для значений.
            }
            Console.WriteLine(); // Для отступа и правильного вывода.
        }
        Console.WriteLine(); // Для отступа и правильного вывода.
    }
}

// ---Вариант №2---

// Console.Write("Enter quantity list: ");
// int layer = Convert.ToInt32(Console.ReadLine()); // Запрос количества Слоёв.
// Console.Write("Enter quantity rows: ");
// int rows = Convert.ToInt32(Console.ReadLine()); // Запрос количества Строк.
// Console.Write("Enter quantity colouns: ");
// int colouns = Convert.ToInt32(Console.ReadLine()); // Запрос количества Колонок.

// int[,,] array = new int[layer, rows, colouns];
// CreateArray(array);
// WriteArray(array);

// void WriteArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.WriteLine($"---Layer №: {(i + 1)}");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write(" " + array[i, j, k] + " ");
//                 Console.Write($"({i},{j},{k})");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }

// void CreateArray(int[,,] array)
// {
//     int[] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
//     int number;

//     for (int i = 0; i < temp.GetLength(0); i++)
//     {
//         temp[i] = new Random().Next(10, 100);

//         number = temp[i];

//         if (i >= 1)
//         {
//             for (int j = 0; j < i; j++)
//             {
//                 while (temp[i] == temp[j])
//                 {
//                     temp[i] = new Random().Next(10, 100);
//                     j = 0;
//                     number = temp[i];
//                 }
//                 number = temp[i];
//             }
//         }
//     }

//     int count = 0;

//     for (int x = 0; x < array.GetLength(0); x++)
//     {
//         for (int y = 0; y < array.GetLength(1); y++)
//         {
//             for (int z = 0; z < array.GetLength(2); z++)
//             {
//                 array[x, y, z] = temp[count];
//                 count++;
//             }
//         }
//     }
// }

// ---Вариант №3---

// int a = 3;
// int b = 5;
// int c = 5;

// int[,,] array = new int[c, b, a];

// for (int z = 0; z < array.GetLength(0); z++)
// {
//     for (int y = 0; y < array.GetLength(1); y++)
//     {
//         for (int x = 0; x < array.GetLength(2); x++)
//         {
//             while (true)
//             {
//                 bool unique = true;
//                 int rand = new Random().Next(1, (a * b * c) + 1);
//                 foreach (var temp in array)
//                 {
//                     if (temp == rand)
//                     {
//                         unique = false;
//                         break;
//                     }
//                 }
//                 if (unique)
//                 {
//                     array[z, y, x] = rand;
//                     break;
//                 }
//             }
//         }
//     }
// }

// for (int i = 0; i < array.GetLength(0); i++) 
// {
//     Console.WriteLine($"---Layer №: {(i + 1)}"); 
//     for (int j = 0; j < array.GetLength(1); j++) 
//     {
//         for (int k = 0; k < array.GetLength(2); k++)
//         {
//             Console.Write(" " + array[i, j, k] + " ");
//             Console.Write($"({i},{j},{k})");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
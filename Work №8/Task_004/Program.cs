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

// Console.Write("Enter quantity list: ");
// int layer = Convert.ToInt32(Console.ReadLine()); // Запрос количества Слоёв.
// Console.Write("Enter quantity rows: ");
// int rows = Convert.ToInt32(Console.ReadLine()); // Запрос количества Строк.
// Console.Write("Enter quantity colouns: ");
// int colouns = Convert.ToInt32(Console.ReadLine()); // Запрос количества Колонок.

// // Проверки на выполнение условий согласно задачи.

// if(layer == 0 || rows == 0 || colouns == 0) // Если пользователь ввёл нули в одно из значений или в все.
// {
//     Console.WriteLine("Error!");
// }
// else if(layer <= 3 && rows <= 6 && colouns <= 5) // Согласно заданию массив должен состоять только из двухзначных чисел.
// {
//     int[,,] newArray = CreatTripleArray3D(layer, rows, colouns); // Вызов метода.
//     ShowTripleArray3D(newArray);
        
// }
// else if(layer <= 3 && rows <= 5 && colouns <= 6) // Согласно заданию массив должен состоять только из двухзначных чисел.
// {
//     int[,,] newArray = CreatTripleArray3D(layer, rows, colouns); // Вызов метода.
//     ShowTripleArray3D(newArray);
    
// }
// else
// {
//     Console.WriteLine("Error!");
// }

// // Окончание, Задания переменных и условий, дальше идут методы.

// int[,,] CreatTripleArray3D(int layer, int rows, int colouns) // Metod Create and Sort Array, - В данном методе массив создаётся и идёт проверка значений на двойников. Метод с возвратом значения.
// {
//     int[,,] array = new int[layer, rows, colouns]; // Выделяем память под массив.

//     bool Check; // Булевая переменная для поиска дубликатов.

//     for (int i = 0; i < layer; i++) // Проходим по массиву Слои.
//     {
//         for (int j = 0; j < rows; j++) // Проходим по массиву Строки.
//         {
//             for (int k = 0; k < colouns;) // Проходим по массиву Колонки.
//             {
//                 Check = false; // Булевая переменная изначально переведена в значение False
//                 int newRand = new Random().Next(10, 99 + 1); // Генератор двухзначных случайных чисел согласно заданию, кладём сгенерированное числов в переменную newRand.
//                 array[i, j, k] = newRand; // Кладём сгенирированное число в массив.

//                 for (int q = 0; q < k; q++) // Идём по массиву.
//                 {
//                     if (array[i, j, q] == newRand) // Сравниваем, если сгенерированное число в массиве.
//                     {
//                         Check = true; // Переводим в True.
//                         break; // Перываем запись числа которое уже есть в массиве.
//                     }
//                 }
//                 if (!Check) // Если сгенерированного числа нет в массиве, то кладём его в массив.
//                 {
//                     array[i, j, k] = newRand; // Записываем числов  массив.
//                     k++; // Двигаемся дальше по массиву.
//                 }
//             }
//         }
//     }
//     return array; // Возвращаем метод.
// }


// void ShowTripleArray3D(int[,,] array)   // Metod Show Array - Данный метод нужен для того, чтобы вывести массив. Метод без возврата значения.
// {
//     for(int i = 0; i < array.GetLength(0); i++) // Проходим по массиву Слои.
//     {
//         Console.WriteLine($"---Layer №: {(i + 1)}"); // Выводи Слои.
//         for(int j = 0 ; j < array.GetLength(1); j++) // Проходим по массиву Строки.
//         {
//             for(int k = 0; k < array.GetLength(2); k++) // Проходим по массиву Колонки.
//             {
//                 Console.Write(" " + array[i,j,k] + " "); // Выводим Строки и Колонки.
//                 Console.Write($"({i},{j},{k})"); // Согласно задания обрамляем в скобки и добавляем индексы для значений.
//             }
//             Console.WriteLine(); // Для отступа и правильного вывода.
//         }
//         Console.WriteLine(); // Для отступа и правильного вывода.
//     }
// }

// ﻿//  Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// // Напишите программу, которая будет построчно выводить массив, 
// // добавляя индексы каждого элемента.
// // массив размером 2 x 2 x 2
// // 12(0,0,0) 22(0,0,1)
// // 45(1,0,0) 53(1,0,1)

// Console.WriteLine($"Введите размер массива X x Y x Z: ");
// int x = InputNumbers("Введите X: ");
// int y = InputNumbers("Введите Y: ");
// int z = InputNumbers("Введите Z: ");
// Console.WriteLine($"");

// int[,,] array3D = new int[x, y, z];
// CreateArray(array3D);
// WriteArray(array3D);

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void WriteArray (int[,,] array3D)
// {
//   for (int i = 0; i < array3D.GetLength(0); i++)
//   {
//     for (int j = 0; j < array3D.GetLength(1); j++)
//     {
//       Console.Write($"X({i}) Y({j}) ");
//       for (int k = 0; k < array3D.GetLength(2); k++)
//       {
//         Console.Write( $"Z({k})={array3D[i,j,k]}; ");
//       }
//       Console.WriteLine();
//     }
//     Console.WriteLine();
//   }
// }

// void CreateArray(int[,,] array3D)
// {
//   int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
//   int  number;
//   for (int i = 0; i < temp.GetLength(0); i++)
//   {
//     temp[i] = new Random().Next(10, 100);
//     number = temp[i];
//     if (i >= 1)
//     {
//       for (int j = 0; j < i; j++)
//       {
//         while (temp[i] == temp[j])
//         {
//           temp[i] = new Random().Next(10, 100);
//           j = 0;
//           number = temp[i];
//         }
//           number = temp[i];
//       }
//     }
//   }
//   int count = 0; 
//   for (int x = 0; x < array3D.GetLength(0); x++)
//   {
//     for (int y = 0; y < array3D.GetLength(1); y++)
//     {
//       for (int z = 0; z < array3D.GetLength(2); z++)
//       {
//         array3D[x, y, z] = temp[count];
//         count++;
//       }
//     }
//   }
// }

///

// Console.Write("Enter quantity list: ");
// int layer = Convert.ToInt32(Console.ReadLine()); // Запрос количества Слоёв.
// Console.Write("Enter quantity rows: ");
// int rows = Convert.ToInt32(Console.ReadLine()); // Запрос количества Строк.
// Console.Write("Enter quantity colouns: ");
// int colouns = Convert.ToInt32(Console.ReadLine()); // Запрос количества Колонок.

// // Проверки на выполнение условий согласно задачи.

// if(layer == 0 || rows == 0 || colouns == 0) // Если пользователь ввёл нули в одно из значений или в все.
// {
//     Console.WriteLine("Error!");
// }

// else if(layer * rows * colouns < 99) // Согласно заданию массив должен состоять только из двухзначных чисел.
// {
//     int[,,] a = CreatTripleArray3D(layer, rows, colouns); // Вызов метода.
//     int[,,] b = WriteTripleArray3D(a);
//     ShowTripleArray3D(b);        
// }

// else
// {
//     Console.WriteLine("Error!");
// }

// int[,,] CreatTripleArray3D(int layer, int rows, int colouns) // Metod Create and Sort Array, - В данном методе создаётся пустой массив.
// {
//     int[,,] array = new int[layer, rows, colouns]; // Выделяем память под массив.
//     return array; // Возвращаем метод.
// }

// int[,,] WriteTripleArray3D(int[,,] array) // В данном методе ищем дубликаты и меняем их.
// {
  
//   for (int i = 0; i < array.GetLength(0); i++) // Проходим по массиву Слои.
//     {
//         for (int j = 0; j < array.GetLength(1); j++) // Проходим по массиву Строки.
//         {
//             for (int k = 0; k < array.GetLength(2);) // Проходим по массиву Колонки.
//             {
//               bool Cheak = false;
//               int newrand = new Random().Next(10, 99 + 1);
              

//               for (int q = i; q < k; q++)
//               {
//                 if(array[i,j,q] == newrand)
//                 {
//                   Cheak = true;
//                   break;
//                 }
                
//               }  
//               if(!Cheak)
//               { 
//                 array[i,j,k] = newrand; // Записываем числов  массив.
//                 k++;
//               }               
//             }  
//         }
//     }    
//   return array;
// }

// void ShowTripleArray3D(int[,,] array)   // Metod Show Array - Данный метод нужен для того, чтобы вывести массив. Метод без возврата значения.
// {
//     for(int i = 0; i < array.GetLength(0); i++) // Проходим по массиву Слои.
//     {
//         Console.WriteLine($"---Layer №: {(i + 1)}"); // Выводи Слои.
//         for(int j = 0 ; j < array.GetLength(1); j++) // Проходим по массиву Строки.
//         {
//             for(int k = 0; k < array.GetLength(2); k++) // Проходим по массиву Колонки.
//             {
//                 Console.Write(" " + array[i,j,k] + " "); // Выводим Строки и Колонки.
//                 Console.Write($"({i},{j},{k})"); // Согласно задания обрамляем в скобки и добавляем индексы для значений.
//             }
//             Console.WriteLine(); // Для отступа и правильного вывода.
//         }
//         Console.WriteLine(); // Для отступа и правильного вывода.
//     }
// }


int[,,] a = Create(3, 5, 5); // Вызов метода.
int[,,] b = Write(a);
Show(b);



int[,,] Create(int layer, int rows, int coluns) // Metod Create and Sort Array, - В данном методе создаётся пустой массив.
{
    int[,,] array = new int[layer, rows, coluns]; // Выделяем память под массив.

    return array; // Возвращаем метод.
}

int[,,] Write(int[,,] array) // В данном методе ищем дубликаты и меняем их.
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

void Show(int[,,] array)   // Metod Show Array - Данный метод нужен для того, чтобы вывести массив. Метод без возврата значения.
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

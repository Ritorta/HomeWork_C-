// THES IS TESTING ROOM!

// // https://www.youtube.com/watch?v=g4nGMWwf7OQ



// IsDigit ()

// float RoundValue (float num, int acurry)
// {
//     int dev = 1;

//     for(int i = 0; i < acurry; i++)
//     {
//         num = num * 10;
//         dev = dev * 10;
//     }
//     return num / acurry;
// }


 

//--------------------------------

// int[,,] CreatTripleArray3D(int layer, int rows, int colouns)
// {
//     int[,,] array = new int[layer,rows,colouns];
    
//     for(int i = 0; i < layer; i++)
//     {
//         for(int j = 0; j < rows; j++)
//         {
//             for(int k = 0; k < colouns; k++)
//             {
//                 array[i,j,k] = new Random().Next(10,99 +1);
//             }
//         }
//     } 
//     return array;
// }

// void ShowTripleArray3D(int[,,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.WriteLine($"---Layer №: {(i + 1)}");
//         for(int j = 0 ; j < array.GetLength(1); j++)
//         {
//             for(int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write(" " + array[i,j,k] + " ");
//                 Console.Write($"({i},{j},{k})");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }

// int[,,] CheckUniquenessNumbers(int[,,] array)
// {
//     int maxNumber = 0;
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             for(int k = 0; k < array.GetLength(2); k++)
//             {   
                
//                 if(array[i,j,k] > maxNumber)
//                 {
//                     maxNumber = array[i,j,k];
//                 }
//                     for(int g = 0; g < array.GetLength(2); g++)
//                     {
//                         if(array[i,j,k] == array[i,j,g])
//                         {               
                            
//                             maxNumber++;
//                             array[i,j,g] = maxNumber;
//                         }
//                     }
                    
                   
                       
//             }
                
//         }
//     }
    
//    return array;     
// }

// Console.Write("Enter quantity list: ");
// int layer = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter quantity rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter quantity colouns: ");
// int colouns = Convert.ToInt32(Console.ReadLine());

// if(layer == 0 || rows == 0 || colouns == 0)
// {
//     Console.WriteLine("Error!");
// }
// else if(layer <= 3 && rows <= 6 && colouns <= 5)
// {
//     int[,,] newArray = CreatTripleArray3D(layer, rows, colouns);
//        ShowTripleArray3D(newArray);
//         CheckUniquenessNumbers(newArray);
//         ShowTripleArray3D(newArray);
     
// }
// else if(layer <= 3 && rows <= 5 && colouns <= 6)
// {
//     int[,,] newArray = CreatTripleArray3D(layer, rows, colouns);

//     ShowTripleArray3D(newArray);
//     CheckUniquenessNumbers(newArray);
//         ShowTripleArray3D(newArray);
     
// }
// else
// {
//     Console.WriteLine("Error!");
// }



//--------------------------------

// int[] RandomArray()
// {
// int[] array = new int[20];

//     for(int i = 0; i < 20; i++)
//     {
//         array[i] = new Random().Next(1, 20 + 1);

//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// Console.WriteLine();
// }

// void NumbEven(int[] array)
// {
//     int MaxNumber = array[0];
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > MaxNumber)
//         {
//             MaxNumber = array[i];
//         }
//     }
//     for(int i = 0; i < array.Length; i++)
//     {
//         for(int j = 0; j < array.Length; j++)
//         {
//             if (array[i] == array[j])
//             {
//                 MaxNumber++;
//                 array[j] = new Random().Next(1, 20 + 1);
//             }
//         }
//     }
// }



// int[] newArray = RandomArray();
// Console.Write($"Array: ");
// ShowArray(newArray);
// NumbEven(newArray);
// ShowArray(newArray);
//----------------------------------------------------------------------------

// var notUniqueElements = 0;      //Счётчик не уникальных элементов
//             int[] myArray = new int[99];
//               for(int i = 0; i < 99; i++)
//     {
//         myArray[i] = new Random().Next(1, 99 + 1);

//     }
    

//             for (int i = 1; i < myArray.Length; i++)
//             {
//                 for (int a = i-1; a >= 0; a--)
//                 {
//                     if (myArray[i] == myArray[a])   //Проверяем элемент на уникальность
//                     {
//                         notUniqueElements++;     //Если такой элемент уже есть, считаем его
//                         break;                             //И переходим к следующему элементу
//                     }
//                 }
//             }
//             int[] uniqueArray = new int[myArray.Length - notUniqueElements]; // Массив уникальных элементов
//             uniqueArray[0] = myArray[0];   //Первый элемент уже уникальный, записываем его
//                 for (int i = 1, b = 1; i < myArray.Length; i++)
//                 {
//                     var uniqueElement = true;   //Для проверки на уникальность
//                     for (int a = i-1; a >= 0; a--)
//                     {
//                         if (myArray[i] == myArray[a])    //Делаем тоже самое, только для записи уникальных чисел в массив
//                         {
//                             uniqueElement = false;  //Если элемент не уникальный
//                             break;                          //Пропускаем его
//                         }
//                     }
//                     if (uniqueElement)                        //Если уникальный
//                     {
//                         uniqueArray[b] = myArray[i];    // Запись уникального элемента в массив
//                         b++; //Индекс для записи в массив уникальных чисел
//                     }
//                 }
//             foreach (var el in uniqueArray)      // Вывод элементов на консоль
//             {
//                 Console.WriteLine($" {el}  ");
//             }
 
           
//------------------------------------------------------------------
        //   var notUniqueElements = 0;      //Счётчик не уникальных элементов
        //     int[] myArray = { 1, 3, 1, 3, 4, 4, 5, 12, 14, 14, 11, 5, 8, 4};
        //     for (int i = 1; i < myArray.Length; i++)
        //     {
        //         for (int a = i-1; a >= 0; a--)
        //         {
        //             if (myArray[i] == myArray[a])   //Проверяем элемент на уникальность
        //             {
        //                 notUniqueElements++;     //Если такой элемент уже есть, считаем его
        //                 break;                             //И переходим к следующему элементу
        //             }
        //         }
        //     }
        //     int[] uniqueArray = new int[myArray.Length - notUniqueElements]; // Массив уникальных элементов
        //     uniqueArray[0] = myArray[0];   //Первый элемент уже уникальный, записываем его
        //         for (int i = 1, b = 1; i < myArray.Length; i++)
        //         {
        //             var uniqueElement = true;   //Для проверки на уникальность
        //             for (int a = i-1; a >= 0; a--)
        //             {
        //                 if (myArray[i] == myArray[a])    //Делаем тоже самое, только для записи уникальных чисел в массив
        //                 {
        //                     uniqueElement = false;  //Если элемент не уникальный
        //                     break;                          //Пропускаем его
        //                 }
        //             }
        //             if (uniqueElement)                        //Если уникальный
        //             {
        //                 uniqueArray[b] = myArray[i];    // Запись уникального элемента в массив
        //                 b++; //Индекс для записи в массив уникальных чисел
        //             }
        //         }
        //     foreach (var el in uniqueArray)      // Вывод элементов на консоль
        //     {
        //         Console.WriteLine(el);
        //     }
 
        //     Console.ReadKey();

        //     //-------------------------------------



// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());

// int[,] nums = new int[size, size];

// int num = 1;
// int i = 0;
// int j = 0;

// while (num <= size * size)
// {
//     nums[i, j] = num;
//     if (i <= j + 1 && i + j < size - 1)
//         ++j;
//     else if (i < j && i + j >= size - 1)
//         ++i;
//     else if (i >= j && i + j > size - 1)
//         --j;
//     else
//         --i;
//     ++num;
// }

// PrintArray(nums);

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " \t");
//         }
//         Console.Write("]");
//         Console.WriteLine("");
//     }
// }
// ----------------------------------------------------
// int len = 6;
// int[,] table = new int[len, len];
// FillArraySpiral(table, len);
// PrintArray(table);


// // Функция заполнения массива по спирали начиная с 1
// void FillArraySpiral(int[,] array, int n)
// {
//     int i = 0, j = 0;
//     int value = 1;
//     for (int e = 0; e < n * n; e++)
//     {
//         int k = 0;
//         do { array[i, j++] = value++; } 
//         while (++k < n - 1);
//         for (k = 0; k < n - 1; k++) array[i++, j] = value++;
//         for (k = 0; k < n - 1; k++) array[i, j--] = value++;
//         for (k = 0; k < n - 1; k++) array[i--, j] = value++;
//         ++i; ++j;
//         n = n < 2 ? 0 : n - 2;
//     }
// }

// //  Функция вывода двумерного массива в терминал
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < 10)
//             {
//                 Console.Write("0" + array[i, j]);
//                 Console.Write(" ");
//             }
//             else Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

//  const int n = 6;
//             const int m = 8;
//             int[,] matrix = new int[n, m];
 
//             int row = 0;
//             int col = 0;
//             int dx = 1;
//             int dy = 0;
//             int dirChanges = 0;
//             int visits = m;
 
//             for (int i = 0; i < matrix.Length; i++) {
//                 matrix[row, col] = i + 1;
//               if (--visits == 0) {
//                 visits = m * (dirChanges %2) + n * ((dirChanges + 1) %2) - (dirChanges/2 - 1) - 2;
//                 int temp = dx;
//                 dx = -dy;
//                 dy = temp;
//                 dirChanges++;
//               }
 
//               col += dx;
//               row += dy;
//             }



// int GetUniqNumber(int[] intArray)
// {
//     int nextNumber;
//     do
//     {
//         nextNumber = new Random().Next(10, 100);
//     }
//     while (intArray[nextNumber] != 0);
//     intArray[nextNumber] = 1;
//     return nextNumber;
// }
// int[,,] Generate3DArray(int rows, int columns, int layers, int[] intArray)
// {
//     int[,,] returnArray = new int[rows, columns, layers];

//     if (rows * columns * layers < 90)
//     {
//         for (int i = 0; i < returnArray.GetLength(0); i++)
//         {
//             for (int j = 0; j < returnArray.GetLength(1); j++)
//             {
//                 for (int k = 0; k < returnArray.GetLength(2); k++)
//                 {
//                     returnArray[i, j, k] = GetUniqNumber(intArray);
//                 }
//             }
//         }
//     }
//     else
//     {
//         Console.WriteLine("Слишком большой массив для уникальных двухзначных чисел");
//     }
//     return returnArray;

// }
// void Print3DArray(int[,,] int3DArray)
// {
//     for (int i = 0; i < int3DArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < int3DArray.GetLength(1); j++)
//         {
//             for (int k = 0; k < int3DArray.GetLength(2); k++)
//             {
//                 Console.Write($"[{i},{j},{k}] {int3DArray[i, j, k]} ");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }

// int[] intArray = new int[100];
// int[,,] array3D = Generate3DArray(3, 3, 3, intArray);
// Print3DArray(array3D);
// System.Console.WriteLine();

//-------------------------------------

Console.Write("Enter length array: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter quantity colouns: ");
int colouns = Convert.ToInt32(Console.ReadLine());


int[,] newArray = SpiralArray(rows, colouns);
ShowArray(newArray);


int[,] SpiralArray(int rows, int colouns)
{
    int[,] array = new int[rows, colouns];

    int indexValue = 1;
    int n = rows;
    int m = colouns; 
          
   
            for(int i = 0; i < n; i++)
            {       
                for(int j = i; j < n - i; j++)
                {
                array[i, j] = indexValue++;
                }

                for(int k = i + 1; k < m - i ; k++)
                {
                array[k, m - 1 - i] = indexValue++;
                }

                for(int j = n - i - 2; j > i; j--)
                {
                array[n - 1 - i, j] = indexValue++;
                }

                for(int k = m - 1 - i; k > i ; k--)
                {
                array[k, i] = indexValue++;
                }
            }
       
   

return array;
}

void ShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " \t");
        }
        Console.WriteLine();
    }
}
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


 

// уникальные числа  мой код 1--------------------------------

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
//     int maxNumber = array[0,0,0];

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
//                     for(int q = j + 1; q < array.GetLength(1); q++)
//                     {
//                         for(int g = k + 1; g < array.GetLength(2); g++)
//                         {
//                             if(array[i,j,k] == array[i,q,g])
//                             {               
//                                 maxNumber = maxNumber + 1;
//                                 array[i,q,g] = maxNumber;
//                             }
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
//     //    ShowTripleArray3D(newArray);
//         CheckUniquenessNumbers(newArray);
//         ShowTripleArray3D(newArray);
     
// }
// else if(layer <= 3 && rows <= 5 && colouns <= 6)
// {
//     int[,,] newArray = CreatTripleArray3D(layer, rows, colouns);

//     // ShowTripleArray3D(newArray);
//     CheckUniquenessNumbers(newArray);
//     ShowTripleArray3D(newArray);
     
// }
// else
// {
//     Console.WriteLine("Error!");
// }



//уникальные числа мой код 2--------------------------------

// int[] RandomArray()
// {
// int[] array = new int[10];

//     for(int i = 0; i < 10; i++)
//     {
//         array[i] = new Random().Next(1, 5 + 1);

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
//     int temp = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > MaxNumber)
//         {
//             MaxNumber = array[i];
//         }
//     }
//     for(int i = 0; i < array.Length; i++)
//     {
//         for(int j = i + 1; j < array.Length; j++)
//         {
            
//                 if(array[i] == array[j])
//                 {
//                 // MaxNumber++;   
//                 // array[j] = MaxNumber;
//                 // array[j] = new Random().Next(1, 5 + 1);
                                
//                 }
//         }
//     }
// }



// int[] newArray = RandomArray();
// Console.Write("");
// ShowArray(newArray);
// NumbEven(newArray);
// ShowArray(newArray);
//уникальные числа пример 1----------------------------------------------------------------------------

// var notUniqueElements = 0;      //Счётчик не уникальных элементов
//             int[] myArray = new int[10];
//               for(int i = 0; i < 10; i++)
//     {
//         myArray[i] = new Random().Next(1, 5 + 1);

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
//                 Console.Write(el + "\t" );
//             }
 
           
//уникальные числа пример 2------------------------------------------------------------------
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

            
// Спирали пример 1--------------------------------


//         const int n = 6;
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



// Спирали пример 1--------------------------------

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
// спирали пример 2 ----------------------------------------
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
//-------------------------------------------------------
    

// https://stackovergo.com/ru/q/599089/replace-duplicate-values-in-array-with-new-randomly-generated-values

// static int[,,] CreateMatrix(int row, int col, int dep, int min, int max)
// {
//     int[,,] matrix = new int[row, col, dep];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(2); k++) { matrix[i, j, k] = GetUniqueValue(matrix, min, max, i, j, k); }
//         }
//     }
//     return matrix;
// }

// /// <summary>
// /// Отдает уникальное для <paramref name="matrix"/> значение
// /// </summary>
// /// <param name="matrix">сама матрица</param>
// /// <param name="min">минимальное значение для рандомайзера</param>
// /// <param name="max">максимальное значение для рандомайзера</param>
// /// <param name="i">текущая итерация <paramref name="i"/></param>
// /// <param name="j">текущая итерация <paramref name="j"/></param>
// /// <param name="k">текущая итерация <paramref name="k"/></param>
// /// <returns>Уникальное для <paramref name="matrix"/> значение</returns>
// static int GetUniqueValue(int[,,] matrix, int min, int max, int i, int j, int k)
// {
    
//     int value = default;
//     bool exist = true;
//     while (exist)
//     {
//         bool _break = false;
//         value = new Random().Next(min, max + 1);
//         for (int i1 = 0; i1 < matrix.GetLength(0); i1++)
//         {
//             if (_break) 
//             { 
//                 break; 
//                 }
//             for (int j1 = 0; j1 < matrix.GetLength(1); j1++)
//             {
//                 if (_break) 
//                 { 
//                         break; 
//                         }
//                 for (int k1 = 0; k1 < matrix.GetLength(2); k1++)
//                 {
//                     if (matrix[i1, j1, k1] == value) 
//                     { 
//                         _break = true; 
//                         break; 
//                         }
//                     if (i1 == i && j1 == j && k1 == k) 
//                     { 
//                         exist = false; 
//                     }
//                 }
//             }
//         }
//     }
//     return value;
// }
// static void PrintMatrix(int[,,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write("|");
//             for (int k = 0; k < matrix.GetLength(2); k++) { Console.Write($"{matrix[i, j, k],1}({i},{j},{k})|"); }
//             Console.WriteLine();
//         }
//     }
// }

//     int[,,] array3D = CreateMatrix(3, 5, 6, 10, 99);
//     PrintMatrix(array3D);
//     Console.ReadLine();

//---------------------------------------
// int GetUniqNumber(int[] array)
// {
//     int nextNumber;
//     do
//     {
//         nextNumber = new Random().Next(10, 100);
//     }
//     while (array[nextNumber] != 0);
//     array[nextNumber] = 1;
//     return nextNumber;
// }

// int[] DoubleRandomArray(int length)
// {
// int[] array = new int[length];

//     for(int i = 0; i < length; i++)
//     {
//         array[i] = GetUniqNumber(array);
      
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// Console.WriteLine();
// }

// Console.Write("f");
// int length = Convert.ToInt32(Console.ReadLine());

// int[] R = DoubleRandomArray(length);
// ShowArray(R);


// Console.Write("Enter the size of the array: ");
// int length = Convert.ToInt32(Console.ReadLine());

// int[] newArray = RandomArray(length);
// ShowArray(newArray);
// NumbEven(newArray);
// ShowArray(newArray);


// int[] RandomArray(int length)
// {
// int[] array = new int[length];

//     for(int i = 0; i < length; i++)
//     {
//         array[i] = new Random().Next(1, 5 + 1);

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

//     for(int i = 0; i < array.Length; i++)
//     {
//         int count = array[i];
//         for(int j = i + 1; j < array.Length; j++)
//         {
//             if(array[i] == array[j])
//             {
//                 count++;
//                 array[i] = count;
//             }
//         }
//     }


// // }
// Console.Write("Enter quantity list: ");
// int layer = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter quantity rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter quantity colouns: ");
// int colouns = Convert.ToInt32(Console.ReadLine());

// if (layer == 0 || rows == 0 || colouns == 0)
// {
//     Console.WriteLine("Error!");
// }
// else if (layer * rows * colouns < 99)
// {
//     int[,,] newArray = CreatTripleArray3D(layer, rows, colouns);
//     ShowTripleArray3D(newArray);
//     //CheakArray3D(newArray);
//     //ShowTripleArray3D(newArray);

// }
// else
// {
//     Console.WriteLine("Error!");
// }

// int[,,] CreatTripleArray3D(int layer, int rows, int colouns)
// {
//     int[,,] array = new int[layer, rows, colouns];

//     for (int i = 0; i < layer; i++)
//     {
//         for (int j = 0; j < rows; j++)
//         {
//             for (int k = 0; k < colouns; )
//             {
//                 bool Check = false;
//                 int newRand = new Random().Next(10, 99 + 1);
//                 array[i, j, k] = newRand;

//                 for (int q = 0; k < i;)
//                 {
//                     if (array[i, j, k] == newRand)
//                     {
//                         Check = true;
//                         break;
//                     }
//                 }

//             if (!Check)
//             {
//                 array[i, j, k] = newRand;
//                 k++;
//             }
//             }
//         }
//     }
//     return array;
// }


// int[] CheeckArrayDuble(int[,,] array)
// {
//     int elementarray = 0;
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             for(int k = 0; k < array.GetLength(2);)
//             {
//                 elementarray = array[i,j,k];

//                 for(int q = k + 1; q < array.GetLength(0); q++)

//                     while(array[i,j,k] == array[i,j,q])
//                     {
//                     if(elementarray == array[i,j,q])
//                         {
//                             array[i,j,k] = new Random().Next(10, 99 + 1);
//                             k++;
//                         }
//                     }
//             }
//         }
//     }
// }

// void ShowTripleArray3D(int[,,] array)
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


Console.Write("Enter the quantity number: ");
double prise = Convert.ToInt32(Console.ReadLine());
int nds = 20;

double[] newSum = ImputNumber(count);
double Sum = SumNumber(newSum);
Console.Write(Sum);


double[] ImputNumber(int prise)
{
double[] array = new double[prise];
    for(int i = 0; i < prise; i++)
    {
        Console.Write($"Enter the number {i + 1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

double SumNumber(int[] array)
{
double count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            count = count + 1;            
        }
    }
return count;    
}    


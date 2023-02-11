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


 //    ------------------------------------------



// Console.Write("Число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write("Точность: ");
// int acurry = Convert.ToInt32(Console.ReadLine());
// RoundValue(num, acurry);



// Функция Акермана без рекурсии
// import java.util.Stack;

// public class Ackermann{
//     public static void main(String[] args) {
//         System.out.println(solve(2,1));
//         System.out.println(solve_rec(2,1));
//     }
    
// 	// Идея: рекурсивный метод
//     public static long solve_rec(long m,long n){
//         if(m == 0){
//             return n+1;
//         }else if(m > 0 && n == 0){
//             return solve_rec(m-1,1);
//         }else{
//             return solve_rec(m-1,solve_rec(m,n-1));
//         }
//     }
    
//     // Идея: использовать стек для имитации рекурсивной функции. Немного сложно понять
//     public static long solve(long m,long n){
//         Stack<Ack> stack = new Stack<>();
//         stack.push(new Ack(m,n));   // Помещаем запрошенное подтверждение
//         // res используется для записи значения ack (0, n)
//         // Если res больше 0, это означает, что текущий вызов функционального уровня (push) закончился, и началось всплывающее окно.
//         long res = -1;
//         while(!stack.empty()){
//             Ack ack = stack.peek(); // Анализируем подтверждение на вершине стека
//             if(ack.m == 0){         // m равно 0, результат решения ack (0, n) присваивается res и удаляется из стека
//                 res = ack.n+1;
//                 stack.pop();
//             }else if(ack.n == 0 && ack.m > 0){
//                 if(res < 0) {
//                     stack.push(new Ack(ack.m-1,1)); // res меньше 0, Ackermann (m, 0) = Ackermann (m-1,1);
//                 }
//                 else {
//                     stack.pop();    // res больше 0, это означает, что оно рассчитано и вы можете вытолкнуть
//                 }
//             }else{
//                 if(ack.data < 0){   // Значение пока не присвоено, только размер
//                     if(res < 0){
//                         stack.push(new Ack(ack.m,ack.n-1)); // Вычислить Ackermann (m, n-1), требуемое Ackermann (m, n)
//                     }else {
//                         ack.data = res; // Устанавливаем данные, чтобы определить, рассчитаны ли они
//                         res = -1;       // Сброс на 1
//                         stack.push(new Ack(ack.m-1,ack.data));// Ackermann (m, n) = Ackermann (m-1, Ackermann (m, n-1)), где Ackermann (m, n-1) - данные
//                     }
//                 }else{
//                     stack.pop();    // Используется вычисленное значение подтверждения, поэтому вытаскиваем его
//                 }
//             }
//         }
//         return res;
//     }

// }

// class Ack{
//     public long m;
//     public long n;
//     public long data;

//     public Ack(long m, long n) {
//         this.m = m;
//         this.n = n;
//         this.data = -1;
//     }
// }


// int[,] table = new int[3, 4];
// FillArrayRandom(table);
// PrintArray(table);
// SortToLower(table);
// Console.WriteLine();
// PrintArray(table);


// // Функция заполнения массива рандомно числами от 1 до 9
// void FillArrayRandom(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// // Функция сортировки элементов в строке двумерного массива, по убыванию
// void SortToLower(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
// }

// // Функция вывода двумерного массива
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
/*

int[,] CreatMatrix()
{

Console.Write("Enter quantity rows first matrix A: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter quantity colouns first matrix A: ");
int colouns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, colouns];

       
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colouns; j++)
        {
            array[i,j] = new Random().Next(-10, 10);
                      
        }
        
    }
return array; 
}

int[,] CreatMatrix2()
{
Console.Write("Enter quantity rows second matrix B: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter quantity colouns second matrix B: ");
int colouns2 = Convert.ToInt32(Console.ReadLine());

int[,] array2 = new int[rows2, colouns2];

       
    for(int i = 0; i < rows2; i++)
    {
        for(int j = 0; j < colouns2; j++)
        {
            array2[i,j] = new Random().Next(-10, 10);
                      
        }
    }

 return array2;     
}

void ShowArray(int[,] array)
{
    
    for(int i = 0; i < array.GetLength(0); i++)
    {
       
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");       
        }
        Console.WriteLine("");
        
    }
    Console.WriteLine("");
}

int[,] SumCompositionArray(int[,]array1, int[,]array2)
{
   
int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];

    for(int i = 0; i < array3.GetLength(0); i++)
    {
        for(int j = 0; j < array3.GetLength(1); j++)
        {
            if(j < array1.GetLength(1) == i < array2.GetLength(0))
            {
                array3[i,j] = 0;
                for(int k = 0; k < array1.GetLength(1); k++)  
                {            
                array3[i,j] = array3[i,j] + array1[i,k] * array2[k,j];
                }
            }
            else
            {
                
                Console.WriteLine();   
                Console.WriteLine("Error!");
                Console.WriteLine("In order for first matrix A to be multiplied by second matrix B, it is necessary that the number of columns of first matrix A be equal to the number of rows of second matrix B, and AB!=BA.");
                return array2;
            }
        }
    }
return array3;
}



// if(i   == CreatMatrix)
// {
int[,] Array1 = CreatMatrix();
Console.WriteLine();
Console.WriteLine("Matrix A: ");
ShowArray(Array1);
int[,] Array2 = CreatMatrix2();
Console.WriteLine("Matrix B: ");
ShowArray(Array2);
int[,] Array3 = SumCompositionArray(Array1, Array2);
Console.WriteLine("Matrix C: ");
ShowArray(Array3);
// }
// else
// {
//     Console.WriteLine();   
//     Console.WriteLine("Error!");
//     Console.WriteLine("In order for first matrix A to be multiplied by second matrix B, it is necessary that the number of columns of first matrix A be equal to the number of rows of second matrix B, and AB!=BA.");
// }

*/

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



Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

int[,] nums = new int[size, size];

int num = 1;
int i = 0;
int j = 0;

while (num <= size * size)
{
    nums[i, j] = num;
    if (i <= j + 1 && i + j < size - 1)
        ++j;
    else if (i < j && i + j >= size - 1)
        ++i;
    else if (i >= j && i + j > size - 1)
        --j;
    else
        --i;
    ++num;
}

PrintArray(nums);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " \t");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
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




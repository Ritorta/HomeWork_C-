/*
Task №1:
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:

7 4 2 1
9 5 3 2
8 4 4 2



// ---Вариант №1---
// Сортировка Пузырьком

int[,] CreateArray2D()
{
    int[,] array = new int[3,4];
        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 4; j++)
            {
                array[i,j] = new Random().Next(1,100 + 1);
            }
        }
return array; 
}

void ShowArray2D(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SortArray2D(int[,] array)
{
    
    for(int i = 0; i < array.GetLength(0); i++)
    {
       for(int j = 0; j < array.GetLength(1); j++)
       { 
            for(int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if(array[i,k] < array[i, k + 1])
                {
                int temp = 0;
                temp = array[i,k];
                array[i,k] = array[i, k + 1];
                array[i, k + 1] = temp;
                }
            }
            
        }
               
    }
  
}

int[,] newArray = CreateArray2D();
ShowArray2D(newArray);
SortArray2D(newArray);
ShowArray2D(newArray);



// ---Вариант №2---
// Метод отбора

int[,] CreateArray2D()
{
    int[,] array = new int[3,4];
        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 4; j++)
            {
                array[i,j] = new Random().Next(1,100 + 1);
            }
        }
return array; 
}

void ShowArray2D(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SortArray2D(int[,] array)
{
    
    int minNumber = 0;
    int temp = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1) - 1; j++)
        {
        
        minNumber = j;

            for(int k = j + 1; k < array.GetLength(1); k++)
            {
                if(array[i,k] > array[i, minNumber])
                {
                    minNumber = k;
                }
            }
            
//             if(minNumber != j)
//             {
//             temp = array[i, j];
//             array[i, j] = array[i, minNumber];
//             array[i, minNumber] = temp;
//             }

            temp = array[i, minNumber];
            array[i, minNumber] = array[i, j];
            array[i, j] = temp;
             
        }
              
    }
  
}

int[,] newArray = CreateArray2D();
ShowArray2D(newArray);
SortArray2D(newArray);
ShowArray2D(newArray);



// // ---Вариант №3---
// // Метод вставками

int[,] CreateArray2D()
{
    int[,] array = new int[3,4];
        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 4; j++)
            {
                array[i,j] = new Random().Next(1,100 + 1);
            }
        }
return array; 
}

void ShowArray2D(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SortArray2D(int[,] array)
{
    
    for(int i = 0; i < array.GetLength(0); i++)
    {
        
        for(int j = 0; j < array.GetLength(1); j++)
        {
        int index = j;
        int currentNumber = array[i,j];
            while(index > 0 && currentNumber > array[i, index - 1])  
            {
                array[i, index] = array[i, index - 1];
                index = index - 1;
            }
            array[i, index] = currentNumber;
        }
               
    }
  
}


int[,] newArray = CreateArray2D();
ShowArray2D(newArray);
SortArray2D(newArray);
ShowArray2D(newArray);

*/

// // ---Вариант №4---
// // Метод 

int[,] CreateArray2D()
{
    int[,] array = new int[3,4];
        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 4; j++)
            {
                array[i,j] = new Random().Next(1,100 + 1);
            }
        }
return array; 
}

void ShowArray2D(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SortArray2D(int[,] array)
{
    int index = 1;
    int nextIndex = index + 1;
    int temp = 0;

    for(int i = 0; i < array.GetLength(0); i++)
    {
       
        for(int j = 0; j < array.GetLength(1); j++)
        {
        
            while(index < array.GetLength(1))  
            {
                if(array[i, index - 1] > array[i, index]) 
                {
                    index = nextIndex;     
                    nextIndex++;
                }
                else
                {
                    temp = array[i, index - 1];
                    array[i, index - 1] = array[i, index];
                    array[i, index] = temp;
                    index = index - 1;

                    if(index == 0)
                    {
                        index = nextIndex;     
                        nextIndex++;
                    }
                    
                }
            }
           
        }
               
    }
  
}


int[,] newArray = CreateArray2D();
ShowArray2D(newArray);
SortArray2D(newArray);
ShowArray2D(newArray);

// void SortArray2D(int[,] array)
// {
//     int temp = 0;
//     int pivot = -1;
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//        for(int j = 0; j < array.GetLength(1); j++)
//        {
//                 if(array[i,j] < array[i, array.GetLength(0) - 1])
//                 {
//                     pivot++;
//                     temp = array[i, pivot];
//                     array[i, pivot] = array[i,j];
//                     array[i,j] = temp;

//                 }
            
//             pivot++;
//             temp = array[i, pivot];
//             array[i, pivot] = array[i, array.GetLength(0) - 1];
//             array[i, array.GetLength(0) - 1] = temp;
                
            
            
//         }
               
//     }
  
// }
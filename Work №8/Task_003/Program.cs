/*
Task №3:
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:

2 4 | 3 4
3 2 | 3 3

Результирующая матрица будет:

18 20
15 18



                        
//     a11 a12 a13       b11 b12 b13                
// A = a21 a22 a23 ; B = b21 b22 b23 ;  
//     a31 a32 a33       b31 b32 b33  

// Строку строку на каждый столбец и складываем, получаем С.

//             c11 = a11 * b11 + a12 * b21 + a13 * b31; | c21 = a21 * b11 + a22 * b21 + a23 * b31; | c31 = a31 * b11 + a32 * b21 + a33 * b31;
// C = A * B = c12 = a11 * b12 + a12 * b22 + a13 * b32; | c22 = a21 * b12 + a22 * b22 + a23 * b32; | c32 = a31 * b12 + a32 * b22 + a33 * b32;
//             c13 = a11 * b13 + a12 * b23 + a13 * b33; | c23 = a21 * b13 + a22 * b23 + a23 * b33; | c33 = a31 * b13 + a32 * b23 + a33 * b33;

// Чтобы матрицу №1 можно было умножить на матрицу №2 нужно, чтобы число столбцов матрицы №1 равнялось числу строк матрицы №2.              


// ---Вариант №1---
// Без проверки, нельзя задать размер второй матрицы, количество строк и стобцов должно быть равно иначе считает некоректно.

int[,] CreatMatrix(int rows, int colouns)
{
int[,] array = new int[rows, colouns];
       
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colouns; j++)
        {
            array[i,j] = new Random().Next(1, 10);            
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
            array3[i,j] = 0;
            for(int k = 0; k < array1.GetLength(1); k++)  
            {            
            array3[i,j] = array3[i,j] + array1[i,k] * array2[k,j];
            }
        }
    }
return array3;
}

Console.Write("Enter quantity rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter quantity colouns: ");
int colouns = Convert.ToInt32(Console.ReadLine());

if(rows == colouns)
{
int[,] Array1 = CreatMatrix(rows, colouns);
ShowArray(Array1);
int[,] Array2 = CreatMatrix(rows, colouns);
ShowArray(Array2);
int[,] Array3 = SumCompositionArray(Array1, Array2);
ShowArray(Array3);
}
else
{
       
    Console.WriteLine("Error!");
    Console.WriteLine("Enter an equal number of rows and colouns.");
}


*/
// ---Вариант №2---
// Можно задать размер второй матрицы, плюс проверка на коректность.


int[,] CreatMatrix(int rows, int colouns)
{
int[,] array = new int[rows, colouns];
       
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colouns; j++)
        {
            array[i,j] = new Random().Next(1, 10);            
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
            array3[i,j] = 0;
            for(int k = 0; k < array1.GetLength(1); k++)  
            {            
            array3[i,j] = array3[i,j] + array1[i,k] * array2[k,j];
            }
        }
    }
return array3;
}

Console.Write("Enter quantity rows first matrix A: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter quantity colouns first matrix A: ");
int colouns = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter quantity rows second matrix B: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter quantity colouns second matrix B: ");
int colouns2 = Convert.ToInt32(Console.ReadLine());

if(rows2 == colouns)
{
int[,] Array1 = CreatMatrix(rows, colouns);
Console.WriteLine();
Console.WriteLine("Matrix A: ");
ShowArray(Array1);
int[,] Array2 = CreatMatrix(rows2, colouns2);
Console.WriteLine("Matrix B: ");
ShowArray(Array2);
int[,] Array3 = SumCompositionArray(Array1, Array2);
Console.WriteLine("Matrix C: ");
ShowArray(Array3);

}
else
{
    Console.WriteLine();   
    Console.WriteLine("Error!");
    Console.WriteLine("In order for first matrix A to be multiplied by second matrix B, it is necessary that the number of columns of first matrix A be equal to the number of rows of second matrix B, and AB!=BA.");
}
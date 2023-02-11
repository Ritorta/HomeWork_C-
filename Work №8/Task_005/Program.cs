/*
Task №5:
Напишите программу, которая заполнит спирально массив A на B.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07

*/
// ---Вариант №1---
// 

// Console.Write("Enter length array: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter quantity colouns: ");
// int colouns = Convert.ToInt32(Console.ReadLine());


// int[,] newArray = SpiralArray(rows, colouns);
// ShowArray(newArray);


// int[,] SpiralArray(int rows, int colouns)
// {
//     int[,] array = new int[rows, colouns];

 
//     int indexValue = 1;
//     while(indexValue <= rows * colouns)
//     {
          
//         for(int i = 0; i < rows / colouns; i++)
//         {       
//             for(int j = i; j < rows - i; j++)
//             {
//             array[i, j] = indexValue++;
//             }

//             for(int k = i + 1; k < colouns - i ; k++)
//             {
//             array[k, colouns - 1 - i] = indexValue++;
//             }

//             for(int j = rows - i - 2; j > i; j--)
//             {
//             array[rows - 1 - i, j] = indexValue++;
//             }

//             for(int k = colouns - 1 - i; k > i ; k--)
//             {
//             array[k, i] = indexValue++;
//             }
//         }
//         indexValue++;
//     }

// return array;
// }

// void ShowArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " \t");
//         }
//         Console.WriteLine();
//     }
// }


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
      
        for(int i = 0; i < rows / colouns; i++)
        {       
            //Первая ступень
            for(int j = i; j < rows - i; j++)
            {
            array[i, j] = indexValue++;
            }

            for(int k = i + 1; k < colouns - i ; k++)
            {
            array[k, colouns - 1 - i] = indexValue++;
            }

            for(int j = rows - i - 2; j > i; j--)
            {
            array[rows - 1 - i, j] = indexValue++;
            }

            for(int k = colouns - 1 - i; k > i ; k--)
            {
            array[k, i] = indexValue++;
            }


            // Вторая ступень
            for(int j = i + 1 ; j < rows - 1; j++)
            {
            array[i + 1, j] = indexValue++;
            }

            for(int k = i + 2; k < colouns - 1 - i ; k++)
            {
            array[k, colouns - 2 - i] = indexValue++;
            }

            for(int j = rows - i - 3; j > i; j--)
            {
            array[rows - 2 - i, j] = indexValue++;
            }

            for(int k = colouns - 3 - i; k > i + 1 ; k--)
            {
            array[k, i + 1] = indexValue++;
            }

            // Третья ступень
            for(int j = i + 2 ; j < rows - 2; j++)
            {
            array[i + 2, j] = indexValue++;
            }

            for(int k = i + 3; k < colouns - 2 - i ; k++)
            {
            array[k, colouns - 3 - i] = indexValue++;
            }

            for(int j = rows - i - 4; j > i + 1; j--)
            {
            array[rows - 3 - i, j] = indexValue++;
            }

            for(int k = colouns - 4 - i; k > i + 2; k--)
            {
            array[k, i + 2] = indexValue++;
            }

             // Четвёртая ступень
            for(int j = i + 3 ; j < rows - 3; j++)
            {
            array[i + 3, j] = indexValue++;
            }

            for(int k = i + 4; k < colouns - 3 - i ; k++)
            {
            array[k, colouns - 4 - i] = indexValue++;
            }

            for(int j = rows - i - 5; j > i + 2; j--)
            {
            array[rows - 4 - i, j] = indexValue++;
            }

            for(int k = colouns - 5 - i; k > i + 3; k--)
            {
            array[k, i + 3] = indexValue++;
            }

            // Пять ступень
            for(int j = i + 4 ; j < rows - 4; j++)
            {
            array[i + 4, j] = indexValue++;
            }

            for(int k = i + 5; k < colouns - 4 - i ; k++)
            {
            array[k, colouns - 5 - i] = indexValue++;
            }

            for(int j = rows - i - 6; j > i + 3; j--)
            {
            array[rows - 5 - i, j] = indexValue++;
            }

            for(int k = colouns - 6 - i; k > i + 4; k--)
            {
            array[k, i + 4] = indexValue++;
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






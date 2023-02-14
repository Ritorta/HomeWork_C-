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
// 

Console.Write("Enter quantity list: ");
int layer = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter quantity rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter quantity colouns: ");
int colouns = Convert.ToInt32(Console.ReadLine());

if(layer == 0 || rows == 0 || colouns == 0)
{
    Console.WriteLine("Error!");
}
else if(layer <= 3 && rows <= 6 && colouns <= 5)
{
    int[,,] newArray = CreatTripleArray3D(layer, rows, colouns);
    ShowTripleArray3D(newArray);
    // SortArray3D(newArray);
    CheakArray3D(newArray);
    
}
else if(layer <= 3 && rows <= 5 && colouns <= 6)
{
    int[,,] newArray = CreatTripleArray3D(layer, rows, colouns);
    ShowTripleArray3D(newArray);
    // SortArray3D(newArray);
    // ShowTripleArray3D(newArray);
    CheakArray3D(newArray);
}
else
{
    Console.WriteLine("Error!");
}

int[,,] CreatTripleArray3D(int layer, int rows, int colouns)
{
    int[,,] array = new int[layer,rows,colouns];
    
    int num = array [0,0,0];

    for(int i = 0; i < layer; i++)
    {
        for(int j = 0; j < rows; j++)
        {
            for(int k = 0; k < colouns; k++)
            {

                array[i,j,k] = new Random().Next(10,99 +1);

            }
        }
    } 
    return array;
}

void ShowTripleArray3D(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine($"---Layer №: {(i + 1)}");
        for(int j = 0 ; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(" " + array[i,j,k] + " ");
                Console.Write($"({i},{j},{k})");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
          
void CheakArray3D(int[,,] array) 
{

int num = 0;

    for(int i = 0; i < array.GetLength(0); i++)
    {    
        for(int j = 0 ; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                num = k;

                for(int g = k + 1; g < array.GetLength(2); g++)
                {
                    while(array[i,j,k] == num)
    
                {
                    num++;
                    array[i,j,k] = num;
                }
                }
            }
        }    
    }

}






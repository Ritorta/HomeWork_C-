/*
Task №3:
Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]

*/
// ---Вариант №1---
// 

int[] ArrayInput(int leng)
{
int[] array = new int[leng];

    for(int i =0; i < leng; i++)
    {
        Console.Write($"Enter the array number {i + 1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
return array;    
}

void ArrayShow(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]}");
    }
Console.WriteLine();
}

Console.Write("Imput size array: ");
int leng = Convert.ToInt32(Console.ReadLine());

int[] result = ArrayInput(leng);
ArrayShow(result);


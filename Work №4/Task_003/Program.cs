/*
Task №3:
Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]

*/
// ---Вариант №3---
// 

int[] ArrayInput(int )
{

}



int[] CreateArray(int size)
{
    int[] array = new int[size];
    for(int i=0; i < size; i++)
    {
        Console.Write($"Input a {i + 1} element: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

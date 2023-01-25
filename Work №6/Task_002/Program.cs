/*
Task №2:
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

*/
// ---Вариант №1---
// 

Console.Write("Enter the x1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the y1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the x2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the y2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

// y = k1 * x + b1, y = k2 * x + b2;
// Приравниваем правые части данных равенств:
// k1 * x + b1 = k2 * x + b2
// Выражаем Х:
// x = (b2 - b1) / (k1 - k2)
// Подставим полученное значение х в выражение для у (для любого)
// y = k1 * (b2 - b1) / (k1 - k2) + b1

if(k1 == k2 & b1 != b2) // Условие прямые паралельны
{
    Console.WriteLine(" ");
    Console.Write("Thes lines Parallel.");
}
else if(k1 == k2 & b1 == b2) // Условие прямые совпадают
{
    Console.WriteLine(" ");
    Console.Write("Thes lines Match.");
}
else // Условие прямые пересекаются, if(k1 != k2)
{
double xAB = (b2 - b1) / (k1 - k2); // Текущий вывод вроде является правильным но не способен подойти под результат примена указанного в задаче,
                                    // но если поменять знаки на "(-b2 + b1)/(-k1 + k2)" можно получить равильный ответу.
double yAB = k1 * xAB + b1;  

    if (k1 * k2 == -1) // Условие прямые перпендикулярны 
        {
             Console.WriteLine(" ");
             Console.Write("Thes lines Perpendicular.");
        }

xAB = Math.Round(xAB, 3);
yAB = Math.Round(yAB, 3);

Console.WriteLine(" ");
Console.WriteLine($"The point intersection: ({xAB}; {yAB})");
}

          






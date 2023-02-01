/*

Task №4:
Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8


//              --------------- !!!Несколько вариаций решения!!! -----------------

// Первый вариант:

Console.Write("Enter the Start Number: ");
int numb = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the End Number: ");
int numb2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Even numbers from the range: ");

for (int count = numb; count <= numb2; count++)

    if (count %2 == 0)
    {
       Console.Write(count + ", "); // Интересно как сделать чтобы вконце была точка.
    }


// Второй вариант:

Console.Write("Enter the Number: ");
int numb = Convert.ToInt32(Console.ReadLine());

Console.Write("Even numbers from the range: ");

for (int count = 2; count <= numb; count++)

    if (count %2 == 0)
    {
       Console.Write(count + ", "); // Интересно как сделать чтобы вконце была точка?

    }
    

//Третий вариант:

Console.Write("Enter the Number: ");
int numb = Convert.ToInt32(Console.ReadLine());

Console.Write("Even numbers from the range: ");

int current = 2;

while (current <= numb)
{
   if (current %2 == 0)
   Console.Write(current + ", ");
   current = current + 1;
}


// Чётвертый вариант: (Здесь я пытался вписать точку с оператором for)

Console.Write("Enter the Number: ");
int numb = Convert.ToInt32(Console.ReadLine());

Console.Write("Even numbers from the range: ");

for (int count = 2; count <= numb; count++)

    if (count %2 == 0)
    {
      Console.Write(count);
         if (count <= numb - 1 ) 
         // Я потратил кучу времени, чтобы написать это с точкой, прям целый день,
         // самое главное, я додумался до этого НО,
         // только через гугл я смог понять, что нехватало "-1", хех...
         {
            Console.Write(", ");
         }
       
    }
    Console.Write(".");
        
// Пятый вариант: (Здесь я пытался вписать точку с оператором while)

Console.Write("Enter the Number: ");
int numb = Convert.ToInt32(Console.ReadLine());

int current = 2;

Console.Write("Even numbers from the range: ");

while (current <= numb)
{
   if (current %2 == 0)
      Console.Write(current);
         else if (current <= numb) 
         // Здесь постоянно будлировались запятые, решение было в том, 
         // чтобы к if добавить else, не особо понял почему это решило проблему но оно решило,
         // достигнуто методом проб и ошибок.
         {
         Console.Write(", ");
         }
      
   current = current + 1;
}

Console.Write(".");

*/

// Шестой вариант: (Здесь я тоже вписал точку, данный вариант нахождения чётных мне нравиться больше, т.к можно найти и отрицательные значения)

Console.Write("Enter the Start Number: ");
int numb = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the End Number: ");
int numb2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Even numbers from the range: ");

for (int count = numb; count <= numb2; count++)

    if (count %2 == 0)
    {
      Console.Write(count);
         if (count <= numb2 - 1 )
            {
               Console.Write(", ");
            }
    }
Console.Write(".");

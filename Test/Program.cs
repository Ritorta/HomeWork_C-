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


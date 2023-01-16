/*
Task №2:
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53


!!! d = √ (х А – х В) 2 + (у А – у В) 2 + (z A - z B) 2 !!!

Math.Pow(a,b) - а числов, b квадрат.
Math.Sqrt(a) - только квадратный корень.

// ---Вариант №1---
// Базовая рабочая программа.

double PointPF (double Ax, double Ay, double Az, double Bx, double By, double Bz)
{
    return Math.Sqrt(Math.Pow((Ax - Bx), 2)  + Math.Pow((Ay - By),2) + Math.Pow((Az - Bz),2));
}


Console.WriteLine("Coordinate A");
Console.Write("First Coordinate Ax: ");
double Ax = Convert.ToDouble(Console.ReadLine());
Console.Write("Second Coordinate Ay: ");
double Ay = Convert.ToDouble(Console.ReadLine());
Console.Write("Third Coordinate Az: ");
double Az = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Coordinate B");
Console.Write("First Coordinate Bx: ");
double Bx = Convert.ToDouble(Console.ReadLine());
Console.Write("Second Coordinate By: ");
double By = Convert.ToDouble(Console.ReadLine());
Console.Write("Third Coordinate Bz: ");
double Bz = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

Console.Write(PointPF(Ax, Ay, Az, Bx, By, Bz));

// ---Вариант №2---
// Применил ещё один дополнительный оператор, чтобы убрать лишние числа после запятой.



double PointPF (double Ax, double Ay, double Az, double Bx, double By, double Bz)
{
    double Mat = Math.Sqrt(Math.Pow((Ax - Bx), 2)  + Math.Pow((Ay - By),2) + Math.Pow((Az - Bz),2));
    double Mt = Math.Round(Mat, 2);
    return Mt;
}


Console.WriteLine("Coordinate A");
Console.Write("First Coordinate Ax: ");
double Ax = Convert.ToDouble(Console.ReadLine());
Console.Write("Second Coordinate Ay: ");
double Ay = Convert.ToDouble(Console.ReadLine());
Console.Write("Third Coordinate Az: ");
double Az = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Coordinate B");
Console.Write("First Coordinate Bx: ");
double Bx = Convert.ToDouble(Console.ReadLine());
Console.Write("Second Coordinate By: ");
double By = Convert.ToDouble(Console.ReadLine());
Console.Write("Third Coordinate Bz: ");
double Bz = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

Console.Write(PointPF(Ax, Ay, Az, Bx, By, Bz));

*/
// ---Вариант №3---
// Расписной пример без Math.



Console.WriteLine("Coordinate A");
Console.Write("First Coordinate Ax: ");
double Ax = Convert.ToDouble(Console.ReadLine());
Console.Write("Second Coordinate Ay: ");
double Ay = Convert.ToDouble(Console.ReadLine());
Console.Write("Third Coordinate Az: ");
double Az = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Coordinate B");
Console.Write("First Coordinate Bx: ");
double Bx = Convert.ToDouble(Console.ReadLine());
Console.Write("Second Coordinate By: ");
double By = Convert.ToDouble(Console.ReadLine());
Console.Write("Third Coordinate Bz: ");
double Bz = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

double A = (Bx - Ax);
double B = (By - Ay);
double C = (Bz - Az);
double D = (A * A + B * B + C * C);

double Sqrt(double D) 
{
    double num = D; // Присваиваем наше число для вычесления.
    double root = num / 2; // Корень.
    double eps = 0.01; // Допустимая погрешность.
    int count = 0;
    while(root - num / root > eps)
    {
        root = (root + num / root) * 0.5;
        count++;
    }
return root;
}

double F = Sqrt(D);

string X = F.ToString("#.##");

Console.Write(X);


/*

// Алгоритм вычисления корня n-ой степени из произвольного положительного числа

int main(void) {
    double num = 570.15;
    double root = num / 2;
    double eps = 0.01;
    int iter = 0;
    while( root - num / root > eps ){
        iter++;
        root = 0.5 * (root + num / root);
        printf("Iteration: %d : root = %f\n", iter, root);
    }
    printf("root = %f", root);
    return 0;
}

// Ниже логарифмическая сложность алгоритма? Или другая? :)

// Теперь уже можно переходить к усложненному варианту задачи. В этом случае решение получается более обобщенным.

double mabs(double x){ return (x < 0)? -x : x; }
 
int main(void) {
    double num = 8;
    int rootDegree = 3;
 
    printf("Число, корень которого считаем а = %f\n", num);
    printf("Корень степени n = %d\n", rootDegree);
   
    double eps = 0.00001;             //допустимая погрешность
    double root = num / rootDegree;   //начальное приближение корня
    double rn = num;                  //значение корня последовательным делением
    int countiter = 0;                //число итераций
    while(mabs(root - rn) >= eps){
        rn = num;
        for(int i = 1; i < rootDegree; i++){
            rn = rn / root;
        }
        root = 0.5 * ( rn + root);
        countiter++;
    }
   
    printf("root = %f\n", root);
    printf("Число итераций = %i\n", countiter);
   
    return 0;
}

*/
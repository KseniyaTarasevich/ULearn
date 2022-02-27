using System;

namespace BasicExercises
{
    class BasicExercises
    {
        static void Main(string[] args)
        {
            // Swap(1, 2);
            // Console.WriteLine(RotateTheNumber(123));
            // Console.WriteLine(CalculateTime(20));
            // Console.WriteLine(FindNumbers(50,7,7));
            // Console.WriteLine(LeapYear(10,3670));
            // Console.WriteLine(PointDistance(1,5,3,-4,-3)); 
            // FindVector(1, -2, 5);
            // FindPoint(2, 1, -2, 3);

        }

        // Expr1. 
        // Как поменять местами значения двух переменных? Можно ли это сделать без ещё одной временной переменной. Стоит ли так делать?
        // Можно, так выглядит более запутанно
        static void Swap(int a, int b)
        {
            int temp = 0;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine(a + " " + b);
        }

        // Expr2. 
        // Задается натуральное трехзначное число (гарантируется, что трехзначное). 
        // Развернуть его, т.е. получить трехзначное число, записанное теми же цифрами в обратном порядке.
        static int RotateTheNumber(int number)
        {
            int b = number % 10;
            number /= 10;
            int c = number % 10;
            number /= 10;
            int d = number;
            return 100 * b + 10 * c + d;
        }

        // Expr3.
        // Задано время Н часов (ровно). Вычислить угол в градусах между часовой и минутной стрелками. 
        // Например, 5 часов -> 150 градусов, 20 часов -> 120 градусов. Не использовать циклы.

        static int CalculateTime(int t)
        {
            // 360°/12 = 30° - один час
            int angle;
            angle = -1;

            if (t <= 6)
            {
                angle = (t * 30);
            }

            if (t > 6 && t <= 18)
            {
                angle = (t - 12) * 30;
            }

            if (t > 18 && t <= 24)
            {
                angle = (24 - t) * 30;
            }

            return angle;
        }

        // Expr4.
        // Найти количество чисел меньших N, которые имеют простые делители X или Y.

        static int FindNumbers(int n, int x, int y)
        {
            // n / (x * y) - исключаем числа, которые делятся на оба делителя
            int quantity = n / x + n / y - n / (x * y);
            return quantity;
        }

        // Expr5. 
        // Найти количество високосных лет на отрезке [a, b] не используя циклы.

        static int LeapYear(int a, int b)
        {
            int answer;
            answer = (b - a) / 366;
            return answer;
        }

        // Expr6. 
        // Посчитать расстояние от точки до прямой, заданной двумя разными точками.

        static double PointDistance(int x, int y, int a, int b, int c)
        {
            return (Math.Abs(a * x + b * y + c)) / (Math.Sqrt(a * a + b * b));
        }

        // Expr7. 
        // Найти вектор, параллельный прямой. Перпендикулярный прямой. Прямая задана коэффициентами уравнения прямой.

        static void FindVector(int a, int b, int c)
        {
            // направляющий вектор прямой - параллельный ей вектор или лежащий на ней p(-B; C)
            // вектора параллельны, если существует такое число l, что a=l*b
            int parVectorX = -2 * b;
            int parVectorY = 2 * c;
            Console.WriteLine("Параллельный вектор: (" + parVectorX + "; " + parVectorY + ")");
           
            // (A; B) - вектор, перпендикулярный прямой
            Console.WriteLine("Перпендикулярный вектор: (" + a + "; " + b + ")");
        }


        // Expr8. 
        // Дана прямая L и точка A. 
        // Найти точку пересечения прямой L с перпендикулярной ей прямой P, проходящей через точку A. 
        // Можете считать, что прямая задана либо двумя точками, либо коэффициентами уравнения прямой — как вам удобнее.

        static void FindPoint (int ax, int ay, double k, double b)
        {
            // найдем коэффициенты уравнения прямой, проходящей через точку А и перпендикулярной данной прямой 
            double k2 = -1 / k;
            double b2 = ay - k2 * ax;

            // найдем точку пересечения 
            double x = (b2 - b) / (k - k2);
            double y = k2 * x + b2;

            Console.WriteLine("Точка пересечения: (" + x + "; " + y + ")");
        }
    }
}

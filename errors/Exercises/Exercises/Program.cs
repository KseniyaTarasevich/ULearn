using System;


namespace Exercises
{
    class Program
    {

        // Expr10. Найти сумму всех положительных чисел меньше 1000 кратных 3 или 5.
        static string FindSum()
        {
            int a1 = 3;
            int d1 = 3;
            int b1 = 5;
            int d2 = 5;
            int n1 = 333;
            int n2 = 200;

            int sum1 = ((2 * a1 + d1 * (n1 - 1)) * n1) / 2;
            int sum2 = ((2 * b1 + d2 * (n2 - 1)) * n2) / 2;
            return (sum1 + sum2 - (2 * a1 * b1 + (a1 + b1) * 65) * 65 / 2).ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine(FindSum());
        }
    }
}

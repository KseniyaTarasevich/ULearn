using System;


namespace Exercises
{
    class Program
    {

        // Expr10. 
        // Найти сумму всех положительных чисел меньше 1000 кратных 3 или 5.
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

        // Expr11. 
        // Дано время в часах и минутах. Найти угол от часовой к минутной стрелке на обычных часах.
        public static void FindAngle()
        {
            Console.WriteLine("Enter hours: ");
            int hour = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter minutes: ");
            int minute = int.Parse(Console.ReadLine());
            Console.WriteLine("Angle:" + (double)((hour + minute / 60) * 30 - minute * 6));
        }

        // Expr13. 1084. Пусти козла в огород
        // Козла пустили в квадратный огород и привязали к колышку.
        // Колышек воткнули точно в центре огорода.Козёл ест всё, до чего дотянется, не перелезая через забор огорода и не разрывая веревку.
        //Какая площадь огорода будет объедена? Даны длина веревки и размеры огорода.
        public static void FindArea(string dataInput)
        {
            string[] data = dataInput.Split(' ');
            double a = double.Parse(data[0]);
            double r = double.Parse(data[1]);
            double s;

            if (r <= a / 2) s = Math.PI * r * r;
            else if (r >= a * Math.Sqrt(2) / 2) s = a * a;
            else s = Math.PI * r * r - 2 * r * r * (Math.Acos((r * r - Math.Sqrt(r * r - a * a / 4)) / r * r) - (Math.Sqrt(1 - (r * r - Math.Sqrt(r * r - a * a / 4)) / r * r)));
            Console.WriteLine(s);
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(FindSum());
            //FindAngle();
            string str = Console.ReadLine();
            FindArea(str);
        }
    }
}

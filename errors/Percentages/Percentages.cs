using System;


namespace Percentages
{
    class Percentages
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.WriteLine(Calculate(str));
        }

        public static double Calculate(string userInput)
        {
            string[] strSplit = userInput.Split(' ');
            double sum = double.Parse(strSplit[0]);
            double per = double.Parse(strSplit[1]);
            double term = double.Parse(strSplit[2]);
            return sum * Math.Pow((1 + per / 100 / 12), term);
        }
    }
}


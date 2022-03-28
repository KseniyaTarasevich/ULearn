using System;

namespace LoopsModule
{
    class Program
    {
        // Loops1.
        // Дано целое неотрицательное число N.
        // Найти число, составленное теми же десятичными цифрами, что и N, но в обратном порядке.
        // Запрещено использовать массивы.
        public static string FindReverse(string userInput)
        {
            string newNumber = "";

            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                newNumber += userInput[i];
            }
            return newNumber;
        }

        // Loops2.
        // Дано N(1 ≤ N ≤ 27).
        // Найти количество трехзначных натуральных чисел, сумма цифр которых равна N.
        // Операции деления(/, %) не использовать.
        public static void FindQuantity(int n)
        {
            int count = 0;
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    for (int k = 0; k <= 9; k++)
                    {
                        if (i + j + k == n)
                        {
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }

        // Loops3.
        // Если все числа натурального ряда записать подряд каждую цифру в своей позиции,
        // то необходимо ответить на вопрос: какая цифра стоит в заданной позиции N.
        public static string FindDigit(string userInput, int n)
        {
            string[] numbers = userInput.Split(' ');
            return numbers[n];
        }

        // Loops4.
        // В массиве чисел найдите самый длинный подмассив из одинаковых чисел.
        public static void FindArray(string userInput)
        {
            int count = 1;
            int maxCount = 1;
            for (int i = 1; i < userInput.Length; i++)
            {
                if (userInput[i] == userInput[i - 1])
                    count++;

                if (count > maxCount)
                {
                    maxCount = count;
                    count = 1;
                }
            }
            Console.WriteLine(maxCount);
        }

        // Loops5.
        // Дана строка из символов '(' и ')'.
        // Определить, является ли она корректным скобочным выражением.
        // Определить максимальную глубину вложенности скобок.
        public static void FindCorrectExpression(string userInput)
        {
            int openBracket = 0;
            int closeBracket = 0;

            for (int i = 0; i < userInput.Length; i++)
            {
                if (userInput[i] == '(')
                {
                    openBracket++;
                }

                else if (userInput[i] == ')')
                {
                    closeBracket++;
                }
            }

            if (openBracket == closeBracket)
                Console.WriteLine("correct");
            else Console.WriteLine("incorrect");

            Console.WriteLine("open brackets: " + openBracket + "\nclose brackets: " + closeBracket);
        }

        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            // Console.WriteLine(FindReverse(userInput));
            // FindQuantity(10);
            // Console.WriteLine(FindDigit(userInput, 2));
            // FindArray(userInput);
            FindCorrectExpression(userInput);
        }

    }
}
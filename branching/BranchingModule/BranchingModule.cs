using System;

namespace BranchingModule
{
    class BranchingModule
    {

        // Cond1.
        // Дана начальная и конечная клетки на шахматной доске.
        // Корректный ли это ход на пустой доске для: слона, коня, ладьи, ферзя, короля?
        public static void MakeStep(string userInput)
        {
            string[] data = userInput.Split(' ');
            int x = int.Parse(data[0]);
            int y = int.Parse(data[1]);
            int xNext = int.Parse(data[2]);
            int yNext = int.Parse(data[3]);

            if ((xNext + yNext == x + y || Math.Abs(xNext - x) == Math.Abs(yNext - y))
                || (Math.Abs(xNext - x) == 1 && Math.Abs(yNext - y) == 2 || Math.Abs(xNext - x) == 2 && Math.Abs(yNext - y) == 1)
                || (xNext - x == 0 && yNext - y != 0 || xNext - x != 0 && yNext - y == 0)
                || (Math.Abs(xNext - x) == 1 && Math.Abs(yNext - y) <= 1 || Math.Abs(yNext - y) == 1 && Math.Abs(xNext - x) <= 1))
                Console.WriteLine("Queen can make this step");

            if (xNext + yNext == x + y || Math.Abs(xNext - x) == Math.Abs(yNext - y))
                Console.WriteLine("Bishop can make this step");
            else if (Math.Abs(xNext - x) == 1 && Math.Abs(yNext - y) == 2 || Math.Abs(xNext - x) == 2 && Math.Abs(yNext - y) == 1)
                Console.WriteLine("Knight can make this step");
            else if (xNext - x == 0 && yNext - y != 0 || xNext - x != 0 && yNext - y == 0)
                Console.WriteLine("Castle can make this step");
            else if (Math.Abs(xNext - x) == 1 && Math.Abs(yNext - y) <= 1 || Math.Abs(yNext - y) == 1 && Math.Abs(xNext - x) <= 1)
                Console.WriteLine("King can make this step");

            else Console.WriteLine("This step is unavailable");
        }

        // Cond2.
        // Пролезет ли брус со сторонами x, y, z в отверстие со сторонами a, b, если его разрешается поворачивать на 90 градусов?

        public static void FitSides(int a, int b, int x, int y, int z)
        {
            if (x * y <= a * b || x * z <= a * b || y * z <= a * b)
                Console.WriteLine("yes");
            else Console.WriteLine("no");
        }

        // Cond3. (1493. В одном шаге от счастья) 
        // Дан номер трамвайного билета, в котором суммы первых трёх цифр и последних трёх цифр отличаются на 1 (но не сказано, в какую сторону). 
        // Правда ли, что предыдущий или следующий билет счастливый?

        public static string IsLucky(string userInput)
        {
            int firstPart = int.Parse(userInput.Substring(0, 3));
            string userInputCopy = userInput;
            int secondPart = int.Parse(userInputCopy.Substring(3, 3));

            int a1 = firstPart % 10;
            firstPart /= firstPart;
            int a2 = firstPart % 10;
            firstPart /= firstPart;
            int sum1 = firstPart + a1 + a2;

            int b1 = secondPart % 10;
            secondPart /= secondPart;
            int b2 = secondPart % 10;
            secondPart /= secondPart;
            int sum2 = secondPart + b1 + b2;

            if (sum1 - sum2 == 1) return "next ticket is lucky";
            else return "previous ticket is lucky";
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Enter coordinates: x, y, xNext, yNext");
            string userInput = Console.ReadLine();
            Console.WriteLine(IsLucky(userInput));
            //MakeStep(userInput);

            // FitSides(3, 2, 2, 1, 1);
        }
    }
}

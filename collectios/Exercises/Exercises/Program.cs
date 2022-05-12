
namespace Exercises
{
    class Program
    {
        /* 
        Col2. 
        Дан массив чисел, заполненный нулями. 
        Поступают запросы вида: увеличить все числа на отрезке [L, R] на X. 
        Нужно быстро обработать их и вывести содержимое массива после всех этих запросов.
        */
        public static int[] Col2(int[] array, int l, int r, int x)
        {
            for (int i = l; i < r; i++)
            {
                array[i] += x;
            }
            return array;
        }

        /*
         Col3. 
         В массиве чисел найти подмассив (непрерывный отрезок исходного массива) с максимальной суммой.
         */

        public static int Col3(int[] array, int length)
        {
            int sum = 0;
            int newSum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];

                while (length != 0)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        sum += array[j];
                        length--;
                    }
                }

                if (sum > newSum)
                    newSum = sum;

                sum = 0;
            }
            return sum;
        }

        static void Main(string[] args)
        {
        }
    }
}

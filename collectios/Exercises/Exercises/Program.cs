using System.Collections.Generic;

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

        public static int[] Col3(int[] array, int length)
        {
            int sum = 0;
            int newSum = 0;

            List<int> list = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                list.Add(array[i]);

                while (length != 0)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        sum += array[j];
                        length--;
                        list.Add(array[j]);
                    }
                }

                if (sum > newSum)
                {
                    newSum = sum;
                    list.Clear();
                }

                sum = 0;
            }
            return list.ToArray();
        }

        /* 
         Col5. 
         Даны два массива. Входит ли первый массив во второй как подпоследовательность? 
         Подпоследовательность — это последовательность элементов в том же порядке, но часть элементов может отсутствовать.
        */

        public static bool Col5(int[] array1, int[] array2)
        {
            bool isEnter = false;

            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j])
                        isEnter = true;

                    break;
                }

                if (isEnter) break;
            }

            return isEnter;
        }

        static void Main(string[] args)
        {
        }
    }
}

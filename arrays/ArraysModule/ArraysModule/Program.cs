using System;
using System.Collections.Generic;

/*



Arr3. Перевести число из системы счисления с основанием A в систему с основанием B. Можно считать, что 2 ≤ A, B ≤ 10, а число дано в виде массива цифр.

Arr4. Превратить рациональную дробь a/b (0 < a < b < 100000) в десятичную. Возможен период. "1/6" должна превратиться в "0.1(6)"

Arr5. * Дан неубывающий массив положительных целых чисел. Найти наименьшее положительное целое число, не представимое в виде суммы элементов этого массива (каждый элемент разрешается использовать в сумме только один раз).

Arr6. 1139. Городские кварталы

Arr7. 1490. Огненный круг*/

namespace ArraysModule
{
    class Program
    {
        // Arr1.
        // Дан массив чисел. Нужно его сдвинуть циклически на K позиций влево, не используя других массивов.

        public static void MakeOffset(int[] array, int k)
        {
            for (int i = 0; i < k; i++)
            {
                int temp = array[0];

                for (int j = 0; j < array.Length - 1; j++)
                {
                    array[j] = array[j + 1];
                }
                array[array.Length - 1] = temp;
            }

            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
        }

        // Arr2.
        // Даны два неубывающих массива чисел.
        // Сформировать неубывающие массивы, являющиеся объединением, пересечением и разностью этих двух массивов (разность в смысле мультимножеств).

        public static void MakeNewArray(int[] array1, int[] array2)
        {
            List<int> unification = new List<int>();
            List<int> intersection = new List<int>();
            List<int> difference = new List<int>();

            for (int i = 0; i < array1.Length; i++)
            {
                unification.Add(array1[i]);
                difference.Add(array1[i]);
            }

            foreach (int number in array2)
            {
                if (!unification.Contains(number)) unification.Add(number);
                if (difference.Contains(number)) difference.Remove(number);
            }


            for (int j = 0; j < array2.Length; j++)
            {
                for (int k = 0; k < array1.Length; k++)
                {
                    if (array2[j] == array1[k]) intersection.Add(array2[j]);
                }
            }

            Console.Write("unification: ");
            for (int i = 0; i < unification.Count; i++)
                Console.Write(unification[i] + " ");

            Console.WriteLine();

            Console.Write("intersection: ");
            for (int i = 0; i < intersection.Count; i++)
                Console.Write(intersection[i] + " ");

            Console.WriteLine();

            Console.Write("difference: ");
            for (int i = 0; i < difference.Count; i++)
                Console.Write(difference[i] + " ");
        }
        static void Main(string[] args)
        {
            //MakeOffset(new int[] { 11, 12, 13, 14, 15 }, 2);
            MakeNewArray(new int[] { 1, 2, 3 }, new int[] { 2, 4 });
        }
    }
}

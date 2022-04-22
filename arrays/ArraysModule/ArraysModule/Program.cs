using System;

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
            int[] unification = new int[array1.Length + array2.Length];
            int[] intersection = new int[Math.Min(array1.Length, array2.Length)];
            int[] difference = new int[array1.Length];

            for (int i = 0; i < array1.Length; i++)
            {
                unification[i] = array1[i];
            }

            for (int j = 0; j < array2.Length; j++)
            {
                for (int k = 0; k < array1.Length; k++)
                {
                    if (array2[j] != unification[k]) unification[array1.Length + 1] = array2[j];
                }
            }

            for (int i = 0; i < unification.Length; i++)
                Console.Write(unification[i] + " ");

            for (int j = 0; j < array2.Length; j++)
            {
                for (int k = 0; k < array1.Length; k++)
                {
                    if (array2[j] == array1[k]) intersection[j] = array2[j];
                }
            }

            Console.WriteLine();

            for (int i = 0; i < intersection.Length; i++)
                Console.Write(intersection[i] + " ");

            for (int j = 0; j < difference.Length; j++)
            {
                for (int k = 0; k < array2.Length; k++)
                {
                    if (array1[j] != array2[k]) difference[j] = array1[j];
                }
            }

            Console.WriteLine();

            for (int i = 0; i < difference.Length; i++)
                Console.Write(difference[i] + " ");
        }
        static void Main(string[] args)
        {
            //MakeOffset(new int[] { 11, 12, 13, 14, 15 }, 2);
            MakeNewArray(new int[] { 1, 2, 3 }, new int[] { 2, 4 });
        }
    }
}

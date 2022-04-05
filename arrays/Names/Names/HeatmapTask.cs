using System;

namespace Names
{
    internal static class HeatmapTask
    {
        public static HeatmapData GetBirthsPerDateHeatmap(NameData[] names)
        {
            int[] days = { 2, 3, 4, 5, 6, 7, 8, 9, 10,
                11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31 };

            int[] months = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            double[,] heat = new double[30, 12];

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].BirthDate.Day != 1)
                    heat[names[i].BirthDate.Day - 2, names[i].BirthDate.Month - 1]++;
            }

            var xLabel = new string[30];

            for (int j = 0; j < days.Length; j++)
                xLabel[j] = days[j].ToString();

            var yLabel = new string[12];

            for (int k = 0; k < months.Length; k++)
                yLabel[k] = months[k].ToString();

            return new HeatmapData(
                "Пример карты интенсивностей",
                heat,
                xLabel,
                yLabel);
        }
    }
}
using System;

namespace Names
{
    internal static class HeatmapTask
    {
        public static HeatmapData GetBirthsPerDateHeatmap(NameData[] names)
        {
            var days = new int[31];

            for (int i = 0; i < days.Length; i++)
            {
                days[i] = i + 1;
            }

            var daysString = new string[31];

            for (var j = 0; j < days.Length; j++)
                daysString[j] = days[j].ToString();

            var month = new int[12];
            for (int i = 0; i < month.Length; i++)
            {
                month[i] = i + 1;
            }

            var monthsString = new string[12];

            for (var j = 0; j < month.Length; j++)
                monthsString[j] = month[j].ToString();

            return new HeatmapData(
                "Пример карты интенсивностей",
                new double[,] { { 1, 2, 3 }, { 2, 3, 4 }, { 3, 4, 4 }, { 4, 4, 4 } },
                daysString,
                monthsString);
        }
    }
}


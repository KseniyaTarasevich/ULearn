using System;

namespace Names
{
    internal static class HistogramTask
    {
        public static HistogramData GetBirthsPerDayHistogram(NameData[] names, string name)
        {
            var days = new int[31];
            for (int i = 0; i < days.Length; i++)
            {
                days[i] = i + 1;
            }

            var birthsCounts = new double[31]; 

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Name == name && names[i].BirthDate.Day != 1)
                    birthsCounts[names[i].BirthDate.Day - 1]++;
            }

            var daysString = new string[31];

            for (var j = 0; j < days.Length; j++)
                daysString[j] = days[j].ToString();

            return new HistogramData(
                string.Format("Рождаемость людей с именем '{0}'", name),
                daysString,
                birthsCounts);
        }
    }
}
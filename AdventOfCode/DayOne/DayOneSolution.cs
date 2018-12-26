using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode.DayOne
{
    public static class DayOneSolution
    {
        private static string[] myInput = File.ReadAllLines($"{Directory.GetCurrentDirectory()}/DayOne/input.txt");

        public static int First(string input) => GetFrequencyChanges(input).Sum();

        public static int? Second(string input)
        {
            var visited = new List<int>() { 0 };
            var frequency = 0;
            var index = 0;
            int? duplicateFrequency = null;

            var frequencyChanges = GetFrequencyChanges(input);

            while (duplicateFrequency == null)
            {
                if (index == frequencyChanges.Count)
                {
                    index = 0;
                }

                var frequencyChange = frequencyChanges[index];

                frequency += frequencyChange;
                Console.WriteLine($"current frequency: {frequency}");

                visited.Add(frequency);

                if (visited.Where(v => v == frequency).Count() > 1)
                {
                    duplicateFrequency = frequency;
                }

                index++;
            }

            return duplicateFrequency;
        }

        private static List<int> GetFrequencyChanges(string input) => string.IsNullOrEmpty(input)
                ? myInput.Select(s => Convert.ToInt32(s)).ToList()
                : input.Split(',').Select(s => Convert.ToInt32(s)).ToList();
    }
}

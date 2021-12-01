using AdventOfCode.Services;

using System;
using System.Collections.Generic;

namespace AdventOfCode
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            FileReader fileReader = new FileReader();
            ExecuteDayOne(fileReader);
        }

        private static void ExecuteDayOne(FileReader fileReader)
        {
            List<decimal> input = fileReader.ReadDecFromListFile("Inputs/Day1.1.txt");
            DayOne day = new DayOne();
            ResultWriter.Write(day.GetNrOfIncreasings(input).ToString(), 1, 1);
            ResultWriter.Write(day.GetNrOfIncreasings(input, true).ToString(), 1, 2);
        }
    }
}
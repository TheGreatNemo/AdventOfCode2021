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
            ExecuteDayTwo(fileReader);
        }

        private static void ExecuteDayOne(FileReader fileReader)
        {
            List<decimal> input = fileReader.ReadDecFromListFile("Inputs/Day1.1.txt");
            DayOne day = new DayOne();
            ResultWriter.Write(day.GetNrOfIncreasings(input).ToString(), 1, 1);
            ResultWriter.Write(day.GetNrOfIncreasings(input, true).ToString(), 1, 2);
        }

        private static void ExecuteDayTwo(FileReader fileReader)
        {
            List<string> input = fileReader.ReadLinesFromFile("Inputs/Day2.1.txt");
            DayTwo day = new DayTwo();
            ResultWriter.Write(day.GetPosition(input).ToString(), 2, 1);
            ResultWriter.Write(day.GetAimPosition(input).ToString(), 2, 2);
        }
    }
}
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
            ExecuteDayOne(fileReader, 1);
            ExecuteDayTwo(fileReader, 2);
            ExecuteDayThree(fileReader, 3);
            ExecuteDayFour(fileReader, 4);
        }

        private static void ExecuteDayOne(FileReader fileReader, int day)
        {
            List<decimal> input = fileReader.ReadDecFromListFile($"Inputs/Day{day}.txt");
            DayOne puzzle = new DayOne();
            ResultWriter.Write(puzzle.GetNrOfIncreasings(input).ToString(), day, 1);
            ResultWriter.Write(puzzle.GetNrOfIncreasings(input, true).ToString(), day, 2);
        }

        private static void ExecuteDayTwo(FileReader fileReader, int day)
        {
            List<string> input = fileReader.ReadLinesFromFile($"Inputs/Day{day}.txt");
            DayTwo puzzle = new DayTwo();
            ResultWriter.Write(puzzle.GetPosition(input).ToString(), day, 1);
            ResultWriter.Write(puzzle.GetAimPosition(input).ToString(), day, 2);
        }

        private static void ExecuteDayThree(FileReader fileReader, int day)
        {
            List<string> input = fileReader.ReadLinesFromFile($"Inputs/Day{day}.txt");
            DayThree puzzle = new DayThree();
            ResultWriter.Write(puzzle.GetPowerConsumption(input).ToString(), day, 1);
            ResultWriter.Write(puzzle.GetLifeSupportRating(input).ToString(), day, 2);
        }

        private static void ExecuteDayFour(FileReader fileReader, int day)
        {
            List<string> input = fileReader.ReadLinesFromFile($"Inputs/Day{day}.txt");
            DayFour puzzle = new DayFour();
            ResultWriter.Write(puzzle.GetWinningBoardValue(input).ToString(), day, 1);
            ResultWriter.Write(puzzle.GetLoosingBardValue(input).ToString(), day, 2);
        }
    }
}
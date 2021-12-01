using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.Services
{
    internal static class ResultWriter
    {
        internal static void Write(string result, int day, int part)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Result for Day {day}, Part {part}");
            Console.WriteLine(result);
            Console.WriteLine("----------------------------");
        }
    }
}
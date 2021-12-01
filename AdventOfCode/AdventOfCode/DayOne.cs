using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode
{
    public class DayOne
    {
        public int GetNrOfIncreasings(List<decimal> input, bool window = false)
        {
            if (input == default)
            {
                Console.WriteLine("Error - Input not set");
                return -1;
            }
            int counter = 0;
            for (int i = 1; i < input.Count; i++)
            {
                if (IsIncrease(sum(input, i - 1, window), sum(input, i, window)))
                {
                    counter++;
                }
            }

            return counter;
        }

        private decimal sum(List<decimal> input, int i, bool window)
        {
            if (window)
            {
                if (i <= 0)
                {
                    return decimal.MaxValue;
                }
                if (i >= input.Count - 1)
                {
                    return decimal.MinValue;
                }
                return input[i - 1] + input[i] + input[i + 1];
            }
            return input[i];
        }

        private bool IsIncrease(decimal a, decimal b)
        {
            if (a < b)
            {
                return true;
            }
            return false;
        }
    }
}
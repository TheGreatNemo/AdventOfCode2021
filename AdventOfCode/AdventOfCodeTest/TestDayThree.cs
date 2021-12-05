using NUnit.Framework;

using AdventOfCode;
using System.Collections.Generic;

namespace AdventOfCodeTest
{
    public class TestsDayThree
    {
        [Test]
        public void Test1()
        {
            DayThree day = new DayThree();
            var input = new List<string>()
            {
                "00100",
                "11110",
                "10110",
                "10111",
                "10101",
                "01111",
                "00111",
                "11100",
                "10000",
                "11001",
                "00010",
                "01010",
            };
            Assert.AreEqual(198, day.GetPowerConsumption(input));
        }

        [Test]
        public void Test2()
        {
            DayThree day = new DayThree();
            var input = new List<string>()
            {
                "00100",
                "11110",
                "10110",
                "10111",
                "10101",
                "01111",
                "00111",
                "11100",
                "10000",
                "11001",
                "00010",
                "01010",
            };
            Assert.AreEqual(230, day.GetLifeSupportRating(input));
        }
    }
}
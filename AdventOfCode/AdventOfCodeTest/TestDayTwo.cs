using NUnit.Framework;

using AdventOfCode;
using System.Collections.Generic;

namespace AdventOfCodeTest
{
    public class TestsDayTwo
    {
        [Test]
        public void Test1()
        {
            DayTwo day = new DayTwo();
            var input = new List<string>()
            {
                "forward 5",
                "down 5",
                "forward 8",
                "up 3",
                "down 8",
                "forward 2",
                "down 8",
                "forward 2",
            };
            Assert.AreEqual(306, day.GetPosition(input));
        }

        [Test]
        public void Test2()
        {
            DayTwo day = new DayTwo();
            var input = new List<string>()
            {
                "forward 5",
                "down 5",
                "forward 8",
                "up 3",
                "down 8",
                "forward 2",
            };
            Assert.AreEqual(900, day.GetAimPosition(input));
        }
    }
}
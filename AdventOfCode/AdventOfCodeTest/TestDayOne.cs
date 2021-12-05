using NUnit.Framework;

using AdventOfCode;
using System.Collections.Generic;

namespace AdventOfCodeTest
{
    public class TestsDayOne
    {
        [Test]
        public void Test1()
        {
            DayOne day = new DayOne();
            var input = new List<decimal>()
            {
                199,
                200,
                208,
                210,
                200,
                207,
                240,
                269,
                260,
                263,
            };
            Assert.AreEqual(7, day.GetNrOfIncreasings(input));
        }

        [Test]
        public void Test2()
        {
            DayOne day = new DayOne();
            var input = new List<decimal>()
            {
                199,
                200,
                208,
                210,
                200,
                207,
                240,
                269,
                260,
                263,
            };
            Assert.AreEqual(5, day.GetNrOfIncreasings(input, true));
        }
    }
}
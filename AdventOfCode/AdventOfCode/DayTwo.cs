using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode
{
    public class DayTwo
    {
        public int GetPosition(List<string> input)
        {
            int hPos = 0;
            int dPos = 0;

            foreach (string s in input)
            {
                string[] line = s.Split(' ');
                switch (line[0])
                {
                    case "forward":
                        hPos += int.Parse(line[1]);
                        break;

                    case "up":
                        dPos -= int.Parse(line[1]);
                        break;

                    case "down":
                        dPos += int.Parse(line[1]);
                        break;
                }
            }

            return hPos * dPos;
        }

        public int GetAimPosition(List<string> input)
        {
            int hPos = 0;
            int dPos = 0;
            int aim = 0;

            foreach (string s in input)
            {
                string[] line = s.Split(' ');
                switch (line[0])
                {
                    case "forward":
                        hPos += int.Parse(line[1]);
                        dPos += aim * int.Parse(line[1]);
                        break;

                    case "up":
                        aim -= int.Parse(line[1]);
                        break;

                    case "down":
                        aim += int.Parse(line[1]);
                        break;
                }
            }

            return hPos * dPos;
        }
    }
}
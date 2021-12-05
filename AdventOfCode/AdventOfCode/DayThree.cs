using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode
{
    public class DayThree
    {
        public int GetPowerConsumption(List<string> input)
        {
            int[] counter = GetCounter(input);

            (int, int) ge = GetDecimal(GetGammaEpsilon(counter, input.Count));

            return ge.Item1 * ge.Item2;
        }

        public int GetLifeSupportRating(List<string> input)
        {
            int[] counter = GetCounter(input);

            int[] o2 = ConvertToArray(GetSingle(input, counter, true));
            int[] co2 = ConvertToArray(GetSingle(input, counter, false));

            (int, int) o2co2 = GetDecimal((o2, co2));

            return o2co2.Item1 * o2co2.Item2;
        }

        private int[] ConvertToArray(string str)
        {
            int[] array = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                array[i] = int.Parse(str[i].ToString());
            }
            return array;
        }

        private string GetSingle(List<string> input, int[] counter, bool oxy)
        {
            List<string> result = new List<string>(input);
            for (int i = 0; i < counter.Length; i++)
            {
                counter = GetCounter(result);
                if (counter[i] >= (float)result.Count / 2)
                {
                    result = oxy ? RemoveItem(result, i, '1') : RemoveItem(result, i, '0');
                }
                else
                {
                    result = oxy ? RemoveItem(result, i, '0') : RemoveItem(result, i, '1');
                }
                if (result.Count == 1)
                {
                    return result[0];
                }
            }

            return "";
        }

        private List<string> RemoveItem(List<string> input, int index, char criteria)
        {
            List<string> result = new List<string>(input);
            foreach (string line in input)
            {
                if (!line[index].Equals(criteria))
                {
                    result.Remove(line);
                }
            }
            return result;
        }

        private (int, int) GetDecimal((int[], int[]) tuple)
        {
            string item1str = "";
            foreach (int i in tuple.Item1)
            {
                item1str += i.ToString();
            }

            string item2str = "";
            foreach (int i in tuple.Item2)
            {
                item2str += i.ToString();
            }

            int item1 = Convert.ToInt32(item1str, 2);
            int item2 = Convert.ToInt32(item2str, 2);

            return (item1, item2);
        }

        private (int[], int[]) GetGammaEpsilon(int[] counter, int count)
        {
            int[] gamma = new int[counter.Length];
            int[] epsilon = new int[counter.Length];

            for (int i = 0; i < counter.Length; i++)
            {
                if (counter[i] > count / 2)
                {
                    gamma[i]++;
                }
                else
                {
                    epsilon[i]++;
                }
            }

            return (gamma, epsilon);
        }

        private int[] AddToCounter(string line, int[] counter)
        {
            for (int i = 0; i < counter.Length; i++)
            {
                counter[i] += int.Parse(line[i].ToString());
            }
            return counter;
        }

        private int[] GetCounter(List<string> input)
        {
            int[] counter = new int[input[0].Length];

            foreach (string line in input)
            {
                counter = AddToCounter(line, counter);
            }
            return counter;
        }
    }
}
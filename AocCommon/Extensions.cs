using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AocCommon
{
    public static class Solutions
    {
        public static void Day1(string[] args)
        {
            var input = Data.p1_1;

            foreach (var i in input)
            {

                foreach (var j in input)
                {
                    //if(i+j == 2020)
                    //{
                    //    Console.WriteLine(i * j);
                    //    Console.ReadKey();
                    //}
                    foreach (var k in input)
                    {
                        if (i + j + k == 2020)
                        {
                            Console.WriteLine(i * j * k);
                            Console.ReadKey();
                        }
                    }
                }
            }
        }
    }

    public static class Extensions
    {        
        public static int GetCount(this string input, char searchChar)
        {
            int count = 0;
            int index = 0;
            char charToCount = searchChar;
            foreach (char c in input)
            {
                if (c == charToCount)
                {
                    count++;
                }
                else
                {
                    // Console.WriteLine($"{searchChar} not found in {input} at index {index}");
                }
                index++;
            }
            return count;
        }
        public static Dictionary<int, bool> GetCountAndPosition(this string input, char searchChar)
        {
            var result = new Dictionary<int, bool>();
            int index = 1;
            char charToCount = searchChar;
            foreach (char c in input)
            {

                if (c == charToCount)
                {
                    result.Add(index, true);
                }
                else
                {
                    result.Add(index, false);
                }
                index++;
            }
            return result;
        }
        public static bool IsValid_d2_p1(this string input, char searchChar, int min, int max)
        {
            int freq = input.GetCount(searchChar);
            if (freq >= min && freq <= max)
                return true;
            return false;
        }
        public static bool IsValid_d2_p2(this p2Element input)
        {
            int cnt = 0;
            var ary = input.Password.ToArray();
            var dict = input.Password.GetCountAndPosition(input.Char);
            if (dict[input.Min])
                cnt++;
            if (dict[input.Max])
                cnt++;
            if (cnt == 1)
                return true;
            return false;
        }
    }
}

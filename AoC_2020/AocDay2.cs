using AocCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC_2020
{
    public static class AocDay2
    {
        public static void Solve()
        {
                Console.WriteLine($"AoC 2020 DAY 2 {Environment.NewLine}");
                Console.WriteLine($"d2p1 solution = {AocDay2.d2p1()}");
                Console.WriteLine($"d2p2 solution = {AocDay2.d2p2()}");
                Console.WriteLine();
                Console.Write("Done - press any key to exit.");
                Console.ReadKey();
        }
        public static int d2p1()
        {
            var input = Data.p2_1();
            int valid = 0;

            foreach (var i in input.Select(x => x.Value))
            {
                if (i.Password.IsValid_d2_p1(i.Char, i.Min, i.Max))
                    valid++;
            }

            return valid;
        }
        public static int d2p2()
        {
            var input = Data.p2_1();
            int valid = 0;

            foreach (var i in input)
            {
                if (i.Value.IsValid_d2_p2())
                    valid++;
            }

            return valid;
        }
    }
}

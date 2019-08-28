using System;
using System.Linq;

namespace LeetCodeLibrary
{
    public class ReverseInteger
    {
        public int Run1(int x)
        {
            var s = x.ToString();
            var negative = x < 0;
            var s2 = negative ? "-" : "";
            for (var i = s.Length - 1; i >= (negative ? 1 : 0); i--)
            {
                s2 += s[i];
            }
            if (int.TryParse(s2, out var result))
                return result;
            return 0;
        }

        public int Run2(int x)
        {
            int max = int.MaxValue / 10;
            var negative = x < 0;
            if (negative)
                x = -x;
            int result = 0;
            while (x > 0)
            {
                if (result > max)
                    return 0;
                result = (10 * result) + (x % 10);
                x = x / 10;
            };
            if (negative)
                result = -result;
            return result;
        }
    }
}
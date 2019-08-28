using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeLibrary
{
    public class PalindromeNumber
    {
        public bool Run1(int x)
        {
            var s = x.ToString();
            for (var i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                    return false;
            }
            return true;
        }
    }
}
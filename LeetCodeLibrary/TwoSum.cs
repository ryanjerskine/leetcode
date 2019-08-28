using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCodeLibrary
{
    public class TwoSum
    {
        // Time complexity: O(n^2)
        // Space complexity: O(1)
        public int[] Run1(int[] nums, int target)
        {
            for (var i = 0; i < nums.Length; i++)
                for (var j = 0; j < nums.Length; j++)
                    if (j != i && nums[i] + nums[j] == target)
                        return new int[] { i, j };
            throw new ArgumentException("Assumption violated.");
        }

        // Time complexity: O(n)
        // Space complexity: O(n)
        public int[] Run2(int[] nums, int target)
        {
            var hashMap = new Dictionary<int, int>();
            for (var i = 0; i < nums.Length; i++)
                hashMap[nums[i]] = i;
            for (var i = 0; i < nums.Length; i++)
            {
                if (hashMap.TryGetValue(target - nums[i], out var j))
                    if (j != i)
                        return new int[] { i, j };
            }
            throw new ArgumentException("Assumption violated.");
        }

        // Time complexity: O(n)
        // Space complexity: O(n)
        public int[] Run3(int[] nums, int target)
        {
            var dictionary = new Dictionary<int, int>();
            for (var i = 0; i < nums.Length; i++)
            {
                if (dictionary.TryGetValue(target - nums[i], out var j))
                    if (j != i)
                        return new int[] { j, i };
                dictionary[nums[i]] = i;
            }
            throw new ArgumentException("Assumption violated.");
        }

        // Time complexity: O(n)
        // Space complexity: O(n)
        public int[] Run4(int[] nums, int target)
        {
            var table = new Hashtable();
            table[nums[0]] = 0;
            for (var i = 1; i < nums.Length; i++)
            {
                var diff = target - nums[i];
                if (table.Contains(diff))
                    return new int[2] { (int)table[diff], i };
                var origin = target - diff;
                if (!table.Contains(origin))
                    table[origin] = i;
            }
            throw new ArgumentException("Assumption violated.");
        }
    }
}
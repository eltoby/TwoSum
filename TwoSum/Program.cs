using System;
using System.Collections.Generic;
using System.Linq;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            Console.WriteLine(p.TwoSum(new[] {2,7,11,15}, 9));
        }

        public int[] TwoSum(int[] nums, int target)
        {
            var dic = new Dictionary<int, int>(nums.Length);

            for (var i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(target - nums[i]))
                    return new[] { dic[target - nums[i]], i };
                else
                    dic[nums[i]] = i;
            }

            return null;
        }
    }
}

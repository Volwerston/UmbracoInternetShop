using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    public class Solution
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            int toReturn = Int32.MinValue;
            if (nums.Length <= 2) return Int32.MinValue;
            if (nums.Length == 3)
            {
                return nums[0] + nums[1] + nums[2];
            }

            Array.Sort(nums);

            for (int i = 0; i <= nums.Length - 3; ++i)
            {
                if (i == 0 || nums[i] > nums[i - 1])
                {

                    int start = i + 1;
                    int end = nums.Length - 1;

                    while (start < end)
                    {
                        if (toReturn == Int32.MinValue || Math.Abs(nums[i] + nums[end] + nums[start] - target) < Math.Abs(toReturn - target))
                        {
                            toReturn = nums[i] + nums[start] + nums[end];
                        }

                        if (nums[i] + nums[end] + nums[start] < target)
                        {
                            int currentStart = start;
                            while (nums[start] == nums[currentStart] && start < end)
                            {
                                ++start;
                            }
                        }
                        else
                        {
                            int currentEnd = end;
                            while (nums[end] == nums[currentEnd] && start < end)
                            {
                                --end;
                            }
                        }
                    }

                }
            }

            return toReturn;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            new Solution().ThreeSumClosest(new int[] { 1, 1, 1, 0 }, 100);


            Console.ReadKey();
        }
    }
}

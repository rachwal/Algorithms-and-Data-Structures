using System;

namespace ProgramCreek
{
    public class HouseRobber
    {
        public int RobDp(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }

            if (nums.Length == 0)
            {
                return nums[0];
            }

            var dp = new int[nums.Length];
            dp[0] = nums[0];
            dp[1] = Math.Max(nums[0], nums[1]);

            for (var i = 2; i < nums.Length; i++)
            {
                dp[i] = Math.Max(dp[i - 2] + nums[i], dp[i - 1]);
            }
            return dp[nums.Length - 1];
        }

        public int RobLv(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }

            var even = 0;
            var odd = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if (i%2 == 0)
                {
                    even += nums[i];
                    even = even > odd ? even : odd;
                }
                else
                {
                    odd += nums[i];
                    odd = even > odd ? even : odd;
                }
            }
            return even > odd ? even : odd;
        }
    }
}
// https://leetcode.com/problems/two-sum/description/?envType=problem-list-v2&envId=dk2wta1c

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int indexLeft = 0;
        int indexRight = 1;
        int length = nums.Length;
        for(int i = 0; i < length; i++)
        {
            indexLeft = i;
            for(int j = indexLeft + 1; j < length; j++)
            {
                indexRight = j;
                if(nums[indexLeft] + nums[indexRight] == target)
                {
                    return [indexLeft, indexRight];
                }
            }
        }
        return [0,0];
    }
}
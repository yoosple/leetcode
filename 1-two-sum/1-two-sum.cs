public class Solution {
    public int[] TwoSum(int[] nums, int target) {        
        Dictionary<int, int> dic = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (dic.ContainsKey(target - nums[i])) 
            {
                return new int[] { dic[target - nums[i]], i };
            }
            else if (!dic.ContainsKey(nums[i])) 
            {
                dic.Add(nums[i], i);
            }
        }

        return new int[2];
    }
}
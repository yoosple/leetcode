public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] merged = nums1.Concat(nums2).OrderBy(x => x).ToArray();

        if (merged.Length % 2 == 0)
        {
            int a = merged.Length / 2;
            int b = a - 1;
            double result = ((double)merged[b] + (double)merged[a]) / 2;
            
            return result;
        }
        else
        {
            int i = (merged.Length - 1) / 2;

            return merged[i];
        }
    }
}
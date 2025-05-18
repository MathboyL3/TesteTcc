public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var length = nums.Length;
        Dictionary<int, int> comp = new(length)
        {
            { nums[0], 0 }
        };
        for(int i = 1; i < length; i++)
        {
            var num = nums[i];
            if (comp.ContainsKey(target - num))
                return [i, comp[target - num]];
            _ = comp.TryAdd(num, i);
        }
        return null;
    }
}

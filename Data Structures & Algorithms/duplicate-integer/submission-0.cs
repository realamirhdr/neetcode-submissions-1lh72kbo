public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int, bool> existingDictionary = new Dictionary<int, bool>();

        for (int i = 0; i < nums.Length; i++)
        {
            existingDictionary.TryGetValue(nums[i], out var exists);

            if (exists)
            {
                return true;
            }
            else
            {
                existingDictionary.Add(nums[i], true);
            }
        }

        return false;
    }
}
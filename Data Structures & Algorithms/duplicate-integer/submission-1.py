class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:
        
        existing = set(nums)

        if len(existing) == len(nums):
            return False
        
        return True

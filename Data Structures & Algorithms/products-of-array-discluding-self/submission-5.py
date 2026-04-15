class Solution:
    def productExceptSelf(self, nums: List[int]) -> List[int]:
        output = []
        mul = 1

        for i in range(0, len(nums)):
            output.append(mul)
            mul *= nums[i]

        mul = 1
        for j in range(len(nums) - 1, -1, -1):
            output[j] *= mul
            mul *= nums[j]

        return output

                
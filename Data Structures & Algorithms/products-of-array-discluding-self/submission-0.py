class Solution:
    def productExceptSelf(self, nums: List[int]) -> List[int]:
        output = []

        for i in range(0, len(nums)):
            el = 1
            for j in range(0, len(nums)):
                if i == j:
                    continue

                el *= nums[j]
            output.append(el)

        return output

                
class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        dic = {}

        for n in nums:
            dic[n] = dic.get(n, 0) + 1

        res = [x[0] for x in sorted(dic.items(), key= lambda x: -x[1])]
        
        return res[0:k]
class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        def isAnagram(s: str, t: str) -> bool:
                
                    if len(s) != len(t):
                        return False

                    dicS = {}
                    dicT = {}

                    for i in range(len(s)):
                        dicS[s[i]] = dicS.get(s[i], 0) + 1
                        dicT[t[i]] = dicT.get(t[i], 0) + 1


                    return dicT == dicS

        dic = {}

        for word in strs:
            found = False
            for gr in dic:
                if isAnagram(gr, word):
                    dic[gr].append(word)
                    found = True
                    break
            if not found:
                dic[word] = [word]

        
        return list(dic.values())
            
class Solution:

    def encode(self, strs: List[str]) -> str:
        if len(strs) == 0:
            return "?|?"

        encoded = str("")
        for i, s in enumerate(strs):
            encoded += s
            if not i == len(strs) - 1:
                encoded += "?|"

        return encoded
            

    def decode(self, s: str) -> List[str]:
        result = []

        if s == "?|?":
            return []

        for st in s.split("?|"):
            result.append(st)

        return result

public class Solution {

 public bool IsAnagram(string s, string t)
 {
         var firstStr = s.ToCharArray();
     var secondStr = t.ToCharArray();

        Array.Sort(firstStr);
        Array.Sort(secondStr);
     return firstStr.SequenceEqual(secondStr);
}}

public class Solution {
 public  List<List<string>> GroupAnagrams(string[] strs)
 {
     var res = new List<List<string>>();

     if (strs.Length == 0)
     {
         return res;
     }

     for (int i = 0; i < strs.Length; i++)
     {
         if (strs[i] == null)
         {
             continue;
         }

         var anagrams = new List<string>();
         anagrams.Add(strs[i]);
         for (int j = i + 1; j < strs.Length; j++)
         {
              if (strs[j] == null)
         {
             continue;
         }
             if (IsAnagram(strs[i], strs[j]))
             {
                 anagrams.Add(strs[j]);
                 strs[j] = null;
             }
         }

         strs[i] = null;
         res.Add(anagrams.ToList());
     }

     return res;
 }

 public  bool IsAnagram(string s, string t)
 {
     var firstStr = s.ToCharArray();
     var secondStr = t.ToCharArray();

     Array.Sort(firstStr);
     Array.Sort(secondStr);

     return firstStr.SequenceEqual(secondStr);
 }
}

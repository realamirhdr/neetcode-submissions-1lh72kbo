public class Solution {

 public bool IsAnagram(string s, string t)
 {
     Dictionary<char, int> MakeDictionaryOfChars(string str)
     {
         var dic = new Dictionary<char, int>();

         foreach (char c in str)
         {
             dic.TryGetValue(c, out var count);

             if (count == 0)
             {
                 dic.Add(c, 1);
             }
             else
             {
                 dic.Remove(c);
                 dic.Add(c, count + 1);
             }
         }

         return dic;
     }

     var sDic = MakeDictionaryOfChars(s);
     var tDic = MakeDictionaryOfChars(t);

        if (tDic.Count != sDic.Count)
        {
            return false;
        }

     foreach (var tPair in tDic)
     {
         var sCharCount = sDic.GetValueOrDefault(tPair.Key);

         if (sCharCount != tPair.Value)
         {
             return false;
         }

     }

     return true;
 }
}

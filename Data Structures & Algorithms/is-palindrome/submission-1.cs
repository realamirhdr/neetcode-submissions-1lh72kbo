public class Solution {
      public bool IsPalindrome(string s)
    {
        // Pattern [^a-zA-Z0-9] matches any character not in the specified ranges.
        s = Regex.Replace(s, "[^a-zA-Z0-9]", String.Empty).ToLower();

    if (s == "")
    {
        return true;
    }
        var len = s.Length;

        var j = len - 1;
        var i = 0;

        while (i < (len / 2) + 1)
        {
            if (s[i] != s[j])
            {
                return false;
            }

            i++;
            j--;
        }

        return true;
    }
}

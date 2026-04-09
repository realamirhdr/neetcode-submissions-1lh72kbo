public class Solution {
    public bool IsValid(string s)
    {
        var oppDic = new Dictionary<char, char>( )
        {
            { ']', '[' },
            { '}', '{' },
            { ')', '(' },
        };

        Stack<char> stack = new Stack<char>();

        foreach (var c in s)
        {
            if (stack.Count == 0)
            {
                stack.Push(c);
                continue;
            }

            if (oppDic.Keys.Contains(c))
            {
                var p = (char)stack.Peek();
                if (p == oppDic.GetValueOrDefault(c))
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(c);
                }
            }
            else
            {
                stack.Push(c);
            }
        }

        if (stack.Count == 0)
        {
            return true;
        }

        return false;
    }
}

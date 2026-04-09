public class Solution {
   public int[] TopKFrequent(int[] nums, int k)
{
    var res = new int[k];
    var countDic = new Dictionary<int, int>();

    foreach (var num in nums)
    {
        countDic.TryGetValue(num, out var count);

        if (count == 0 || count == null)
        {
            countDic.Add(num, 1);
        }
        else
        {
            countDic.Remove(num);
            countDic.Add(num, count + 1);
        }
    }

    for (int i = 0; i < k; i++)
    {
        res[i] = GetMostRepeated(countDic);
        countDic.Remove(res[i]);
    }

    int GetMostRepeated(Dictionary<int, int> countDic)
    {
        var res = -1;
        var maxCount = 0;

        foreach (var count in countDic)
        {
            if (count.Value > maxCount)
            {
                maxCount = count.Value;
                res = count.Key;
            }
        }

        return res;
    }

    return res;
}
}

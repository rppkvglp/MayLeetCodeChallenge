public class Solution 
{
    public IList<int> FindAnagrams(string s, string p) {
        var sLen = s.Length;
        var pLen = p.Length;

        if (pLen > sLen) return new List<int>();

        var result = new List<int>();

        var charAndCountP = new int[256];

        foreach (var c in p) {
            charAndCountP[c]++;
        }

        var left = 0;
        var count = pLen;

        var charAndCountS = new int[256];

        for (int right = 0; right < sLen; right++) 
        {
            charAndCountS[s[right]]++;
            if (right - left + 1 == pLen) 
            {
                var isAnagram = true;
                for (int i = 0; i < 256; i++) 
                {
                    if (charAndCountP[i] != charAndCountS[i]) 
                    {
                        isAnagram = false;
                        break;
                    }
                }

                if (isAnagram) 
                {
                    result.Add(left);
                }

                charAndCountS[s[left]]--;
                left++;
            }
        }

        return result;
    }
}
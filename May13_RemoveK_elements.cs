public class Solution 
{    
    public string RemoveKdigits(string num, int k) 
    {
        
        int n = num.Length;
        if((n==1) &&(k>0))
            return (string)("0");
        
        Stack<char> s = new Stack<char>(); 

        for(int i = 0; i < n; i++)
        {
            var current = num[i];
            while(s.Count > 0 && s.Peek() > current && k > 0)
            {
                s.Pop();
                k--;
            }            
            s.Push(current);
        }

        while( k > 0 && s.Count > 0)
            {
                s.Pop();
                k--;
            }
        var numbers = s.ToList();

        var sb = new StringBuilder();
        var foundNonZero = false;
        for(int i = 0; i < numbers.Count; i++)
        {
            int ri = numbers.Count - i - 1;
            var current = numbers[ri];
            if (!foundNonZero && current == '0')
            {
                continue;
            }

            foundNonZero = true;
            sb.Append(current);
        }

        return sb.ToString().Length == 0? "0":sb.ToString();
            
    }
}
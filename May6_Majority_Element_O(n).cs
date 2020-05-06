public class Solution {
    public int MajorityElement(int[] nums) 
    
    {
        int c = 0;
        int r = 0;
        int n = nums.Length;
        
        if(n==1)
            return nums[0];
        if(n==2)
            return nums[0];
        
        Array.Sort(nums);
        
        int e = nums[0];
        int count =1;
        for(int i=1;i<n;i++)
        {
            if(e==nums[i])
            {
                count = count + 1;
            }
            else
            {                
                e = nums[i];
                count = 1;
            }
            
            if(count>c)
                {
                    c= count;
                    r=nums[i];
                }
        }
        
        return r;
    }
}
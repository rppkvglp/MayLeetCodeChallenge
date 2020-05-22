public class Solution
{
    public int SingleNonDuplicate(int[] nums) 
    {
        int left = 1;
        int n = nums.Length;
        
        if(n==1)
            return nums[0];
        
        int right = n;
        while (left < right) 
        {
            int mid = left + (right - left) / 2;
            if (nums[mid-1] == nums[mid])
            {
                left = mid+1;
            }   
            else 
            {
                right = mid;
            }
        }
        return nums[left];
    }
    
}
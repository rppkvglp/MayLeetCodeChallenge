public class Solution 
{
    private int tempk;
    private int val;
    
    public int KthSmallest(TreeNode root, int k) 
    {   
        tempk = k;
        traverse(root);
        return val;
    }

    public void traverse(TreeNode root) 
    {
        if(root == null)
            return ;
        traverse(root.left);
        tempk--;
        if(tempk==0)
        {
            val = root.val;
        }
        traverse(root.right);
    }
}
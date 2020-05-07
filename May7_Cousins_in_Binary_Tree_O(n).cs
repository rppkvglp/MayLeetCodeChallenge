/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
   
    public TreeNode node(TreeNode root, int x)
    {
        if(root == null)
            return null;
        if(root.val == x)
        {
            return root;
        }
        
        TreeNode l = node(root.left,x);
        TreeNode r = node(root.right,x);
        if(l!=null)
            return l;
        return r;
    }
    
    public int d(TreeNode root, TreeNode x,int c)
    {
        if(root == null)
            return 0;
        if(root.val == x.val)
        {
            return c;
        }
        
        int l = d(root.left,x,c+1);
        int r = d(root.right,x,c+1);
        if(l!=0)
            return l;
        return r;
    }
    
    public bool sp(TreeNode root, TreeNode a,TreeNode b)
    {
        if(root == null)
            return false;
        
        return ((root.left == a && root.right == b) ||  
            (root.left == b && root.right == a) ||  
                     sp(root.left, a, b) ||  
                     sp(root.right, a, b));
    }
    
    public bool IsCousins(TreeNode root, int x, int y) 
    {
        if((x == root.val)||(y == root.val))
            return false;
                    
        TreeNode nx = node(root,x);
        TreeNode ny = node(root,y);
        
        int dx = d(root,nx,0);
        int dy = d(root,ny,0);
                     
        if((dx == dy) && (!sp(root,nx,ny)))
           return true;
        
           return false;
        
    }
}
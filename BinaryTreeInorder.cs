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
    public IList<int> InorderTraversal(TreeNode root) {
        IList<int> ret = new List<int>();
        Stack<TreeNode> stack = new Stack<TreeNode>();
        
        TreeNode currentNode = root;
        recurse(root, ret);
        
        return ret;
    }
    
    
    public void recurse(TreeNode root, IList<int> ret) {
        if (root != null) {
            recurse(root.left, ret);
            ret.Add(root.val);
            recurse(root.right, ret);
        }
    }
}

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
    public TreeNode IncreasingBST(TreeNode root)
    {
        TreeNode result = new TreeNode(0);
        TreeNode tmp = result;
        InOrder(root, tmp);
        return result.right;
    }

    TreeNode InOrder(TreeNode root, TreeNode tmp)
    {
        if (root == null)
        {
            return tmp;
        }
        tmp = InOrder(root.left, tmp);
        tmp.right = root;
        root.left = null;
        tmp = root;
        return InOrder(root.right, tmp);
    }
}
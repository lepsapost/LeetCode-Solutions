public class Solution {
    public bool IsSymmetric(TreeNode root) {
        if (root == null) return true;
        return IsMirror(root.left, root.right);
    }
    
    private bool IsMirror(TreeNode left, TreeNode right) {
            if (left == null && right == null) return true;
            if (left == null || right == null) return false;

            return (left.val == right.val) &&
            IsMirror (left.left, right.right) &&
            IsMirror (left.right, right.left);

    }
}
    
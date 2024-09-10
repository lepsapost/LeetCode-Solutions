public class Solution {
    public int SumRootToLeaf(TreeNode root) {
        return DFS(root, 0);
    }
    private int DFS(TreeNode node, int currentSum) {
        if (node==null) return 0;
    
    currentSum = (currentSum * 2) + node.val;

    if (node.left == null && node.right == null) {
        return currentSum;
    }
    return DFS(node.left, currentSum) + DFS(node.right, currentSum);
    }
}
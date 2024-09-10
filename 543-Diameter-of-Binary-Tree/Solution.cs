public class Solution {
    private int maxDiameter = 0;

        public int DiameterOfBinaryTree(TreeNode root) {
            MaxDepth(root);
            return maxDiameter;
        }

        private int MaxDepth(TreeNode node) {
            if (node == null) 
            return 0;

            int leftDepth = MaxDepth(node.left);
            int rightDepth = MaxDepth(node.right);

            maxDiameter = Math.Max(maxDiameter, leftDepth + rightDepth);
            return Math.Max(leftDepth, rightDepth) + 1;
        }
}
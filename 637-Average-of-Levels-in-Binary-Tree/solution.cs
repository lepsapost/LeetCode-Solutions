public class Solution {
    public IList<double> AverageOfLevels(TreeNode root) {
        if (root == null) return new List<double>();

        var result = new List<double>();
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0) { 
            int levelSize = queue.Count; // size of the current level
            double levelSum = 0;

            for (int i = 0; i < levelSize; i++) {
                TreeNode node = queue.Dequeue(); // get the next node in the queue
                levelSum += node.val; 

                if (node.left != null) queue.Enqueue(node.left); 
                if (node.right != null) queue.Enqueue(node.right);
            }

            result.Add(levelSum / levelSize);
        }

        return result;
    }
}
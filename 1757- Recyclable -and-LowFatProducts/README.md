   # 101. Symmetric Tree

   ## Problem Description
   Given the root of a binary tree, check whether it is a mirror of itself (i.e., symmetric around its center).

   ## Example
   Input: root = [1,2,2,3,4,4,3]
   Output: true

   ## Constraints
   - The number of nodes in the tree is in the range [1, 1000].
   - -100 <= Node.val <= 100

   ## Approach
   We use a recursive approach to check if the left and right subtrees are mirrors of each other. We define a helper function `IsMirror` that takes two nodes as input and checks if they are symmetric.

   ## Complexity
   - Time complexity: O(n), where n is the number of nodes in the tree.
   - Space complexity: O(h) in the worst case, where h is the height of the tree (due to the recursive call stack).
# 1022. Sum of Root To Leaf Binary Numbers

## Problem Description
You are given the root of a binary tree where each node has a value 0 or 1. Each root-to-leaf path represents a binary number starting with the most significant bit. For example, if the path is 0 -> 1 -> 1 -> 0 -> 1, then this could represent 01101 in binary, which is 13 in decimal.

For all leaves in the tree, consider the numbers represented by the path from the root to that leaf. Return the sum of these numbers.

## Approach
We use a depth-first search (DFS) approach to traverse the tree. As we traverse down a path, we build the binary number by shifting left and adding the current node's value. When we reach a leaf, we add the constructed number to our total sum.

1. We start with a helper function `DFS` that takes the current node and the current sum.
2. For each node, we update the current sum: `currentSum = (currentSum * 2) + node.val`
3. If we reach a leaf (no left or right child), we return the current sum.
4. Otherwise, we recursively call DFS on the left and right children and return their sum.

## Complexity
- Time Complexity: O(N), where N is the number of nodes in the tree. We visit each node once.
- Space Complexity: O(H), where H is the height of the tree, due to the recursive call stack.

## Code Explanation
- `SumRootToLeaf`: The main function that initializes the DFS process.
- `DFS`: A recursive helper function that does the main work of constructing the binary numbers and summing them up.
# 543. Diameter of Binary Tree

## Problem Description
Given the root of a binary tree, return the length of the diameter of the tree.

The diameter of a binary tree is the length of the longest path between any two nodes in a tree. This path may or may not pass through the root.

The length of a path between two nodes is represented by the number of edges between them.

## Approach
We use a depth-first search (DFS) approach to solve this problem. While calculating the maximum depth of each subtree, we also keep track of the longest path (diameter) we've seen so far.

1. We define a helper function `MaxDepth` that returns the maximum depth of a subtree.
2. For each node, we calculate the maximum depth of its left and right subtrees.
3. The potential diameter through the current node is the sum of the depths of its left and right subtrees.
4. We update our global `maxDiameter` if this potential diameter is larger.
5. We return the maximum depth of the current subtree (max of left and right, plus one for the current node).

## Complexity
- Time Complexity: O(N), where N is the number of nodes in the tree. We visit each node once.
- Space Complexity: O(H), where H is the height of the tree, due to the recursive call stack.

## Code Explanation
- `maxDiameter`: A class variable to keep track of the maximum diameter found so far.
- `DiameterOfBinaryTree`: The main function that initializes the process and returns the final result.
- `MaxDepth`: A recursive helper function that does the main work of calculating depths and updating the diameter.
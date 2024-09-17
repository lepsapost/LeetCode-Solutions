# LeetCode 637: Average of Levels in Binary Tree

This repository contains a solution to LeetCode problem 637: Average of Levels in Binary Tree.

## Problem Description

Given the `root` of a binary tree, return the average value of the nodes on each level in the form of an array.

## Solution

The solution uses a Breadth-First Search (BFS) approach to traverse the binary tree level by level. Here's a brief overview of the algorithm:

1. If the root is null, return an empty list.
2. Use a queue to perform level-order traversal.
3. For each level:
   - Calculate the sum of node values and the number of nodes.
   - Calculate the average and add it to the result list.
4. Return the list of level averages.

## Complexity Analysis

- Time Complexity: O(n), where n is the number of nodes in the binary tree.
- Space Complexity: O(w), where w is the maximum width of the binary tree.

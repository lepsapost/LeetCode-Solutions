# 349. Intersection of Two Arrays

## Problem Description

Given two integer arrays `nums1` and `nums2`, return an array of their intersection. Each element in the result must be unique and you may return the result in any order.

## Approach

We use a combination of sorting, binary search, and a HashSet to solve this problem efficiently:

1. Sort the first array (`nums1`) to enable binary search.
2. Create a HashSet to store unique intersection elements.
3. Iterate through the second array (`nums2`):
   - For each element, perform a binary search in the sorted `nums1`.
   - If the element is found, add it to the HashSet.
4. Convert the HashSet to an array and return it.

## Complexity Analysis

- Time Complexity: O(n log n + m log n), where n is the length of nums1 and m is the length of nums2.
  - Sorting nums1 takes O(n log n)
  - For each of the m elements in nums2, we perform a binary search in nums1, which takes O(log n)
- Space Complexity: O(min(n, m)) for the HashSet storing the intersection.
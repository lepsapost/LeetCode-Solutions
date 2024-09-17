# 88. Merge Sorted Array

## Problem Description

You are given two integer arrays `nums1` and `nums2`, sorted in non-decreasing order, and two integers `m` and `n`, representing the number of elements in `nums1` and `nums2` respectively.

Merge `nums1` and `nums2` into a single array sorted in non-decreasing order.

The final sorted array should not be returned by the function, but instead be stored inside the array `nums1`. To accommodate this, `nums1` has a length of `m + n`, where the first `m` elements denote the elements that should be merged, and the last `n` elements are set to 0 and should be ignored. `nums2` has a length of `n`.

## Approach

We use a two-pointer approach, starting from the end of both arrays:

1. Initialize three pointers:
   - `i`: points to the last non-zero element in `nums1`
   - `j`: points to the last element in `nums2`
   - `k`: points to the last position in the merged array (which is `nums1`)

2. Compare elements from the end of both arrays and place the larger one at the end of `nums1`.

3. Move the pointers accordingly:
   - Decrement `k` after each placement
   - Decrement `i` if an element from `nums1` was placed
   - Decrement `j` if an element from `nums2` was placed

4. Continue this process until all elements from `nums2` are placed (i.e., until `j` becomes negative).

## Complexity Analysis

- Time Complexity: O(m + n), where m and n are the lengths of nums1 and nums2 respectively.
- Space Complexity: O(1), as we're modifying the array in-place and only using a constant amount of extra space.

## Code Explanation

The solution uses a while loop to iterate through the arrays from end to beginning. In each iteration, it compares the current elements of both arrays and places the larger one at the end of `nums1`. This process continues until all elements from `nums2` are placed.

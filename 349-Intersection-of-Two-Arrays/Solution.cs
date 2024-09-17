public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {

        Array.Sort(nums1);
        var resultSet = new HashSet<int>();

        foreach (var num in nums2) {
            if (BinarySearch(nums1, num)) {
                resultSet.Add(num); // add to result set
            }
        }
        return resultSet.ToArray();
    }
        private bool BinarySearch(int[] nums, int target) {
            int left = 0; // left pointer
            int right = nums.Length -1; // right pointer

            while(left <= right) { 
                int mid = left + (right - left) / 2; // calculate mid point
                if (nums[mid] == target) {
                    return true;
                }

                if (nums[mid] < target) { 
                    left = mid + 1; // move left pointer to mid + 1
                } else {
                    right = mid - 1; // move right pointer to mid - 1
                }   
            }
            return false; // target not found
        }
    }

public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {

        int i = m - 1; 
        int j = n- 1;
        int k = m + n - 1;

        while (j>=0) {
            if (i >=0 && nums1[i] > nums2[j]) { // if nums1 is greater than nums2
                nums1[k] = nums1[i];
                i--; 
            } else { // if nums2 is greater than nums1
                nums1[k] = nums2[j]; 
                j--;
            } 

             k--; 
        }
    }
}
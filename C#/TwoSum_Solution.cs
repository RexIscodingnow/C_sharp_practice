namespace C_Sharp {
    public class Solution {
        public int[] TwoSum(int[] nums, int target) {
            /* 目標: Two Sum，回傳索引值 (陣列長度 = 2) */
            int[] ans = new int[2];

            for (int i = 0; i < nums.Length; i++) {
                for (int j = i+1; j < nums.Length; j++) {
                    if (nums[i] + nums[j] == target){
                        ans = new int[] {i, j};
                    }
                }
            }
            return ans;
        }
    }
}
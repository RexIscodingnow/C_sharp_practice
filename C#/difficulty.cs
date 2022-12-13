using static System.Console;

namespace C_Sharp {
    namespace difficulty {
        public class LeetCode_EasyQuestion {
            public static void leetCode_EasyQA() {
                // 目標: 找相同的 開頭前綴字
                // LongestCommonPrefix_Solution solution = new LongestCommonPrefix_Solution();
                // string result;
                // string[] strs;

                // strs = new string[] {"flower","flow","flight"};
                // result = solution.LongestCommonPrefix(strs);
                // Console.WriteLine(result);
                
                // strs = new string[] {"car", "cir"};
                // result = solution.LongestCommonPrefix(strs);
                // Console.WriteLine(result);

                /* ------------------------我是分隔線------------------------ */

                // 目標: Two Sum，回傳索引值 (陣列長度 = 2)
                // Solution solution = new Solution();
                // int[] result;
                // int[] nums = {2, 7, 11, 15};
                // int target = 9;
                // result = solution.TwoSum(nums, target);
                // Console.WriteLine(result[0] + " " + result[1]);
                
                // nums = new int[] {3, 2, 4};
                // target = 6;
                // result = solution.TwoSum(nums, target);
                // Console.WriteLine(result[0] + " " + result[1]);

                /* ------------------------我是分隔線------------------------ */

                // 
            }
        }


        public class LeetCode_MediumQuestion {
            public static void leetCode_MediumQA() {
                // LengthOfLongestSubstring_Solution solution = new LengthOfLongestSubstring_Solution();
                // string s = "abcabcbb";
                // solution.LengthOfLongestSubstring(s);
                // s = "pwwkew";
                // solution.LengthOfLongestSubstring(s);

                // MyAtoi_Soluiton soluiton = new MyAtoi_Soluiton();
                // s = "123";
                // soluiton.MyAtoi(s);
                // s = "100 million";
                // soluiton.MyAtoi(s);

            }
        }


        public class LeetCode_HardQuestion {
            public static void leetcode_HardQA() {
                // 兩陣列合併 找中位數
                FindMedianSortedArrays_Solution solution = new FindMedianSortedArrays_Solution();
                int[] nums1, nums2;
                double result;
                // nums1 = new int[] {1, 3};
                // nums2 = new int[] {2};
                // result = solution.FindMedianSortedArrays(nums1, nums2);

                nums1 = new int[] {1, 2};
                nums2 = new int[] {3, 4, 7};
                result = solution.FindMedianSortedArrays(nums1, nums2);
                WriteLine(result);
            }
        }

    }
}
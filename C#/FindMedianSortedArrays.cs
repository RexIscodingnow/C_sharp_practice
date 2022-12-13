using static System.Console;

namespace C_Sharp {
    public class FindMedianSortedArrays_Solution {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
            /*
                目標: 兩陣列 合併找中位數

                ** 註: 合併之陣列，由小到大排序
            */

            int[] all_nums = mergeTwoArray(nums1, nums2);
            double total = 0;
            double meduim = 0;
            
            int i = 0;
            if (all_nums.Length % 2 == 0) {
                i = all_nums.Length / 2;
                total = all_nums[i] + all_nums[i-1];
                meduim = total / 2;
            }
            else {
                i = (all_nums.Length / 2); 
                meduim = all_nums[i];
            }


            return meduim;
        }

        public static int[] mergeTwoArray(int[] nums1, int[] nums2) {
            /* 整合兩陣列 */
            int total_len = nums1.Length + nums2.Length;
            int[] all_nums = new int[total_len];

            int i = 0;
            int temp_len = 0;
            int[] arr;
            if (nums1.Length > nums2.Length) {
                for (i = 0; i < nums2.Length; i++) {
                    all_nums[i] = nums2[i];
                }
                temp_len = nums1.Length;
                arr = nums1;
            }
            else {
                for (i = 0; i < nums1.Length; i++) {
                    all_nums[i] =  nums1[i];
                }
                temp_len = nums2.Length;
                arr = nums2;
            }
            for (int j = 0; j < temp_len; j++) {
                all_nums[i] = arr[j];
                i++;
            }

            all_nums = sortedArray(all_nums);
            return all_nums;
        }

        public static int[] sortedArray(int[] array) {
            /* 排序 */
            for (int i = 0; i < array.Length; i++) {
                for (int j = i+1; j < array.Length; j++) {
                    if (array[i] > array[j]) {
                        int min = array[j];
                        array[j] = array[i];
                        array[i] = min;
                    }
                }
            }

            return array;
        }


        private static void printArr(int[] arr) {
            foreach (int i in arr) {
                WriteLine(i);
            }
        }
    }
}
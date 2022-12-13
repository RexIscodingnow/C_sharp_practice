
namespace C_Sharp{
    public class LongestCommonPrefix_Solution {
        public string LongestCommonPrefix(string[] strs) {
            /*
            目標: 找相同的 開頭前綴字

            類似活塞的運作方式
            指派，以下簡稱 交給 (X

            ** 陣列長度 有超過 1 個以上，作為前提 **
            1. 結果值 先塞第一個字串 (注入燃料)
            2. 從第 2 個開始，交給 暫存 (吸/進)
            3. 結果值 跟 暫存 比誰短，短的作 逐字用的範圍長度 (無)
            4. 逐字(元) 比對一樣的，交給 比對暫存 (壓)
            ; 沒有則中斷
            5. 結果值 接收比對暫存 (爆)
            6. 比對暫存 清空 (排)

            ...如此循環 => 吸/進 -> 壓 -> 爆 -> 排 -> 回到 吸/進
            */
            if (strs.Length != 0 && strs != null) {
                string compare_temp = "";   // 比對結果 暫存
                string temp = "";    // 暫存用的變數

                string result = strs[0];   // 最終結果 輸出用的。陣列第 1 個值，交給結果 暫存
                for (int i = 1; i < strs.Length; i++) {
                    temp = strs[i];    // 從第 2 個值 ~ 最後 1 個
                    int min_len = result.Length > temp.Length ? temp.Length : result.Length;    // 短的作
                    for (int j = 0; j < min_len; j++) {
                        if (temp[j] == result[j]) {
                            // 比對有相同的字元，把暫存用的變數，逐字 指派給結果
                            compare_temp += temp[j];
                        }

                        // 比第 1 個字元，不一樣就 return ""; 中斷。也就是【我們不一樣~~不一樣~~~，雖然我們型別都是字元】(誤
                        else if (temp[0] != result[0]) {
                            return "";
                        }

                        else {
                            // 比對途中 (index: 0 < j <= length ) 有不一樣的，中斷迴圈
                            break;
                        }
                    }
                    result = compare_temp;
                    compare_temp = "";    // 比對結果的暫存資料，要清除掉
                }
                return result;
            }

            else {
                return "";
            }
        }
    }
}
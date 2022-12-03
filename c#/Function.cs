namespace Program
{
    class Function
    {
        public Function(/*string option*/)
        {
            /*
                @ 的作用

                for " \ " 符號 : 把 \ 的功能取消掉
                for 字串 : 保留字串格式
            */
            // if (option == "string" || option == "s")
            // {
            //     // stringText();
            // }

            // else if (option == "\\")
            // {
            //     printPath();
            // }
        }

        // private static void printPath()
        // {
        //     // 反斜線 ( \ ) 的功能取消掉
        //     Console.WriteLine(@"C:\ouwfjsv\jioskldz\ikdacs\4854.jpg");
        // }

//         private static void stringText()
//         {
//             // 變成可換行，保留空格
//             Console.WriteLine(@"目前是
// 使用
// C#
// 編輯");
//         }

        public int[] decimalToBinary(int number)
        {
            /*
                十進制 轉 二進制

                ex:  type integer number: 12
                      2 |     12
                        |___________________________
                      2 |      6                        餘: 0
                        |___________________________
                      2 |      3                        餘: 0
                        |___________________________
                      2 |      1                        餘: 1
                        |___________________________
                               1

                12 to Binary Number is => 1100

                陣列頭尾 數值反轉
                => 假設 宣告一個 int 一維陣列，名稱為 array，總長有 10
                    從開頭的值，到最尾端的值，做左右反轉，互換頭尾數值

                互換數值的作法如下
                for (int i = 0; i < array.Length / 2; i++)
                {
                    int temp = array[i];
                    array[i] = array[(array.Length - 1) - i];
                    array[(array.Length - 1) - i] = temp;
                }

                說明: 把開頭第一個值暫存起來，與最尾端的值交換，暫存的值再指派給最尾端。
                                   不斷交換數值，朝中心點，持續往內

                      1        2      3       4       5      6       7       8       9      10
                    換 10 -> 換 9 -> 換 8 -> 換 7 -> 換 6 | 換 5 <- 換 4 <- 換 3 <- 換 2 <- 換 1
                                                          
                      先從 1 <-> 10  下一組  2 <-> 8  以此類推......
             */
            int[] result = new int[32];
            if (number > 1)
            {
                int quotient = 0, remainder = 0, i = 0;

                quotient = number / 2;
                remainder = number % 2;
                result[i] = remainder;
                while (quotient >= 2)
                {
                    int data = quotient;
                    quotient = data / 2;
                    remainder = data % 2;

                    i++;
                    result[i] = remainder;
                }

                if (quotient != 0)
                {
                    i++;
                    result[i] = 1;
                }

                // 陣列 頭尾翻轉
                int length = result.Length;
                for (int j = 0; j < length / 2; j++) {
                    int temp = result[j];
                    result[j] = result[length - 1 - j];
                    result[length - 1 - j] = temp;
                }

                return result;
            }

            else if (number < 0)
            {
                Console.WriteLine("不輸入整數，就給你 C8764 (刀劍神域 主角技能)");
                result[0] = 0;
                return result;
            }

            else
            {
                result[result.Length - 1] = 1;
                return result;
            }
        }
    }

    
}
// using Calculator;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            Function type_change = new Function();
            Console.Write("輸入整數 => ");
            string number = Console.ReadLine();
            int[] ans = new int[32];
            ans = type_change.decimalToBinary(Convert.ToInt32(number));
            Console.Write("二進制 => ");
            for (int i = 0; i < ans.Length; i++) {
                Console.Write(ans[i]);
            }

            /*
                // 例外狀況處理 try and catch

                try
                {
                    未出現例外狀況，執行區
                }
                catch
                {
                    例外狀況發生之應對執行區
                }
            */
            // Console.Write("輸入整數 => ");
            // string a = Console.ReadLine();
            // int number = 0;
            // bool flag;
            // try
            // {
            //     flag = true;
            //     number = Convert.ToInt32(a);
            // }
            // catch
            // {
            //     flag = false;
            //     Console.WriteLine("輸入錯誤");
            // }
            // if (flag)
            // {
            //     Console.WriteLine(a);
            // }

            /*
                型別轉換
            */
            // Calculate calculate = new Calculate();
            // Console.Write("輸入數字 => ");
            // string number = Console.ReadLine();
            // calculate.convertToInt(number);
        }

        public static long factorial(int number)
        {
            /*
            函式遞迴，例子如下: 階乘法 --> n! = 1 x 2 x 3 x ...... x (n - 1) x n
            
            執行方式: param number : 輸入整數 5

                呼叫函式 -> factorial(5);
                                |-> 5 * factorial(4)
                                            |-> 5 * 4 * factorial(3)
                                                            |-> ....... (以此類推)
                                                                    |-> 5 * 4 * 3 * 2 * 1 = 120
            */
            if (number == 1)
            {
                return 1;
            }
            else
            {
                return number * factorial(number - 1);
            }
        }
    }
}
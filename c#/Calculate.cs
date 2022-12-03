namespace Calculator
{
    class Calculate
    {
        public void convertToInt(string number)
        {
            int target1 = Convert.ToInt32("ToInt32 =>" + number);
            Console.WriteLine(target1);

            int target2 = int.Parse(number);
            Console.WriteLine("int.Parse() => K" + target2);
        }
    }
}
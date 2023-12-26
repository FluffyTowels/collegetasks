namespace baseConv
{
    internal class Prog
    {
        static void Main()
        {
            double number = 101.101;
            int numBase = 2;
            Console.WriteLine(BaseConvert(number, numBase, 10));
        }

        static double BaseConvert(double num, int initBase, int targBase)
        {
            string[] numSplit = Convert.ToString(num).Split(',');
            int aftPoint = numSplit[1].Length;
            for (int i = 1; i <= aftPoint; i++) num *= 10;
            int numDec = Convert.ToInt32(num);
            numDec = DecConvert(numDec, initBase);
            num = numDec;
            for (int i = 1; i <= aftPoint; i++) num /= initBase;

            numSplit = Convert.ToString(num).Split(',');

            int leftPartInit = Convert.ToInt32(numSplit[0]);
            double rightPartInit = Convert.ToDouble(numSplit[1]);
            for (int i = 1; i <= aftPoint; i++)  rightPartInit /= 10;
            string leftPartRes = " "; 
            string rightPartRes = " ";
            int pow = 1;
            int powCnt = 0;
            while (pow * targBase <= leftPartInit) pow *= targBase;
            while (leftPartInit > 0)
            {
                powCnt = (leftPartInit / pow);
                leftPartRes = leftPartRes + powCnt;
                leftPartInit -= powCnt * pow;
                pow /= targBase;
            }
            double powFrac = 1.0 / targBase;
            double powCntFrac = 0;
            while (rightPartInit > 0.000001)
            {
                powCntFrac = rightPartInit / powFrac;
                string[] powSplit = Convert.ToString(powCntFrac).Split(',');
                powCnt = int.Parse(powSplit[0]);
                rightPartRes = rightPartRes + powCnt;
                rightPartInit -= powCnt * powFrac;
                powFrac /= targBase;
            }
            leftPartRes = leftPartRes.Trim();
            rightPartRes = rightPartRes.Trim();    
            num = Convert.ToDouble(leftPartRes + "," + rightPartRes);
            return num;
        }

        static int DecConvert(int num, int initBase)
        {
            int otpt = 0;
            int pow = 1;
            while (num != 0)
            {
                otpt += (num % 10) * pow;
                pow *= initBase;
                num /= 10;
            }
            return otpt;
        }
    }
}
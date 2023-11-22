namespace SumString
{
    class Prog
    {
        static void Main()
        {
            string inpt = Console.ReadLine();
            string nums = "";
            bool space = false;
            int sum = 0;
            foreach (char c in inpt)
            {
                if (c >= '0' && c <= '9')
                {
                    nums += c;
                    space = false;
                }
                else
                {
                    if (!space)
                    {
                        nums += " ";
                        space = true;
                    }
                }
            }
            nums = nums.Trim();
            string[] N = nums.Split(' ');
            foreach (string str in N)
            {
                sum += int.Parse(str);
            }
            Console.WriteLine(sum);
        }
    }
}
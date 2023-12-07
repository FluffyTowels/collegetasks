namespace Boyer_Moore
{
    class Prog
    {
        static void Main()
        {
            string text = "In computer science, the Boyer–Moore string-search algorithm is an efficient string-searching algorithm that is the standard benchmark for practical string-search literature. It was developed by Robert S. Boyer and J Strother Moore in 1977. The original paper contained static tables for computing the pattern shifts without an explanation of how to produce them. The algorithm for producing the tables was published in a follow-on paper; this paper contained errors which were later corrected by Wojciech Rytter in 1980.";
            string keyword = "corrected";
            
			Console.WriteLine("Текст: \n" + text + "\n");
            Console.WriteLine("Искомое слово: " + keyword + "\n");
            
            int[] addrs = BoyerMooreArr(text, keyword);
            int addr = BoyerMoore(text, keyword);
           
            Console.WriteLine("Искомое слово начинается с символа: " + addr + "\n");
            Console.Write("Проверка: ");
            
            for (int i = addrs[0]; i <= addrs[1]; i++) Console.Write(text[i]);
            
            Console.WriteLine("\n");
        }

        static int BoyerMoore(string text, string key)
        {
            int[] index = new int[256];
            for (int i = 0; i < key.Length - 1; i++)    index[key[i]] = key.Length - (i + 1);
            for (int textPointr = key.Length - 1; textPointr < text.Length;)
            {
                for (int keyPointr = 0; keyPointr < key.Length;)
                {
                    if (text[textPointr - keyPointr] == key[key.Length - 1 - keyPointr]) keyPointr++;
                    else
                    {
                        BMAdvacePointer(ref textPointr, index[text[textPointr]], key.Length);
                        break;
                    }
                    if (keyPointr == key.Length - 1) return textPointr - key.Length + 1;
                }
            }
            return -1;
        }

        static int[] BoyerMooreArr(string text, string key)
        {
            int[] otpt = {-1, -1};
            int[] index = new int[256];
            for (int i = 0; i < key.Length - 1; i++) index[key[i]] = key.Length - (i + 1);
            for (int textPointr = key.Length - 1; textPointr < text.Length;)
            {

                for (int keyPointr = 0; keyPointr < key.Length;)
                {
                    if (text[textPointr - keyPointr] == key[key.Length - 1 - keyPointr]) keyPointr++;
                    else
                    {
                        BMAdvacePointer(ref textPointr, index[text[textPointr]], key.Length);
                        break;
                    }
                    if (keyPointr == key.Length - 1)
                    {
                        otpt[0] = textPointr - key.Length + 1;
                        otpt[1] = textPointr;
                        return otpt;
                    }
                }
            }
            return otpt;
        }

        static void BMAdvacePointer(ref int textPointr, int shift, int keyLen)
        {
            if (shift == 0) textPointr += keyLen;
            else textPointr += shift;
        }
    }
}
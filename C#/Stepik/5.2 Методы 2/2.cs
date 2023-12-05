static void Print (string s, string a, out string res) 
{
    int cnt = int.Parse(a);
    res = "";
    for (int i = 0; i < cnt; i++)
        res = res + s;
    
}
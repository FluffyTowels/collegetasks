namespace FileManip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fileContent = File.ReadAllLines("TiO2m6fopm.txt");
            //foreach (string content in fileContent) { Console.WriteLine(content); }
            Console.WriteLine("---------");
            for (int i = 0; i < fileContent.Length; i++) if (fileContent[i].Contains("FINAL HEAT OF FORMATION")) Console.WriteLine(i+1);
        }
    }
}
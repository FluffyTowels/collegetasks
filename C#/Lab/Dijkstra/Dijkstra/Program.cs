using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml.Serialization;


namespace Dijkstra
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            InitDijkstra();
        }

        private static void InitDijkstra()
        {
            do
            {
                string pathinput;
                bool success;
                do
                {
                    Console.Write("Введите имя файла ввода (rand если создать случайно заполненный): ");
                    pathinput = Console.ReadLine();
                    success = File.Exists(pathinput);
                    if (pathinput == "rand") success = true;
                    if (!success) Console.WriteLine("Файл не существует");
                } while (!success);
                success = false;
                bool alliterations = false;
                do
                {
                    Console.Write("Все перестановки?(Y/N): ");
                    switch (Console.ReadLine())
                    {
                        default: Console.WriteLine("Ошибка"); break;

                        case "Y": alliterations = true; success = true; break;

                        case "N": alliterations = false; success = true; break;
                    }
                } while (!success);
                Console.Write("Имя файла вывода: ");
                string pathoutput = Console.ReadLine();
                if (pathinput == "rand")
                {
                    RandFile(pathinput);
                    Dijkstra(pathinput, pathoutput, alliterations);
                }
                else Dijkstra(pathinput, pathoutput, alliterations);
                Console.WriteLine($"\nПерестановки записаны в файл {pathoutput}");
            } while (!ExitFunction());
        }
        private static int IntInput(string message)
        {
            bool success = false;
            int num = 0;
            while (!success)
            {
                Console.Write(message);
                success = Int32.TryParse(Console.ReadLine(), out num);
                if (!success) Console.WriteLine("Не число");
            }
            return num;
        }

        private static void RandFile(string pathoutput)
        {
            File.Delete(pathoutput);
            Random rand = new Random();
            int Len = IntInput("Введите кол-во элементов случайного массива: ");
            //for (int i = 0; i < Len; i++)
            //{
            //    File.AppendAllText(pathoutput, Convert.ToString(rand.Next(10, 100)));
            //    if (i < Len - 1) File.AppendAllText(pathoutput, " ");
            //}
            int[] nums = new int[Len];
            for (int i = 0; i < Len; i++)
            {
                nums[i] = rand.Next(10, 100);
            }
            ArrToFile(nums, pathoutput, false);
        }

        private static void ArrToFile(int[] nums, string path, bool linebreak = true)
        {
            //foreach (int num in nums)
            //{
            //    File.AppendAllText(path, num + " ");
            //}
            File.AppendAllText(path, $"{nums[0]}");
            for (int i = 1; i < nums.Length; i ++)
            {
                File.AppendAllText(path, " " + nums[i]);
            }
            if (linebreak) File.AppendAllText(path, "\n");
        }
        
        private static void Dijkstra(string pathinput, string pathoutput = "", bool alliterations = false)
        {

            string[] filecontentstr = File.ReadAllText(pathinput).Split(" ");
            int[] filecontentint = new int[filecontentstr.Length];
            if (pathoutput == "")
            {
                Console.Write("Имя файла вывода: ");
                pathoutput = Console.ReadLine();
            }
            File.Delete(pathoutput);
            
            for (int i = 0; i < filecontentstr.Length; i++)
            {
                filecontentint[i] = Convert.ToInt32(filecontentstr[i]);
            }
            int iprev = 0;
            ArrToFile(filecontentint, pathoutput);
            File.AppendAllText(pathoutput, "-------------\n");
            if (alliterations)
            {
                Quicksort.QuickSort(filecontentint, 0, filecontentint.Length - 1);
                ArrToFile(filecontentint, pathoutput);
            }
                for (int i = filecontentint.Length - 1; i >= 0; i--)
            {
                if (filecontentint[i] < iprev) 
                {
                    for (int j = filecontentint.Length - 1; j > i; j--)
                    {
                        if (filecontentint[j] > filecontentint[i])
                        {
                            (filecontentint[j], filecontentint[i]) = (filecontentint[i], filecontentint[j]);
                            //Quicksort.QuickSort(filecontentint, i + 1, filecontentint.Length - 1);
                            ReverseEnd(filecontentint, i + 1);
                            ArrToFile(filecontentint, pathoutput);
                            i = filecontentint.Length - 1;
                            break;
                        }
                    }
                }
                iprev = filecontentint[i];
            }
        }

        private static void ReverseEnd(int[] nums, int start) 
        {
            int i = start;
            int j = nums.Length - 1;
            while (i < j)
            {
                (nums[i], nums[j]) = (nums[j], nums[i]);
                i++;
                j--;
            }
        }
        
        private static bool ExitFunction()
        {
            Console.WriteLine("\nНажмите ESC чтобы выйти или любую клавишу чтобы продолжить");
            ConsoleKey key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.Escape) return true;
            return false;
        }
    }
}
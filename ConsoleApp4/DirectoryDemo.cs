using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class DirectoryDemo
    {
        static void Main()
        {
            DirectoryInfo dr = new DirectoryInfo(".");
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\VKodukula\Documents\");
            Console.WriteLine(dir.FullName);
            Console.WriteLine(dir.GetFiles());
            Console.WriteLine(dir.CreationTime);
            //creating file and adding data
            DirectoryInfo dire = new DirectoryInfo(@"C:\Users\VKodukula\Documents\");
            string[] cust = {
                 "ramana",
                "venkata",
                "sai"
            };
            string textFilePath = @"C:\Users\VKodukula\Documents\customers.txt";
            File.WriteAllLines(textFilePath,cust);
            foreach(string custo in File.ReadLines(textFilePath))
            {
                Console.Write($"Cusomers{custo}");
            }
            Console.ReadLine();
        }
    }
}

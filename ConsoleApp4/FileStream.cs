using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp4
{
    class FileStream
    {
        static void Main()
        {
            string path = @"C:\Users\VKodukula\Desktop\doc.txt";
            
            using (StreamWriter sw = new StreamWriter(path))
            {
                string[] s = new string[] { "ram", "sai" };
                foreach (string name in s)
                {
                    sw.WriteLine(name);
                }
            }

            using (StreamReader sr = File.OpenText(path))
            {
                String st = "";
               
                    while ((st = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(st);
                    }
                }
            
            Console.ReadKey();
        }
    }
}

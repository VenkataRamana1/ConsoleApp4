using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class FilePathDemo
    {
        public static void Main(string[] args)
        {
            String filepath = @"C:\Users\VKodukula\Documents\AP MODULE.docx";
            if (Path.HasExtension(filepath))
            {
                Console.WriteLine("File has an extension:" +Path.GetPathRoot(filepath));
            }
            string result = Path.GetRandomFileName();
            Console.WriteLine(result);
            bool pathres = Path.IsPathRooted(filepath);
            Console.WriteLine(pathres);
            string rootName = Path.GetPathRoot(filepath);
            Console.WriteLine(rootName);
            string ext = Path.GetExtension(filepath);
            Console.WriteLine(ext);
            string gfd = Path.GetDirectoryName(filepath);
            Console.WriteLine(gfd);
            string gfnwe = Path.GetFileNameWithoutExtension(filepath);
            Console.WriteLine(gfnwe);
            Console.ReadLine();
        }
    }
}

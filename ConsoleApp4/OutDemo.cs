using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class OutDemo
    {
        public static void Main()
        {
         
            GetAuther(out string AName, out string BTitle, out long PYear);
                Console.WriteLine("Author: {0}, Title: {1},Year: {2}",
                    AName, BTitle,PYear);
            Console.ReadLine();
        }
         static void GetAuther(out string name, out string title, out long year)
        {

            name = " ramana";
            title = "Hey! Mr.";
            year = 2019;
        }
        enum datas
        {
            [Description("dad")]
            TitleName 
        }
    }
}

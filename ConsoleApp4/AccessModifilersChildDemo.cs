using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class AccessModifilersChildDemo : AccessModifiersDemo
    {
        string st = "Success.";
        internal string status()
        {
            
            return st;
        }
        static void Main()
        {
            AccessModifiersDemo amd = new AccessModifiersDemo();
            amd.Test(10);
            amd.Test(1);
            Console.ReadLine();
        }
    }
}
